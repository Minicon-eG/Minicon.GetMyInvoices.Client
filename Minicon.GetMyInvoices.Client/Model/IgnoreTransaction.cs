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
///     IgnoreTransaction
/// </summary>
[DataContract]
public sealed class IgnoreTransaction : IEquatable<IgnoreTransaction>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="IgnoreTransaction" /> class.
	/// </summary>
	/// <param name="success">Success.</param>
	public IgnoreTransaction(bool? success = default)
	{
		Success = success;
	}

	/// <summary>
	///     Success
	/// </summary>
	/// <value>Success</value>
	[DataMember(Name = "success", EmitDefaultValue = false)]
	public bool? Success { get; set; }

	/// <summary>
	///     Returns true if IgnoreTransaction instances are equal
	/// </summary>
	/// <param name="input">Instance of IgnoreTransaction to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(IgnoreTransaction input)
	{
		if (input == null)
		{
			return false;
		}

		return
			Success == input.Success ||
			(Success != null &&
			 Success.Equals(input.Success));
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class IgnoreTransaction {\n");
		sb.Append("  Success: ").Append(Success).Append("\n");
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
		return Equals(input as IgnoreTransaction);
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

			return hashCode;
		}
	}
}
