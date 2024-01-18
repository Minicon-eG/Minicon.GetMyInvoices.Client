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
///     ListPortals
/// </summary>
[DataContract]
public sealed class ListPortals : IEquatable<ListPortals>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="ListPortals" /> class.
	/// </summary>
	/// <param name="totalCount">Total Count.</param>
	/// <param name="maxAmount">Max Amount.</param>
	/// <param name="offset">Offset.</param>
	/// <param name="records">records.</param>
	public ListPortals(int? totalCount = default, int? maxAmount = default, int? offset = default,
		List<ListPortalsRecords> records = default)
	{
		TotalCount = totalCount;
		MaxAmount = maxAmount;
		Offset = offset;
		Records = records;
	}

	/// <summary>
	///     Total Count
	/// </summary>
	/// <value>Total Count</value>
	[DataMember(Name = "totalCount", EmitDefaultValue = false)]
	public int? TotalCount { get; set; }

	/// <summary>
	///     Max Amount
	/// </summary>
	/// <value>Max Amount</value>
	[DataMember(Name = "maxAmount", EmitDefaultValue = false)]
	public int? MaxAmount { get; set; }

	/// <summary>
	///     Offset
	/// </summary>
	/// <value>Offset</value>
	[DataMember(Name = "offset", EmitDefaultValue = false)]
	public int? Offset { get; set; }

	/// <summary>
	///     Gets or Sets Records
	/// </summary>
	[DataMember(Name = "records", EmitDefaultValue = false)]
	public List<ListPortalsRecords> Records { get; set; }

	/// <summary>
	///     Returns true if ListPortals instances are equal
	/// </summary>
	/// <param name="input">Instance of ListPortals to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ListPortals input)
	{
		if (input == null)
		{
			return false;
		}

		return
			(
				TotalCount == input.TotalCount ||
				(TotalCount != null &&
				 TotalCount.Equals(input.TotalCount))
			) &&
			(
				MaxAmount == input.MaxAmount ||
				(MaxAmount != null &&
				 MaxAmount.Equals(input.MaxAmount))
			) &&
			(
				Offset == input.Offset ||
				(Offset != null &&
				 Offset.Equals(input.Offset))
			) &&
			(
				Records == input.Records ||
				(Records != null &&
				 input.Records != null &&
				 Records.SequenceEqual(input.Records))
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ListPortals {\n");
		sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
		sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
		sb.Append("  Offset: ").Append(Offset).Append("\n");
		sb.Append("  Records: ").Append(Records).Append("\n");
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
		return Equals(input as ListPortals);
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
			if (TotalCount != null)
			{
				hashCode = hashCode * 59 + TotalCount.GetHashCode();
			}

			if (MaxAmount != null)
			{
				hashCode = hashCode * 59 + MaxAmount.GetHashCode();
			}

			if (Offset != null)
			{
				hashCode = hashCode * 59 + Offset.GetHashCode();
			}

			if (Records != null)
			{
				hashCode = hashCode * 59 + Records.GetHashCode();
			}

			return hashCode;
		}
	}
}
