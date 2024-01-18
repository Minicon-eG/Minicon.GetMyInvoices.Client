using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Minicon.GetMyInvoices.Client.Api;
using Minicon.GetMyInvoices.Core;
using Refit;

namespace Minicon.GetMyInvoices.Client.Tests;

public class RequestLimiterTests
{
	[Fact]
	public async Task Start120Request_RequestLimitShouldBeReached()
	{
		var services = new ServiceCollection()
			.AddLogging(e => e.AddConsole())
			.AddSingleton(
				Options.Create(
					new GetMyInvoicesOptions
					{
						BasePath = "https://api.getmyinvoices.com/accounts/v3",
						ApiKey = "xxxxxxxxxxxxxxxxx"
					}
				)
			)
			.AddSingleton<IRequestLimiter, RequestLimiter>()
			.Decorate<IRequestLimiter, DebugRequestLimiter>()
			.AddSingleton<IDateTimeProvider, DateTimeProvider>()
			.AddTransient<RequestLimitDelegationHandler>();

		services.AddRefitClient<IDocumentApi>()
			.ConfigureHttpClient(
				(sp, s) =>
				{
					GetMyInvoicesOptions options = sp.GetRequiredService<IOptions<GetMyInvoicesOptions>>().Value;
					s.BaseAddress = new Uri(options.BasePath);
					s.DefaultRequestHeaders.Add("X-API-KEY", options.ApiKey);
				}
			)
			.AddHttpMessageHandler(sp => sp.GetRequiredService<RequestLimitDelegationHandler>());

		var serviceProvider = services.BuildServiceProvider();
		var api = serviceProvider.GetRequiredService<IDocumentApi>();

		Enumerable.Range(0, 200).ToList().ForEach(
			_ => Task.Run(
				() => api.DocumentsAsync(
					tagFilter: new List<string> { Guid.NewGuid().ToString() }
				)
			)
		);
		await Task.Delay(100);

		var requestLimitHttpClientHandler = serviceProvider.GetRequiredService<RequestLimitDelegationHandler>();
		requestLimitHttpClientHandler.RequestLimiter.IsCurrentlyLimited().Should().BeTrue();
	}
}
