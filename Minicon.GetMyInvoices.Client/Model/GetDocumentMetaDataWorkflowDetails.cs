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
///     GetDocumentMetaDataWorkflowDetails
/// </summary>
[DataContract]
public sealed class GetDocumentMetaDataWorkflowDetails : IEquatable<GetDocumentMetaDataWorkflowDetails>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="GetDocumentMetaDataWorkflowDetails" /> class.
	/// </summary>
	/// <param name="currentWorkflow">currentWorkflow.</param>
	/// <param name="currentWorkflowStep">currentWorkflowStep.</param>
	/// <param name="isCompleted">Completed.</param>
	public GetDocumentMetaDataWorkflowDetails(
		GetDocumentMetaDataWorkflowDetailsCurrentWorkflow currentWorkflow = default,
		GetDocumentMetaDataWorkflowDetailsCurrentWorkflowStep currentWorkflowStep = default,
		bool? isCompleted = default)
	{
		CurrentWorkflow = currentWorkflow;
		CurrentWorkflowStep = currentWorkflowStep;
		IsCompleted = isCompleted;
	}

	/// <summary>
	///     Gets or Sets CurrentWorkflow
	/// </summary>
	[DataMember(Name = "currentWorkflow", EmitDefaultValue = false)]
	public GetDocumentMetaDataWorkflowDetailsCurrentWorkflow CurrentWorkflow { get; set; }

	/// <summary>
	///     Gets or Sets CurrentWorkflowStep
	/// </summary>
	[DataMember(Name = "currentWorkflowStep", EmitDefaultValue = false)]
	public GetDocumentMetaDataWorkflowDetailsCurrentWorkflowStep CurrentWorkflowStep { get; set; }

	/// <summary>
	///     Completed
	/// </summary>
	/// <value>Completed</value>
	[DataMember(Name = "isCompleted", EmitDefaultValue = false)]
	public bool? IsCompleted { get; set; }

	/// <summary>
	///     Returns true if GetDocumentMetaDataWorkflowDetails instances are equal
	/// </summary>
	/// <param name="input">Instance of GetDocumentMetaDataWorkflowDetails to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(GetDocumentMetaDataWorkflowDetails input)
	{
		if (input == null)
		{
			return false;
		}

		return
			(
				CurrentWorkflow == input.CurrentWorkflow ||
				(CurrentWorkflow != null &&
				 CurrentWorkflow.Equals(input.CurrentWorkflow))
			) &&
			(
				CurrentWorkflowStep == input.CurrentWorkflowStep ||
				(CurrentWorkflowStep != null &&
				 CurrentWorkflowStep.Equals(input.CurrentWorkflowStep))
			) &&
			(
				IsCompleted == input.IsCompleted ||
				(IsCompleted != null &&
				 IsCompleted.Equals(input.IsCompleted))
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class GetDocumentMetaDataWorkflowDetails {\n");
		sb.Append("  CurrentWorkflow: ").Append(CurrentWorkflow).Append("\n");
		sb.Append("  CurrentWorkflowStep: ").Append(CurrentWorkflowStep).Append("\n");
		sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
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
		return Equals(input as GetDocumentMetaDataWorkflowDetails);
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
			if (CurrentWorkflow != null)
			{
				hashCode = hashCode * 59 + CurrentWorkflow.GetHashCode();
			}

			if (CurrentWorkflowStep != null)
			{
				hashCode = hashCode * 59 + CurrentWorkflowStep.GetHashCode();
			}

			if (IsCompleted != null)
			{
				hashCode = hashCode * 59 + IsCompleted.GetHashCode();
			}

			return hashCode;
		}
	}
}