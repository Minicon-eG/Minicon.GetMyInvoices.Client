using Microsoft.Extensions.Logging;

namespace Minicon.GetMyInvoices.Client;

public sealed class DebugRequestLimiter : IRequestLimiter
{
	private readonly IRequestLimiter _requestLimiter;
	private readonly ILogger<DebugRequestLimiter> _logger;
	private readonly IDateTimeProvider _dateTimeProvider;

	public DebugRequestLimiter(
		IRequestLimiter requestLimiter,
		ILogger<DebugRequestLimiter> logger,
		IDateTimeProvider dateTimeProvider
	)
	{
		_requestLimiter = requestLimiter;
		_logger = logger;
		_dateTimeProvider = dateTimeProvider;
	}

	public void Add()
	{
		_logger.LogTrace("Adding request to request limiter");
		_requestLimiter.Add();
	}

	public int Count(DateTime since)
	{
		_logger.LogTrace("Counting requests since {Since}", since);
		return _requestLimiter.Count(since);
	}

	public void Delete(DateTime before)
	{
		_logger.LogTrace("Deleting requests before {Before}", before);
		_requestLimiter.Delete(before);
	}

	public async Task LimitAsync(CancellationToken cancellationToken = default)
	{
		await LimitAsync(1, cancellationToken);
	}

	public async Task LimitAsync(int requestCount = 1, CancellationToken cancellationToken = default)
	{
		bool wasPaused = false;
		var originRequestLimiter = _requestLimiter is RequestLimiter  ? _requestLimiter as RequestLimiter : null;

		if (_requestLimiter.IsCurrentlyLimited(requestCount))
		{
			if ( originRequestLimiter is not null)
			{
				_logger.LogInformation("Currently limited to {RequestPerMinute} requests per minute",
					originRequestLimiter.RequestPerMinute);
			}

			_logger.LogInformation("Pausing requests ");
			wasPaused = true;
		}

		await _requestLimiter.LimitAsync(requestCount, cancellationToken);

		if (originRequestLimiter is not null)
		{
			_logger.LogTrace(
				"Current in Progress Requests: {InProgressRequests}",
				originRequestLimiter.Count(
					_dateTimeProvider.Now.AddSeconds(-originRequestLimiter.RequestPerMinute)
				)
			);
		}

		if (wasPaused)
		{
			_logger.LogInformation("Resuming requests");
		}
	}

	public bool IsCurrentlyLimited(int requestCount = 1)
	{
		return _requestLimiter.IsCurrentlyLimited(requestCount);
	}
}
