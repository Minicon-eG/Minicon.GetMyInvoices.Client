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
///     DocumentUidAttachmentsBody
/// </summary>
[DataContract]
public sealed class DocumentUidAttachmentsBody : IEquatable<DocumentUidAttachmentsBody>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="DocumentUidAttachmentsBody" /> class.
	/// </summary>
	/// <param name="fileName">Name of the file with extension (required).</param>
	/// <param name="fileContent">File content; base64 encoded (required).</param>
	public DocumentUidAttachmentsBody(string fileName = default, string fileContent = default)
	{
		// to ensure "fileName" is required (not null)
		if (fileName == null)
		{
			throw new InvalidDataException(
				"fileName is a required property for DocumentUidAttachmentsBody and cannot be null");
		}

		FileName = fileName;
		// to ensure "fileContent" is required (not null)
		if (fileContent == null)
		{
			throw new InvalidDataException(
				"fileContent is a required property for DocumentUidAttachmentsBody and cannot be null");
		}

		FileContent = fileContent;
	}

	/// <summary>
	///     Name of the file with extension
	/// </summary>
	/// <value>Name of the file with extension</value>
	[DataMember(Name = "fileName", EmitDefaultValue = false)]
	public string FileName { get; set; }

	/// <summary>
	///     File content; base64 encoded
	/// </summary>
	/// <value>File content; base64 encoded</value>
	[DataMember(Name = "fileContent", EmitDefaultValue = false)]
	public string FileContent { get; set; }

	/// <summary>
	///     Returns true if DocumentUidAttachmentsBody instances are equal
	/// </summary>
	/// <param name="input">Instance of DocumentUidAttachmentsBody to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(DocumentUidAttachmentsBody input)
	{
		if (input == null)
		{
			return false;
		}

		return
			(
				FileName == input.FileName ||
				(FileName != null &&
				 FileName.Equals(input.FileName))
			) &&
			(
				FileContent == input.FileContent ||
				(FileContent != null &&
				 FileContent.Equals(input.FileContent))
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DocumentUidAttachmentsBody {\n");
		sb.Append("  FileName: ").Append(FileName).Append("\n");
		sb.Append("  FileContent: ").Append(FileContent).Append("\n");
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
		return Equals(input as DocumentUidAttachmentsBody);
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
			if (FileName != null)
			{
				hashCode = hashCode * 59 + FileName.GetHashCode();
			}

			if (FileContent != null)
			{
				hashCode = hashCode * 59 + FileContent.GetHashCode();
			}

			return hashCode;
		}
	}
}