/* 
 * GetMyInvoices API Documentation
 *
 * Documentation for GetMyInvoices API endpoints.
 *
 * OpenAPI spec version: v3
 * Contact: support@getmyinvoices.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Minicon.GetMyInvoices.Client.Model;

/// <summary>
///     GetCountriesItemTranslations
/// </summary>
[DataContract]
public sealed class GetCountriesItemTranslations : IEquatable<GetCountriesItemTranslations>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="GetCountriesItemTranslations" /> class.
	/// </summary>
	/// <param name="enUs">en_us.</param>
	/// <param name="deDe">de_de.</param>
	public GetCountriesItemTranslations(string enUs = default, string deDe = default)
	{
		EnUs = enUs;
		DeDe = deDe;
	}

	/// <summary>
	///     en_us
	/// </summary>
	/// <value>en_us</value>
	[DataMember(Name = "en_us", EmitDefaultValue = false)]
	public string EnUs { get; set; }

	/// <summary>
	///     de_de
	/// </summary>
	/// <value>de_de</value>
	[DataMember(Name = "de_de", EmitDefaultValue = false)]
	public string DeDe { get; set; }

	/// <summary>
	///     Returns true if GetCountriesItemTranslations instances are equal
	/// </summary>
	/// <param name="input">Instance of GetCountriesItemTranslations to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(GetCountriesItemTranslations input)
	{
		if (input == null)
		{
			return false;
		}

		return
			(
				EnUs == input.EnUs ||
				(EnUs != null &&
				 EnUs.Equals(input.EnUs))
			) &&
			(
				DeDe == input.DeDe ||
				(DeDe != null &&
				 DeDe.Equals(input.DeDe))
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetCountriesItemTranslations {\n");
		sb.Append("  EnUs: ").Append(EnUs).Append("\n");
		sb.Append("  DeDe: ").Append(DeDe).Append("\n");
		sb.Append("}\n");
		return sb.ToString();
	}

	/// <summary>
	///     Returns the JSON string presentation of the object
	/// </summary>
	/// <returns>JSON string presentation of the object</returns>
	public string ToJson()
	{
		return JsonConvert.SerializeObject(this, Formatting.Indented);
	}

	/// <summary>
	///     Returns true if objects are equal
	/// </summary>
	/// <param name="input">Object to be compared</param>
	/// <returns>Boolean</returns>
	public override bool Equals(object input)
	{
		return Equals(input as GetCountriesItemTranslations);
	}

	/// <summary>
	///     Gets the hash code
	/// </summary>
	/// <returns>Hash code</returns>
	public override int GetHashCode()
	{
		unchecked // Overflow is fine, just wrap
		{
			int hashCode = 41;
			if (EnUs != null)
			{
				hashCode = hashCode * 59 + EnUs.GetHashCode();
			}

			if (DeDe != null)
			{
				hashCode = hashCode * 59 + DeDe.GetHashCode();
			}

			return hashCode;
		}
	}
}
