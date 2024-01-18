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
///     GetTags
/// </summary>
[DataContract]
public sealed class GetTags : IEquatable<GetTags>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="GetTags" /> class.
	/// </summary>
	/// <param name="success">Success.</param>
	/// <param name="data">Tags.</param>
	public GetTags(bool? success = default, List<string> data = default)
	{
		Success = success;
		Data = data;
	}

	/// <summary>
	///     Success
	/// </summary>
	/// <value>Success</value>
	[DataMember(Name = "success", EmitDefaultValue = false)]
	public bool? Success { get; set; }

	/// <summary>
	///     Tags
	/// </summary>
	/// <value>Tags</value>
	[DataMember(Name = "data", EmitDefaultValue = false)]
	public List<string> Data { get; set; }

	/// <summary>
	///     Returns true if GetTags instances are equal
	/// </summary>
	/// <param name="input">Instance of GetTags to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(GetTags input)
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
				Data == input.Data ||
				(Data != null &&
				 input.Data != null &&
				 Data.SequenceEqual(input.Data))
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetTags {\n");
		sb.Append("  Success: ").Append(Success).Append("\n");
		sb.Append("  Data: ").Append(Data).Append("\n");
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
		return Equals(input as GetTags);
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

			if (Data != null)
			{
				hashCode = hashCode * 59 + Data.GetHashCode();
			}

			return hashCode;
		}
	}
}
