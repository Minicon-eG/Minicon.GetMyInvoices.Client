namespace Minicon.GetMyInvoices.Core;

public sealed class RequestLimitDelegationHandler : DelegatingHandler
{
	public readonly IRequestLimiter RequestLimiter;

	public RequestLimitDelegationHandler(IRequestLimiter requestLimiter)
	{
		RequestLimiter = requestLimiter;
	}
	protected override HttpResponseMessage Send(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		RequestLimiter.LimitAsync(1, cancellationToken).Wait(cancellationToken);
		return base.Send(request, cancellationToken);
	}

	protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		await RequestLimiter.LimitAsync(1, cancellationToken);
		return await base.SendAsync(request, cancellationToken);
	}
}
