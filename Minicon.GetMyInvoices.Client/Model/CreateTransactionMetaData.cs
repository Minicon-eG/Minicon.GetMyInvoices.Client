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
///     CreateTransactionMetaData
/// </summary>
[DataContract]
public sealed class CreateTransactionMetaData : IEquatable<CreateTransactionMetaData>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="CreateTransactionMetaData" /> class.
	/// </summary>
	/// <param name="transactionUid">Prim Unique ID.</param>
	public CreateTransactionMetaData(int? transactionUid = default)
	{
		TransactionUid = transactionUid;
	}

	/// <summary>
	///     Prim Unique ID
	/// </summary>
	/// <value>Prim Unique ID</value>
	[DataMember(Name = "transactionUid", EmitDefaultValue = false)]
	public int? TransactionUid { get; set; }

	/// <summary>
	///     Returns true if CreateTransactionMetaData instances are equal
	/// </summary>
	/// <param name="input">Instance of CreateTransactionMetaData to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(CreateTransactionMetaData input)
	{
		if (input == null)
		{
			return false;
		}

		return
			TransactionUid == input.TransactionUid ||
			(TransactionUid != null &&
			 TransactionUid.Equals(input.TransactionUid));
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class CreateTransactionMetaData {\n");
		sb.Append("  TransactionUid: ").Append(TransactionUid).Append("\n");
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
		return Equals(input as CreateTransactionMetaData);
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
			if (TransactionUid != null)
			{
				hashCode = hashCode * 59 + TransactionUid.GetHashCode();
			}

			return hashCode;
		}
	}
}