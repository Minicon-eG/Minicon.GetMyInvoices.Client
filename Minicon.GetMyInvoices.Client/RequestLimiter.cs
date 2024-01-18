using System.Collections.Concurrent;

namespace Minicon.GetMyInvoices.Client;

public sealed class RequestLimiter : IRequestLimiter
{
	private readonly IDateTimeProvider _dateTimeProvider;
	public readonly int RequestPerMinute;
	public readonly ConcurrentBag<DateTime> Requests;

	internal RequestLimiter(IDateTimeProvider dateTimeProvider, int requestPerMinute)
	{
		_dateTimeProvider = dateTimeProvider;
		RequestPerMinute = requestPerMinute;
		Requests = new ConcurrentBag<DateTime>();
	}

	public RequestLimiter(IDateTimeProvider dateTimeProvider)
		: this(dateTimeProvider, 60)
	{
	}

	public Task LimitAsync(CancellationToken cancellationToken = default)
	{
		return LimitAsync(1, cancellationToken);
	}

	public async Task LimitAsync(int requestCount = 1, CancellationToken cancellationToken = default)
	{
		while (IsCurrentlyLimited(requestCount))
		{
			Console.WriteLine("Waiting for request limit...");
			await Task.Delay(1000, cancellationToken);
		}

		for (int i = 0; i < requestCount; i++)
		{
			Add();
		}

		// Delete old requests sometimes
		if (_dateTimeProvider.Now.Millisecond % 10 == 0)
		{
			Delete(_dateTimeProvider.Now.AddMinutes(-RequestPerMinute * 2));
		}
	}

	public bool IsCurrentlyLimited(int requestCount = 1)
	{
		return Count(_dateTimeProvider.Now.AddSeconds(-RequestPerMinute+1)) + requestCount >= RequestPerMinute;
	}

	public void Add()
	{
		Requests.Add(_dateTimeProvider.Now);
	}

	public int Count(DateTime since)
	{
		return Requests.Count(t => t >= since);
	}

	public void Delete(DateTime before)
	{
		Requests.Where(t => t < before).ToList().ForEach(t => Requests.TryTake(out _));
	}
}
