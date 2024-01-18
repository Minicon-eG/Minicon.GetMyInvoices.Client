namespace Minicon.GetMyInvoices.Core;

public sealed class DateTimeProvider : IDateTimeProvider
{
	public DateTime Now => DateTime.Now;
}
