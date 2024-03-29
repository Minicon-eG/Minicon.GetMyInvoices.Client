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
///     AssignTransactionMetaData
/// </summary>
[DataContract]
public sealed class AssignTransactionMetaData : IEquatable<AssignTransactionMetaData>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="AssignTransactionMetaData" /> class.
	/// </summary>
	/// <param name="assignmentUid">Prim Unique ID.</param>
	public AssignTransactionMetaData(int? assignmentUid = default)
	{
		AssignmentUid = assignmentUid;
	}

	/// <summary>
	///     Prim Unique ID
	/// </summary>
	/// <value>Prim Unique ID</value>
	[DataMember(Name = "assignmentUid", EmitDefaultValue = false)]
	public int? AssignmentUid { get; set; }

	/// <summary>
	///     Returns true if AssignTransactionMetaData instances are equal
	/// </summary>
	/// <param name="input">Instance of AssignTransactionMetaData to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(AssignTransactionMetaData input)
	{
		if (input == null)
		{
			return false;
		}

		return
			AssignmentUid == input.AssignmentUid ||
			(AssignmentUid != null &&
			 AssignmentUid.Equals(input.AssignmentUid));
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class AssignTransactionMetaData {\n");
		sb.Append("  AssignmentUid: ").Append(AssignmentUid).Append("\n");
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
		return Equals(input as AssignTransactionMetaData);
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
			if (AssignmentUid != null)
			{
				hashCode = hashCode * 59 + AssignmentUid.GetHashCode();
			}

			return hashCode;
		}
	}
}
