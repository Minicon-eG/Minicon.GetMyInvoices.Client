namespace Minicon.GetMyInvoices.Core;

public sealed class RequestSlowingDelegationHandler : DelegatingHandler
{
	protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		Thread.Sleep(100);
		return base.Send(request, cancellationToken);
	}

	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		Thread.Sleep(100);
		return await base.SendAsync(request, cancellationToken);
	}
}
