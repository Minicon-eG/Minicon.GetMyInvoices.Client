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
///     AssignTransaction
/// </summary>
[DataContract]
public sealed class AssignTransaction : IEquatable<AssignTransaction>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="AssignTransaction" /> class.
	/// </summary>
	/// <param name="success">Success.</param>
	/// <param name="metaData">metaData.</param>
	public AssignTransaction(bool? success = default, AssignTransactionMetaData metaData = default)
	{
		Success = success;
		MetaData = metaData;
	}

	/// <summary>
	///     Success
	/// </summary>
	/// <value>Success</value>
	[DataMember(Name = "success", EmitDefaultValue = false)]
	public bool? Success { get; set; }

	/// <summary>
	///     Gets or Sets MetaData
	/// </summary>
	[DataMember(Name = "meta_data", EmitDefaultValue = false)]
	public AssignTransactionMetaData MetaData { get; set; }

	/// <summary>
	///     Returns true if AssignTransaction instances are equal
	/// </summary>
	/// <param name="input">Instance of AssignTransaction to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(AssignTransaction input)
	{
		if (input == null)
		{
			return false;
		}

		return
			(
				Success == input.Success ||
				(Success != null &&
				 Success.Equals(input.Success))
			) &&
			(
				MetaData == input.MetaData ||
				(MetaData != null &&
				 MetaData.Equals(input.MetaData))
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class AssignTransaction {\n");
		sb.Append("  Success: ").Append(Success).Append("\n");
		sb.Append("  MetaData: ").Append(MetaData).Append("\n");
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
		return Equals(input as AssignTransaction);
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
			if (Success != null)
			{
				hashCode = hashCode * 59 + Success.GetHashCode();
			}

			if (MetaData != null)
			{
				hashCode = hashCode * 59 + MetaData.GetHashCode();
			}

			return hashCode;
		}
	}
}
