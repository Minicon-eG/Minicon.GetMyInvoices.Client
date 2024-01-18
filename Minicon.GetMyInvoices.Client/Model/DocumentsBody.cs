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
///     DocumentsBody
/// </summary>
[DataContract]
public sealed class DocumentsBody : IEquatable<DocumentsBody>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="DocumentsBody" /> class.
	/// </summary>
	/// <param name="fileName">Name of the file with extension (required).</param>
	/// <param name="fileContent">File content; base64 encoded.</param>
	/// <param name="companyId">
	///     ID of company from &lt;a href&#x3D;&#x27;#companies&#x27; target&#x3D;&#x27;_blank&#x27;&gt;
	///     /companies&lt;/a&gt;.
	/// </param>
	/// <param name="documentType">
	///     Document type. Possible values: INCOMING_INVOICE / RECEIPT / PAYMENT_RECEIPT /
	///     EXPENSE_REIMBURSEMENT / SALES_INVOICE / CREDIT_NOTE / STATEMENT / DELIVERY_NOTE / ORDER_CONFIRMATION / PAYROLL /
	///     COMPANY_REGISTRATION_DOCUMENT / MISC / TRAVEL_EXPENSES / REMINDER (required).
	/// </param>
	/// <param name="documentNumber">Document number.</param>
	/// <param name="documentDate">Document date (format: Y-m-d).</param>
	/// <param name="documentDueDate">Document due date (format: Y-m-d).</param>
	/// <param name="paymentMethod">
	///     Document Payment Method. Possible values: bank_transfer, cash, check, direct_debit, credit,
	///     cc, paypal, online_payment, amazon_pay, apple_pay, google_pay, external_receivables_management, cashbox,
	///     offsetting, other.
	/// </param>
	/// <param name="paymentStatus">Document Payment Status. Possible values: Unknown, Paid, Partially, Not paid.</param>
	/// <param name="paidAt">Paid at date (format: Y-m-d), When payment_status &#x3D; &#x27;Paid&#x27;.</param>
	/// <param name="netAmount">Net amount.</param>
	/// <param name="grossAmount">Gross amount.</param>
	/// <param name="currency">Currency.</param>
	/// <param name="vat">
	///     VAT percentage. Array can be used for multiple tax rates. &lt;br/&gt; Note: It will be deprecated
	///     soon. Either vat or taxRates can be used.
	/// </param>
	/// <param name="taxRates">Tax Rates (Array).</param>
	/// <param name="cashDiscountDate">Cash Discount date (format: Y-m-d).</param>
	/// <param name="cashDiscountValue">Cash Discount value.</param>
	/// <param name="tags">Tags (Array).</param>
	/// <param name="note">Note.</param>
	/// <param name="lineItems">lineItems.</param>
	/// <param name="runOcr">Use integrated OCR to fill optional params automatically.</param>
	public DocumentsBody(string fileName = default, string fileContent = default, int? companyId = default,
		string documentType = default, string documentNumber = default, string documentDate = default,
		string documentDueDate = default, string paymentMethod = default, string paymentStatus = default,
		string paidAt = default, string netAmount = default, string grossAmount = default, string currency = default,
		List<string> vat = default, List<int?> taxRates = default, string cashDiscountDate = default,
		string cashDiscountValue = default, List<string> tags = default, string note = default,
		LineItems lineItems = default, bool? runOcr = default)
	{
		// to ensure "fileName" is required (not null)
		if (fileName == null)
		{
			throw new InvalidDataException("fileName is a required property for DocumentsBody and cannot be null");
		}

		FileName = fileName;
		// to ensure "documentType" is required (not null)
		if (documentType == null)
		{
			throw new InvalidDataException("documentType is a required property for DocumentsBody and cannot be null");
		}

		DocumentType = documentType;
		FileContent = fileContent;
		CompanyId = companyId;
		DocumentNumber = documentNumber;
		DocumentDate = documentDate;
		DocumentDueDate = documentDueDate;
		PaymentMethod = paymentMethod;
		PaymentStatus = paymentStatus;
		PaidAt = paidAt;
		NetAmount = netAmount;
		GrossAmount = grossAmount;
		Currency = currency;
		Vat = vat;
		TaxRates = taxRates;
		CashDiscountDate = cashDiscountDate;
		CashDiscountValue = cashDiscountValue;
		Tags = tags;
		Note = note;
		LineItems = lineItems;
		RunOcr = runOcr;
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
	///     ID of company from &lt;a href&#x3D;&#x27;#companies&#x27; target&#x3D;&#x27;_blank&#x27;&gt;/companies&lt;/a&gt;
	/// </summary>
	/// <value>ID of company from &lt;a href&#x3D;&#x27;#companies&#x27; target&#x3D;&#x27;_blank&#x27;&gt;/companies&lt;/a&gt;</value>
	[DataMember(Name = "companyId", EmitDefaultValue = false)]
	public int? CompanyId { get; set; }

	/// <summary>
	///     Document type. Possible values: INCOMING_INVOICE / RECEIPT / PAYMENT_RECEIPT / EXPENSE_REIMBURSEMENT /
	///     SALES_INVOICE / CREDIT_NOTE / STATEMENT / DELIVERY_NOTE / ORDER_CONFIRMATION / PAYROLL /
	///     COMPANY_REGISTRATION_DOCUMENT / MISC / TRAVEL_EXPENSES / REMINDER
	/// </summary>
	/// <value>
	///     Document type. Possible values: INCOMING_INVOICE / RECEIPT / PAYMENT_RECEIPT / EXPENSE_REIMBURSEMENT /
	///     SALES_INVOICE / CREDIT_NOTE / STATEMENT / DELIVERY_NOTE / ORDER_CONFIRMATION / PAYROLL /
	///     COMPANY_REGISTRATION_DOCUMENT / MISC / TRAVEL_EXPENSES / REMINDER
	/// </value>
	[DataMember(Name = "documentType", EmitDefaultValue = false)]
	public string DocumentType { get; set; }

	/// <summary>
	///     Document number
	/// </summary>
	/// <value>Document number</value>
	[DataMember(Name = "documentNumber", EmitDefaultValue = false)]
	public string DocumentNumber { get; set; }

	/// <summary>
	///     Document date (format: Y-m-d)
	/// </summary>
	/// <value>Document date (format: Y-m-d)</value>
	[DataMember(Name = "documentDate", EmitDefaultValue = false)]
	public string DocumentDate { get; set; }

	/// <summary>
	///     Document due date (format: Y-m-d)
	/// </summary>
	/// <value>Document due date (format: Y-m-d)</value>
	[DataMember(Name = "documentDueDate", EmitDefaultValue = false)]
	public string DocumentDueDate { get; set; }

	/// <summary>
	///     Document Payment Method. Possible values: bank_transfer, cash, check, direct_debit, credit, cc, paypal,
	///     online_payment, amazon_pay, apple_pay, google_pay, external_receivables_management, cashbox, offsetting, other
	/// </summary>
	/// <value>
	///     Document Payment Method. Possible values: bank_transfer, cash, check, direct_debit, credit, cc, paypal,
	///     online_payment, amazon_pay, apple_pay, google_pay, external_receivables_management, cashbox, offsetting, other
	/// </value>
	[DataMember(Name = "paymentMethod", EmitDefaultValue = false)]
	public string PaymentMethod { get; set; }

	/// <summary>
	///     Document Payment Status. Possible values: Unknown, Paid, Partially, Not paid
	/// </summary>
	/// <value>Document Payment Status. Possible values: Unknown, Paid, Partially, Not paid</value>
	[DataMember(Name = "paymentStatus", EmitDefaultValue = false)]
	public string PaymentStatus { get; set; }

	/// <summary>
	///     Paid at date (format: Y-m-d), When payment_status &#x3D; &#x27;Paid&#x27;
	/// </summary>
	/// <value>Paid at date (format: Y-m-d), When payment_status &#x3D; &#x27;Paid&#x27;</value>
	[DataMember(Name = "paidAt", EmitDefaultValue = false)]
	public string PaidAt { get; set; }

	/// <summary>
	///     Net amount
	/// </summary>
	/// <value>Net amount</value>
	[DataMember(Name = "netAmount", EmitDefaultValue = false)]
	public string NetAmount { get; set; }

	/// <summary>
	///     Gross amount
	/// </summary>
	/// <value>Gross amount</value>
	[DataMember(Name = "grossAmount", EmitDefaultValue = false)]
	public string GrossAmount { get; set; }

	/// <summary>
	///     Currency
	/// </summary>
	/// <value>Currency</value>
	[DataMember(Name = "currency", EmitDefaultValue = false)]
	public string Currency { get; set; }

	/// <summary>
	///     VAT percentage. Array can be used for multiple tax rates. &lt;br/&gt; Note: It will be deprecated soon. Either vat
	///     or taxRates can be used
	/// </summary>
	/// <value>
	///     VAT percentage. Array can be used for multiple tax rates. &lt;br/&gt; Note: It will be deprecated soon. Either
	///     vat or taxRates can be used
	/// </value>
	[DataMember(Name = "vat", EmitDefaultValue = false)]
	public List<string> Vat { get; set; }

	/// <summary>
	///     Tax Rates (Array)
	/// </summary>
	/// <value>Tax Rates (Array)</value>
	[DataMember(Name = "taxRates", EmitDefaultValue = false)]
	public List<int?> TaxRates { get; set; }

	/// <summary>
	///     Cash Discount date (format: Y-m-d)
	/// </summary>
	/// <value>Cash Discount date (format: Y-m-d)</value>
	[DataMember(Name = "cashDiscountDate", EmitDefaultValue = false)]
	public string CashDiscountDate { get; set; }

	/// <summary>
	///     Cash Discount value
	/// </summary>
	/// <value>Cash Discount value</value>
	[DataMember(Name = "cashDiscountValue", EmitDefaultValue = false)]
	public string CashDiscountValue { get; set; }

	/// <summary>
	///     Tags (Array)
	/// </summary>
	/// <value>Tags (Array)</value>
	[DataMember(Name = "tags", EmitDefaultValue = false)]
	public List<string> Tags { get; set; }

	/// <summary>
	///     Note
	/// </summary>
	/// <value>Note</value>
	[DataMember(Name = "note", EmitDefaultValue = false)]
	public string Note { get; set; }

	/// <summary>
	///     Gets or Sets LineItems
	/// </summary>
	[DataMember(Name = "lineItems", EmitDefaultValue = false)]
	public LineItems LineItems { get; set; }

	/// <summary>
	///     Use integrated OCR to fill optional params automatically
	/// </summary>
	/// <value>Use integrated OCR to fill optional params automatically</value>
	[DataMember(Name = "runOCR", EmitDefaultValue = false)]
	public bool? RunOcr { get; set; }

	/// <summary>
	///     Returns true if DocumentsBody instances are equal
	/// </summary>
	/// <param name="input">Instance of DocumentsBody to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(DocumentsBody input)
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
			) &&
			(
				CompanyId == input.CompanyId ||
				(CompanyId != null &&
				 CompanyId.Equals(input.CompanyId))
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
				PaymentMethod == input.PaymentMethod ||
				(PaymentMethod != null &&
				 PaymentMethod.Equals(input.PaymentMethod))
			) &&
			(
				PaymentStatus == input.PaymentStatus ||
				(PaymentStatus != null &&
				 PaymentStatus.Equals(input.PaymentStatus))
			) &&
			(
				PaidAt == input.PaidAt ||
				(PaidAt != null &&
				 PaidAt.Equals(input.PaidAt))
			) &&
			(
				NetAmount == input.NetAmount ||
				(NetAmount != null &&
				 NetAmount.Equals(input.NetAmount))
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
				Vat == input.Vat ||
				(Vat != null &&
				 input.Vat != null &&
				 Vat.SequenceEqual(input.Vat))
			) &&
			(
				TaxRates == input.TaxRates ||
				(TaxRates != null &&
				 input.TaxRates != null &&
				 TaxRates.SequenceEqual(input.TaxRates))
			) &&
			(
				CashDiscountDate == input.CashDiscountDate ||
				(CashDiscountDate != null &&
				 CashDiscountDate.Equals(input.CashDiscountDate))
			) &&
			(
				CashDiscountValue == input.CashDiscountValue ||
				(CashDiscountValue != null &&
				 CashDiscountValue.Equals(input.CashDiscountValue))
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
				LineItems == input.LineItems ||
				(LineItems != null &&
				 LineItems.Equals(input.LineItems))
			) &&
			(
				RunOcr == input.RunOcr ||
				(RunOcr != null &&
				 RunOcr.Equals(input.RunOcr))
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class DocumentsBody {\n");
		sb.Append("  FileName: ").Append(FileName).Append("\n");
		sb.Append("  FileContent: ").Append(FileContent).Append("\n");
		sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
		sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
		sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
		sb.Append("  DocumentDate: ").Append(DocumentDate).Append("\n");
		sb.Append("  DocumentDueDate: ").Append(DocumentDueDate).Append("\n");
		sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
		sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
		sb.Append("  PaidAt: ").Append(PaidAt).Append("\n");
		sb.Append("  NetAmount: ").Append(NetAmount).Append("\n");
		sb.Append("  GrossAmount: ").Append(GrossAmount).Append("\n");
		sb.Append("  Currency: ").Append(Currency).Append("\n");
		sb.Append("  Vat: ").Append(Vat).Append("\n");
		sb.Append("  TaxRates: ").Append(TaxRates).Append("\n");
		sb.Append("  CashDiscountDate: ").Append(CashDiscountDate).Append("\n");
		sb.Append("  CashDiscountValue: ").Append(CashDiscountValue).Append("\n");
		sb.Append("  Tags: ").Append(Tags).Append("\n");
		sb.Append("  Note: ").Append(Note).Append("\n");
		sb.Append("  LineItems: ").Append(LineItems).Append("\n");
		sb.Append("  RunOCR: ").Append(RunOcr).Append("\n");
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
		return Equals(input as DocumentsBody);
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

			if (CompanyId != null)
			{
				hashCode = hashCode * 59 + CompanyId.GetHashCode();
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

			if (PaymentMethod != null)
			{
				hashCode = hashCode * 59 + PaymentMethod.GetHashCode();
			}

			if (PaymentStatus != null)
			{
				hashCode = hashCode * 59 + PaymentStatus.GetHashCode();
			}

			if (PaidAt != null)
			{
				hashCode = hashCode * 59 + PaidAt.GetHashCode();
			}

			if (NetAmount != null)
			{
				hashCode = hashCode * 59 + NetAmount.GetHashCode();
			}

			if (GrossAmount != null)
			{
				hashCode = hashCode * 59 + GrossAmount.GetHashCode();
			}

			if (Currency != null)
			{
				hashCode = hashCode * 59 + Currency.GetHashCode();
			}

			if (Vat != null)
			{
				hashCode = hashCode * 59 + Vat.GetHashCode();
			}

			if (TaxRates != null)
			{
				hashCode = hashCode * 59 + TaxRates.GetHashCode();
			}

			if (CashDiscountDate != null)
			{
				hashCode = hashCode * 59 + CashDiscountDate.GetHashCode();
			}

			if (CashDiscountValue != null)
			{
				hashCode = hashCode * 59 + CashDiscountValue.GetHashCode();
			}

			if (Tags != null)
			{
				hashCode = hashCode * 59 + Tags.GetHashCode();
			}

			if (Note != null)
			{
				hashCode = hashCode * 59 + Note.GetHashCode();
			}

			if (LineItems != null)
			{
				hashCode = hashCode * 59 + LineItems.GetHashCode();
			}

			if (RunOcr != null)
			{
				hashCode = hashCode * 59 + RunOcr.GetHashCode();
			}

			return hashCode;
		}
	}
}