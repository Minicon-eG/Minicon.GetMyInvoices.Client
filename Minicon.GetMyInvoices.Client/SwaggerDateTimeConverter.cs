using Newtonsoft.Json.Converters;

namespace Minicon.GetMyInvoices.Client;


	public class SwaggerDateConverter : IsoDateTimeConverter
	{
		public SwaggerDateConverter() => DateTimeFormat = "yyyy-MM-dd";
	}
