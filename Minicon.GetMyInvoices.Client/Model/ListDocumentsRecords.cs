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
///     ListDocumentsRecords
/// </summary>
[DataContract]
public sealed class ListDocumentsRecords : IEquatable<ListDocumentsRecords>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="ListDocumentsRecords" /> class.
	/// </summary>
	/// <param name="documentUid">Unique ID.</param>
	/// <param name="createdAt">Created Date.</param>
	/// <param name="companyUid">Company Unique ID.</param>
	/// <param name="companyName">Company Name.</param>
	/// <param name="documentType">Document Type.</param>
	/// <param name="documentNumber">Document Number.</param>
	/// <param name="documentDate">Document Date.</param>
	/// <param name="documentDueDate">Document Due Date.</param>
	/// <param name="netAmount">Subtotal.</param>
	/// <param name="vat">Vat.</param>
	/// <param name="taxRates">Tax Rates.</param>
	/// <param name="grossAmount">Total.</param>
	/// <param name="currency">Currency.</param>
	/// <param name="isArchived">Is Archived.</param>
	/// <param name="isLocked">Is Locked.</param>
	/// <param name="isOcrCompleted">Is OCR Completed.</param>
	/// <param name="tags">Tags.</param>
	/// <param name="note">Note.</param>
	/// <param name="source">Source.</param>
	/// <param name="filename">Filename.</param>
	/// <param name="fileSize">File Size.</param>
	/// <param name="paymentStatus">Payment Status.</param>
	/// <param name="supplierUid">Supplier UID.</param>
	/// <param name="paymentMethod">Payment Method.</param>
	/// <param name="paymentDetails">paymentDetails.</param>
	public ListDocumentsRecords(int? documentUid = default, DateTime createdAt = default, int? companyUid = default,
		string companyName = default, string documentType = default, string documentNumber = default,
		DateTime? documentDate = default, DateTime? documentDueDate = default, decimal? netAmount = default,
		decimal? vat = default, List<decimal> taxRates = default, decimal? grossAmount = default,
		string currency = default, bool? isArchived = default, bool? isLocked = default, int? isOcrCompleted = default,
		List<string> tags = default, string note = default, string source = default, string filename = default,
		string fileSize = default, string paymentStatus = default, int? supplierUid = default,
		string paymentMethod = default, ListDocumentsRecordsPaymentDetails paymentDetails = default)
	{
		DocumentUid = documentUid;
		CreatedAt = createdAt;
		CompanyUid = companyUid;
		CompanyName = companyName;
		DocumentType = documentType;
		DocumentNumber = documentNumber;
		DocumentDate = documentDate;
		DocumentDueDate = documentDueDate.ToString();
		NetAmount = netAmount;
		Vat = vat;
		TaxRates = taxRates;
		GrossAmount = grossAmount;
		Currency = currency;
		IsArchived = isArchived;
		IsLocked = isLocked;
		IsOcrCompleted = isOcrCompleted;
		Tags = tags;
		Note = note;
		Source = source;
		Filename = filename;
		FileSize = fileSize;
		PaymentStatus = paymentStatus;
		SupplierUid = supplierUid;
		PaymentMethod = paymentMethod;
		PaymentDetails = paymentDetails;
	}

	/// <summary>
	///     Unique ID
	/// </summary>
	/// <value>Unique ID</value>
	[DataMember(Name = "documentUid", EmitDefaultValue = false)]
	public int? DocumentUid { get; set; }

	/// <summary>
	///     Created Date
	/// </summary>
	/// <value>Created Date</value>
	[DataMember(Name = "createdAt", EmitDefaultValue = false)]
	[JsonConverter(typeof(SwaggerDateConverter))]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	///     Company Unique ID
	/// </summary>
	/// <value>Company Unique ID</value>
	[DataMember(Name = "companyUid", EmitDefaultValue = false)]
	public int? CompanyUid { get; set; }

	/// <summary>
	///     Company Name
	/// </summary>
	/// <value>Company Name</value>
	[DataMember(Name = "companyName", EmitDefaultValue = false)]
	public string CompanyName { get; set; }

	/// <summary>
	///     Document Type
	/// </summary>
	/// <value>Document Type</value>
	[DataMember(Name = "documentType", EmitDefaultValue = false)]
	public string DocumentType { get; set; }

	/// <summary>
	///     Document Number
	/// </summary>
	/// <value>Document Number</value>
	[DataMember(Name = "documentNumber", EmitDefaultValue = false)]
	public string DocumentNumber { get; set; }

	/// <summary>
	///     Document Date
	/// </summary>
	/// <value>Document Date</value>
	[DataMember(Name = "documentDate", EmitDefaultValue = false)]
	[JsonConverter(typeof(SwaggerDateConverter))]
	public DateTime? DocumentDate { get; set; }

	/// <summary>
	///     Document Due Date
	/// </summary>
	/// <value>Document Due Date</value>
	[DataMember(Name = "documentDueDate", EmitDefaultValue = false)]
	//[JsonConverter(typeof(SwaggerDateConverter))]
	[JsonIgnore]

	public string? DocumentDueDate { get; set; }

	/// <summary>
	///     Subtotal
	/// </summary>
	/// <value>Subtotal</value>
	[DataMember(Name = "netAmount", EmitDefaultValue = false)]
	public decimal? NetAmount { get; set; }

	/// <summary>
	///     Vat
	/// </summary>
	/// <value>Vat</value>
	[DataMember(Name = "vat", EmitDefaultValue = false)]
	public decimal? Vat { get; set; }

	/// <summary>
	///     Tax Rates
	/// </summary>
	/// <value>Tax Rates</value>
	[DataMember(Name = "taxRates", EmitDefaultValue = false)]
	public List<decimal> TaxRates { get; set; }

	/// <summary>
	///     Total
	/// </summary>
	/// <value>Total</value>
	[DataMember(Name = "grossAmount", EmitDefaultValue = false)]
	public decimal? GrossAmount { get; set; }

	/// <summary>
	///     Currency
	/// </summary>
	/// <value>Currency</value>
	[DataMember(Name = "currency", EmitDefaultValue = false)]
	public string Currency { get; set; }

	/// <summary>
	///     Is Archived
	/// </summary>
	/// <value>Is Archived</value>
	[DataMember(Name = "isArchived", EmitDefaultValue = false)]
	public bool? IsArchived { get; set; }

	/// <summary>
	///     Is Locked
	/// </summary>
	/// <value>Is Locked</value>
	[DataMember(Name = "isLocked", EmitDefaultValue = false)]
	public bool? IsLocked { get; set; }

	/// <summary>
	///     Is OCR Completed
	/// </summary>
	/// <value>Is OCR Completed</value>
	[DataMember(Name = "isOcrCompleted", EmitDefaultValue = false)]
	public int? IsOcrCompleted { get; set; }

	/// <summary>
	///     Tags
	/// </summary>
	/// <value>Tags</value>
	[DataMember(Name = "tags", EmitDefaultValue = false)]
	public List<string> Tags { get; set; }

	/// <summary>
	///     Note
	/// </summary>
	/// <value>Note</value>
	[DataMember(Name = "note", EmitDefaultValue = false)]
	public string Note { get; set; }

	/// <summary>
	///     Source
	/// </summary>
	/// <value>Source</value>
	[DataMember(Name = "source", EmitDefaultValue = false)]
	public string Source { get; set; }

	/// <summary>
	///     Filename
	/// </summary>
	/// <value>Filename</value>
	[DataMember(Name = "filename", EmitDefaultValue = false)]
	public string Filename { get; set; }

	/// <summary>
	///     File Size
	/// </summary>
	/// <value>File Size</value>
	[DataMember(Name = "fileSize", EmitDefaultValue = false)]
	public string FileSize { get; set; }

	/// <summary>
	///     Payment Status
	/// </summary>
	/// <value>Payment Status</value>
	[DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
	public string PaymentStatus { get; set; }

	/// <summary>
	///     Supplier UID
	/// </summary>
	/// <value>Supplier UID</value>
	[DataMember(Name = "supplierUid", EmitDefaultValue = false)]
	public int? SupplierUid { get; set; }

	/// <summary>
	///     Payment Method
	/// </summary>
	/// <value>Payment Method</value>
	[DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
	public string PaymentMethod { get; set; }

	/// <summary>
	///     Gets or Sets PaymentDetails
	/// </summary>
	[DataMember(Name = "paymentDetails", EmitDefaultValue = false)]
	public ListDocumentsRecordsPaymentDetails PaymentDetails { get; set; }

	/// <summary>
	///     Gets or Sets SourceUser
	/// </summary>
	[DataMember(Name = "sourceUser", EmitDefaultValue = false)]
	public string SourceUser { get; set; }

	/// <summary>
	///     Gets or Sets Attachments
	/// </summary>
	[DataMember(Name = "attachments", EmitDefaultValue = false)]
	public int? Attachments { get; set; }

	/// <summary>
	///     Returns true if ListDocumentsRecords instances are equal
	/// </summary>
	/// <param name="input">Instance of ListDocumentsRecords to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ListDocumentsRecords input)
	{
		if (input == null)
		{
			return false;
		}

		return
			(
				DocumentUid == input.DocumentUid ||
				(DocumentUid != null &&
				 DocumentUid.Equals(input.DocumentUid))
			) &&
			(
				CreatedAt == input.CreatedAt ||
				(CreatedAt != null &&
				 CreatedAt.Equals(input.CreatedAt))
			) &&
			(
				CompanyUid == input.CompanyUid ||
				(CompanyUid != null &&
				 CompanyUid.Equals(input.CompanyUid))
			) &&
			(
				CompanyName == input.CompanyName ||
				(CompanyName != null &&
				 CompanyName.Equals(input.CompanyName))
			) &&
			(
				DocumentType == input.DocumentType ||
				(DocumentType != null &&
				 DocumentType.Equals(input.DocumentType))
			) &&
			(
				DocumentNumber == input.DocumentNumber ||
				(DocumentNumber != null &&
				 DocumentNumber.Equals(input.DocumentNumber))
			) &&
			(
				DocumentDate == input.DocumentDate ||
				(DocumentDate != null &&
				 DocumentDate.Equals(input.DocumentDate))
			) &&
			(
				DocumentDueDate == input.DocumentDueDate ||
				(DocumentDueDate != null &&
				 DocumentDueDate.Equals(input.DocumentDueDate))
			) &&
			(
				NetAmount == input.NetAmount ||
				(NetAmount != null &&
				 NetAmount.Equals(input.NetAmount))
			) &&
			(
				Vat == input.Vat ||
				(Vat != null &&
				 Vat.Equals(input.Vat))
			) &&
			(
				TaxRates == input.TaxRates ||
				(TaxRates != null &&
				 input.TaxRates != null &&
				 TaxRates.SequenceEqual(input.TaxRates))
			) &&
			(
				GrossAmount == input.GrossAmount ||
				(GrossAmount != null &&
				 GrossAmount.Equals(input.GrossAmount))
			) &&
			(
				Currency == input.Currency ||
				(Currency != null &&
				 Currency.Equals(input.Currency))
			) &&
			(
				IsArchived == input.IsArchived ||
				(IsArchived != null &&
				 IsArchived.Equals(input.IsArchived))
			) &&
			(
				IsLocked == input.IsLocked ||
				(IsLocked != null &&
				 IsLocked.Equals(input.IsLocked))
			) &&
			(
				IsOcrCompleted == input.IsOcrCompleted ||
				(IsOcrCompleted != null &&
				 IsOcrCompleted.Equals(input.IsOcrCompleted))
			) &&
			(
				Tags == input.Tags ||
				(Tags != null &&
				 input.Tags != null &&
				 Tags.SequenceEqual(input.Tags))
			) &&
			(
				Note == input.Note ||
				(Note != null &&
				 Note.Equals(input.Note))
			) &&
			(
				Source == input.Source ||
				(Source != null &&
				 Source.Equals(input.Source))
			) &&
			(
				Filename == input.Filename ||
				(Filename != null &&
				 Filename.Equals(input.Filename))
			) &&
			(
				FileSize == input.FileSize ||
				(FileSize != null &&
				 FileSize.Equals(input.FileSize))
			) &&
			(
				PaymentStatus == input.PaymentStatus ||
				(PaymentStatus != null &&
				 PaymentStatus.Equals(input.PaymentStatus))
			) &&
			(
				SupplierUid == input.SupplierUid ||
				(SupplierUid != null &&
				 SupplierUid.Equals(input.SupplierUid))
			) &&
			(
				PaymentMethod == input.PaymentMethod ||
				(PaymentMethod != null &&
				 PaymentMethod.Equals(input.PaymentMethod))
			) &&
			(
				PaymentDetails == input.PaymentDetails ||
				(PaymentDetails != null &&
				 PaymentDetails.Equals(input.PaymentDetails))
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ListDocumentsRecords {\n");
		sb.Append("  DocumentUid: ").Append(DocumentUid).Append("\n");
		sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
		sb.Append("  CompanyUid: ").Append(CompanyUid).Append("\n");
		sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
		sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
		sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
		sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
		sb.Append("  DocumentDueDate: ").Append(DocumentDueDate).Append("\n");
		sb.Append("  NetAmount: ").Append(NetAmount).Append("\n");
		sb.Append("  Vat: ").Append(Vat).Append("\n");
		sb.Append("  TaxRates: ").Append(TaxRates).Append("\n");
		sb.Append("  GrossAmount: ").Append(GrossAmount).Append("\n");
		sb.Append("  Currency: ").Append(Currency).Append("\n");
		sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
		sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
		sb.Append("  IsOcrCompleted: ").Append(IsOcrCompleted).Append("\n");
		sb.Append("  Tags: ").Append(Tags).Append("\n");
		sb.Append("  Note: ").Append(Note).Append("\n");
		sb.Append("  Source: ").Append(Source).Append("\n");
		sb.Append("  Filename: ").Append(Filename).Append("\n");
		sb.Append("  FileSize: ").Append(FileSize).Append("\n");
		sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
		sb.Append("  SupplierUid: ").Append(SupplierUid).Append("\n");
		sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
		sb.Append("  PaymentDetails: ").Append(PaymentDetails).Append("\n");
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
		return Equals(input as ListDocumentsRecords);
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

			if (CreatedAt != null)
			{
				hashCode = hashCode * 59 + CreatedAt.GetHashCode();
			}

			if (CompanyUid != null)
			{
				hashCode = hashCode * 59 + CompanyUid.GetHashCode();
			}

			if (CompanyName != null)
			{
				hashCode = hashCode * 59 + CompanyName.GetHashCode();
			}

			if (DocumentType != null)
			{
				hashCode = hashCode * 59 + DocumentType.GetHashCode();
			}

			if (DocumentNumber != null)
			{
				hashCode = hashCode * 59 + DocumentNumber.GetHashCode();
			}

			if (DocumentDate != null)
			{
				hashCode = hashCode * 59 + DocumentDate.GetHashCode();
			}

			if (DocumentDueDate != null)
			{
				hashCode = hashCode * 59 + DocumentDueDate.GetHashCode();
			}

			if (NetAmount != null)
			{
				hashCode = hashCode * 59 + NetAmount.GetHashCode();
			}

			if (Vat != null)
			{
				hashCode = hashCode * 59 + Vat.GetHashCode();
			}

			if (TaxRates != null)
			{
				hashCode = hashCode * 59 + TaxRates.GetHashCode();
			}

			if (GrossAmount != null)
			{
				hashCode = hashCode * 59 + GrossAmount.GetHashCode();
			}

			if (Currency != null)
			{
				hashCode = hashCode * 59 + Currency.GetHashCode();
			}

			if (IsArchived != null)
			{
				hashCode = hashCode * 59 + IsArchived.GetHashCode();
			}

			if (IsLocked != null)
			{
				hashCode = hashCode * 59 + IsLocked.GetHashCode();
			}

			if (IsOcrCompleted != null)
			{
				hashCode = hashCode * 59 + IsOcrCompleted.GetHashCode();
			}

			if (Tags != null)
			{
				hashCode = hashCode * 59 + Tags.GetHashCode();
			}

			if (Note != null)
			{
				hashCode = hashCode * 59 + Note.GetHashCode();
			}

			if (Source != null)
			{
				hashCode = hashCode * 59 + Source.GetHashCode();
			}

			if (Filename != null)
			{
				hashCode = hashCode * 59 + Filename.GetHashCode();
			}

			if (FileSize != null)
			{
				hashCode = hashCode * 59 + FileSize.GetHashCode();
			}

			if (PaymentStatus != null)
			{
				hashCode = hashCode * 59 + PaymentStatus.GetHashCode();
			}

			if (SupplierUid != null)
			{
				hashCode = hashCode * 59 + SupplierUid.GetHashCode();
			}

			if (PaymentMethod != null)
			{
				hashCode = hashCode * 59 + PaymentMethod.GetHashCode();
			}

			if (PaymentDetails != null)
			{
				hashCode = hashCode * 59 + PaymentDetails.GetHashCode();
			}

			return hashCode;
		}
	}
}
