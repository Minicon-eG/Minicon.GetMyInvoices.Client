using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Minicon.GetMyInvoices.Client.Api;
using Minicon.GetMyInvoices.Client.Extensions.DependencyInjection;
using Minicon.GetMyInvoices.Client.Model;
using Minicon.GetMyInvoices.Core;
using Newtonsoft.Json;
using Refit;
using Xunit.Abstractions;

namespace Minicon.GetMyInvoices.Client.Tests;

public class DocumentApiTests
{
	private readonly ITestOutputHelper _output;

	public DocumentApiTests(ITestOutputHelper output)
	{
		_output = output;
	}
	[Fact]
	public async Task DocumentsAsync_LoadAllPages_Works()
	{
		var services = new ServiceCollection()
			.AddGetMyInvoicesClient()
			.AddLogging(e => e.AddConsole())
			.AddSingleton(
				Options.Create(
					new GetMyInvoicesOptions
					{
						BasePath = "https://api.getmyinvoices.com/accounts/v3",
						ApiKey = "xxxxxx"
					}
				)
			);

		ServiceProvider serviceProvider = services.BuildServiceProvider();
		IDocumentApi api = serviceProvider.GetRequiredService<IDocumentApi>();

		int pageId = 1;
		while (true)
		{
			_output.WriteLine($"Page {pageId}");
			var result = await api.DocumentsAsync(pageNumber: pageId++);
			if (result.Records!.Count == 0)
			{
				break;
			}
		}
	}

}
