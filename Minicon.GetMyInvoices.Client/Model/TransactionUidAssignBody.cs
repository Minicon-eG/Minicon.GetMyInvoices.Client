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
///     TransactionUidAssignBody
/// </summary>
[DataContract]
public sealed class TransactionUidAssignBody : IEquatable<TransactionUidAssignBody>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="TransactionUidAssignBody" /> class.
	/// </summary>
	/// <param name="documentUid">PRIM_UID of the document. (required).</param>
	public TransactionUidAssignBody(int? documentUid = default)
	{
		// to ensure "documentUid" is required (not null)
		if (documentUid == null)
		{
			throw new InvalidDataException(
				"documentUid is a required property for TransactionUidAssignBody and cannot be null");
		}

		DocumentUid = documentUid;
	}

	/// <summary>
	///     PRIM_UID of the document.
	/// </summary>
	/// <value>PRIM_UID of the document.</value>
	[DataMember(Name = "documentUid", EmitDefaultValue = false)]
	public int? DocumentUid { get; set; }

	/// <summary>
	///     Returns true if TransactionUidAssignBody instances are equal
	/// </summary>
	/// <param name="input">Instance of TransactionUidAssignBody to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(TransactionUidAssignBody input)
	{
		if (input == null)
		{
			return false;
		}

		return
			DocumentUid == input.DocumentUid ||
			(DocumentUid != null &&
			 DocumentUid.Equals(input.DocumentUid));
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class TransactionUidAssignBody {\n");
		sb.Append("  DocumentUid: ").Append(DocumentUid).Append("\n");
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
		return Equals(input as TransactionUidAssignBody);
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
			if (DocumentUid != null)
			{
				hashCode = hashCode * 59 + DocumentUid.GetHashCode();
			}

			return hashCode;
		}
	}
}