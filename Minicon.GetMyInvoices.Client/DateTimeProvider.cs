namespace Minicon.GetMyInvoices.Client;

public sealed class DateTimeProvider : IDateTimeProvider
{
	public DateTime Now => DateTime.Now;
}
