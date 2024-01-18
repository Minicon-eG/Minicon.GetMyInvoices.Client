namespace Minicon.GetMyInvoices.Core;

public interface IRequestLimiter
{
	Task LimitAsync(CancellationToken cancellationToken = default);
	Task LimitAsync(int requestCount = 1, CancellationToken cancellationToken = default);
	bool IsCurrentlyLimited(int requestCount = 1);
	void Add();
	int Count(DateTime since);
	void Delete(DateTime before);
}
