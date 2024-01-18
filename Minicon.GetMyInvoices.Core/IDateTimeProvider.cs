namespace Minicon.GetMyInvoices.Core;

public interface IDateTimeProvider
{
	DateTime Now { get; }
}
