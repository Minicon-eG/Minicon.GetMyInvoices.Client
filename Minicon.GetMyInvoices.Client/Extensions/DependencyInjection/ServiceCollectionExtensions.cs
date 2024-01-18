using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Minicon.GetMyInvoices.Client.Api;
using Minicon.GetMyInvoices.Core;
using Refit;

namespace Minicon.GetMyInvoices.Client.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddGetMyInvoicesClient(this IServiceCollection services)
	{
		services.AddSingleton<IRequestLimiter, RequestLimiter>();
		services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
		services.AddTransient<RequestLimitDelegationHandler>();
		services.AddRefitClient<IDocumentApi>(new RefitSettings(new NewtonsoftJsonContentSerializer()))
			.ConfigureHttpClient(
				(serviceProvider, httpClient) =>
				{
					GetMyInvoicesOptions options = serviceProvider.GetRequiredService<IOptions<GetMyInvoicesOptions>>().Value;
					httpClient.BaseAddress = new Uri(options.BasePath);
					httpClient.DefaultRequestHeaders.Add("X-API-KEY", options.ApiKey);
				}
			)
			.AddHttpMessageHandler(sp => sp.GetRequiredService<RequestLimitDelegationHandler>());

		services.AddRefitClient<ICompanyApi>(new RefitSettings(new NewtonsoftJsonContentSerializer()))
			.ConfigureHttpClient(
				(serviceProvider, httpClient) =>
				{
					GetMyInvoicesOptions options = serviceProvider.GetRequiredService<IOptions<GetMyInvoicesOptions>>().Value;
					httpClient.BaseAddress = new Uri(options.BasePath);
					httpClient.DefaultRequestHeaders.Add("X-API-KEY", options.ApiKey);
				}
			)
			.AddHttpMessageHandler(sp => sp.GetRequiredService<RequestLimitDelegationHandler>());

		return services;
	}
}