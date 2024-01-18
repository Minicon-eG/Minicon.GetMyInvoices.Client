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
///     ListDocumentsRecordsPaymentDetails
/// </summary>
[DataContract]
public sealed class ListDocumentsRecordsPaymentDetails : IEquatable<ListDocumentsRecordsPaymentDetails>
{
	/// <summary>
	///     Initializes a new instance of the <see cref="ListDocumentsRecordsPaymentDetails" /> class.
	/// </summary>
	/// <param name="senderEmail">Sender Email.</param>
	/// <param name="recipientEmail">Recipient Email.</param>
	/// <param name="transactionId">Transaction ID.</param>
	/// <param name="cardNumber">Card Number.</param>
	/// <param name="sepaCreditorId">Sepa Creditor ID.</param>
	/// <param name="sepaMandateReference">Sepa Mandate Reference.</param>
	/// <param name="purposeOfUsage">Purpose of Usage.</param>
	/// <param name="iban">IBAN.</param>
	/// <param name="bic">BIC.</param>
	/// <param name="accountHolderName">Account Holder Name.</param>
	/// <param name="accountNumber">Account Number.</param>
	/// <param name="bankName">Bank Name.</param>
	/// <param name="bankAddress">Bank Address.</param>
	/// <param name="sortCode">Sort Code.</param>
	/// <param name="routingNumber">Routing Number.</param>
	/// <param name="ifscCode">IFSC Code.</param>
	/// <param name="routingCode">Routing Code.</param>
	/// <param name="cashDiscountDate">Cash Discount Date.</param>
	/// <param name="cashDiscountValue">Cash Discount Value.</param>
	public ListDocumentsRecordsPaymentDetails(string senderEmail = default, string recipientEmail = default,
		string transactionId = default, string cardNumber = default, string sepaCreditorId = default,
		string sepaMandateReference = default, string purposeOfUsage = default, string iban = default,
		string bic = default, string accountHolderName = default, string accountNumber = default,
		string bankName = default, string bankAddress = default, string sortCode = default,
		string routingNumber = default, string ifscCode = default, string routingCode = default,
		string cashDiscountDate = default, decimal? cashDiscountValue = default)
	{
		SenderEmail = senderEmail;
		RecipientEmail = recipientEmail;
		TransactionId = transactionId;
		CardNumber = cardNumber;
		SepaCreditorId = sepaCreditorId;
		SepaMandateReference = sepaMandateReference;
		PurposeOfUsage = purposeOfUsage;
		Iban = iban;
		Bic = bic;
		AccountHolderName = accountHolderName;
		AccountNumber = accountNumber;
		BankName = bankName;
		BankAddress = bankAddress;
		SortCode = sortCode;
		RoutingNumber = routingNumber;
		IfscCode = ifscCode;
		RoutingCode = routingCode;
		CashDiscountDate = cashDiscountDate;
		CashDiscountValue = cashDiscountValue;
	}

	/// <summary>
	///     Sender Email
	/// </summary>
	/// <value>Sender Email</value>
	[DataMember(Name = "sender_email", EmitDefaultValue = false)]
	public string SenderEmail { get; set; }

	/// <summary>
	///     Recipient Email
	/// </summary>
	/// <value>Recipient Email</value>
	[DataMember(Name = "recipient_email", EmitDefaultValue = false)]
	public string RecipientEmail { get; set; }

	/// <summary>
	///     Transaction ID
	/// </summary>
	/// <value>Transaction ID</value>
	[DataMember(Name = "transaction_id", EmitDefaultValue = false)]
	public string TransactionId { get; set; }

	/// <summary>
	///     Card Number
	/// </summary>
	/// <value>Card Number</value>
	[DataMember(Name = "card_number", EmitDefaultValue = false)]
	public string CardNumber { get; set; }

	/// <summary>
	///     Sepa Creditor ID
	/// </summary>
	/// <value>Sepa Creditor ID</value>
	[DataMember(Name = "sepa_creditor_id", EmitDefaultValue = false)]
	public string SepaCreditorId { get; set; }

	/// <summary>
	///     Sepa Mandate Reference
	/// </summary>
	/// <value>Sepa Mandate Reference</value>
	[DataMember(Name = "sepa_mandate_reference", EmitDefaultValue = false)]
	public string SepaMandateReference { get; set; }

	/// <summary>
	///     Purpose of Usage
	/// </summary>
	/// <value>Purpose of Usage</value>
	[DataMember(Name = "purposeOfUsage", EmitDefaultValue = false)]
	public string PurposeOfUsage { get; set; }

	/// <summary>
	///     IBAN
	/// </summary>
	/// <value>IBAN</value>
	[DataMember(Name = "iban", EmitDefaultValue = false)]
	public string Iban { get; set; }

	/// <summary>
	///     BIC
	/// </summary>
	/// <value>BIC</value>
	[DataMember(Name = "bic", EmitDefaultValue = false)]
	public string Bic { get; set; }

	/// <summary>
	///     Account Holder Name
	/// </summary>
	/// <value>Account Holder Name</value>
	[DataMember(Name = "accountHolderName", EmitDefaultValue = false)]
	public string AccountHolderName { get; set; }

	/// <summary>
	///     Account Number
	/// </summary>
	/// <value>Account Number</value>
	[DataMember(Name = "accountNumber", EmitDefaultValue = false)]
	public string AccountNumber { get; set; }

	/// <summary>
	///     Bank Name
	/// </summary>
	/// <value>Bank Name</value>
	[DataMember(Name = "bank_name", EmitDefaultValue = false)]
	public string BankName { get; set; }

	/// <summary>
	///     Bank Address
	/// </summary>
	/// <value>Bank Address</value>
	[DataMember(Name = "bank_address", EmitDefaultValue = false)]
	public string BankAddress { get; set; }

	/// <summary>
	///     Sort Code
	/// </summary>
	/// <value>Sort Code</value>
	[DataMember(Name = "sort_code", EmitDefaultValue = false)]
	public string SortCode { get; set; }

	/// <summary>
	///     Routing Number
	/// </summary>
	/// <value>Routing Number</value>
	[DataMember(Name = "routing_number", EmitDefaultValue = false)]
	public string RoutingNumber { get; set; }

	/// <summary>
	///     IFSC Code
	/// </summary>
	/// <value>IFSC Code</value>
	[DataMember(Name = "ifsc_code", EmitDefaultValue = false)]
	public string IfscCode { get; set; }

	/// <summary>
	///     Routing Code
	/// </summary>
	/// <value>Routing Code</value>
	[DataMember(Name = "routing_code", EmitDefaultValue = false)]
	public string RoutingCode { get; set; }

	/// <summary>
	///     Cash Discount Date
	/// </summary>
	/// <value>Cash Discount Date</value>
	[DataMember(Name = "cash_discount_date", EmitDefaultValue = false)]
	public string CashDiscountDate { get; set; }

	/// <summary>
	///     Cash Discount Value
	/// </summary>
	/// <value>Cash Discount Value</value>
	[DataMember(Name = "cash_discount_value", EmitDefaultValue = false)]
	public decimal? CashDiscountValue { get; set; }

	/// <summary>
	///     Returns true if ListDocumentsRecordsPaymentDetails instances are equal
	/// </summary>
	/// <param name="input">Instance of ListDocumentsRecordsPaymentDetails to be compared</param>
	/// <returns>Boolean</returns>
	public bool Equals(ListDocumentsRecordsPaymentDetails input)
	{
		if (input == null)
		{
			return false;
		}

		return
			(
				SenderEmail == input.SenderEmail ||
				(SenderEmail != null &&
				 SenderEmail.Equals(input.SenderEmail))
			) &&
			(
				RecipientEmail == input.RecipientEmail ||
				(RecipientEmail != null &&
				 RecipientEmail.Equals(input.RecipientEmail))
			) &&
			(
				TransactionId == input.TransactionId ||
				(TransactionId != null &&
				 TransactionId.Equals(input.TransactionId))
			) &&
			(
				CardNumber == input.CardNumber ||
				(CardNumber != null &&
				 CardNumber.Equals(input.CardNumber))
			) &&
			(
				SepaCreditorId == input.SepaCreditorId ||
				(SepaCreditorId != null &&
				 SepaCreditorId.Equals(input.SepaCreditorId))
			) &&
			(
				SepaMandateReference == input.SepaMandateReference ||
				(SepaMandateReference != null &&
				 SepaMandateReference.Equals(input.SepaMandateReference))
			) &&
			(
				PurposeOfUsage == input.PurposeOfUsage ||
				(PurposeOfUsage != null &&
				 PurposeOfUsage.Equals(input.PurposeOfUsage))
			) &&
			(
				Iban == input.Iban ||
				(Iban != null &&
				 Iban.Equals(input.Iban))
			) &&
			(
				Bic == input.Bic ||
				(Bic != null &&
				 Bic.Equals(input.Bic))
			) &&
			(
				AccountHolderName == input.AccountHolderName ||
				(AccountHolderName != null &&
				 AccountHolderName.Equals(input.AccountHolderName))
			) &&
			(
				AccountNumber == input.AccountNumber ||
				(AccountNumber != null &&
				 AccountNumber.Equals(input.AccountNumber))
			) &&
			(
				BankName == input.BankName ||
				(BankName != null &&
				 BankName.Equals(input.BankName))
			) &&
			(
				BankAddress == input.BankAddress ||
				(BankAddress != null &&
				 BankAddress.Equals(input.BankAddress))
			) &&
			(
				SortCode == input.SortCode ||
				(SortCode != null &&
				 SortCode.Equals(input.SortCode))
			) &&
			(
				RoutingNumber == input.RoutingNumber ||
				(RoutingNumber != null &&
				 RoutingNumber.Equals(input.RoutingNumber))
			) &&
			(
				IfscCode == input.IfscCode ||
				(IfscCode != null &&
				 IfscCode.Equals(input.IfscCode))
			) &&
			(
				RoutingCode == input.RoutingCode ||
				(RoutingCode != null &&
				 RoutingCode.Equals(input.RoutingCode))
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
			);
	}

	/// <summary>
	///     Returns the string presentation of the object
	/// </summary>
	/// <returns>String presentation of the object</returns>
	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("class ListDocumentsRecordsPaymentDetails {\n");
		sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
		sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
		sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
		sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
		sb.Append("  SepaCreditorId: ").Append(SepaCreditorId).Append("\n");
		sb.Append("  SepaMandateReference: ").Append(SepaMandateReference).Append("\n");
		sb.Append("  PurposeOfUsage: ").Append(PurposeOfUsage).Append("\n");
		sb.Append("  Iban: ").Append(Iban).Append("\n");
		sb.Append("  Bic: ").Append(Bic).Append("\n");
		sb.Append("  AccountHolderName: ").Append(AccountHolderName).Append("\n");
		sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
		sb.Append("  BankName: ").Append(BankName).Append("\n");
		sb.Append("  BankAddress: ").Append(BankAddress).Append("\n");
		sb.Append("  SortCode: ").Append(SortCode).Append("\n");
		sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
		sb.Append("  IfscCode: ").Append(IfscCode).Append("\n");
		sb.Append("  RoutingCode: ").Append(RoutingCode).Append("\n");
		sb.Append("  CashDiscountDate: ").Append(CashDiscountDate).Append("\n");
		sb.Append("  CashDiscountValue: ").Append(CashDiscountValue).Append("\n");
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
		return Equals(input as ListDocumentsRecordsPaymentDetails);
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
			if (SenderEmail != null)
			{
				hashCode = hashCode * 59 + SenderEmail.GetHashCode();
			}

			if (RecipientEmail != null)
			{
				hashCode = hashCode * 59 + RecipientEmail.GetHashCode();
			}

			if (TransactionId != null)
			{
				hashCode = hashCode * 59 + TransactionId.GetHashCode();
			}

			if (CardNumber != null)
			{
				hashCode = hashCode * 59 + CardNumber.GetHashCode();
			}

			if (SepaCreditorId != null)
			{
				hashCode = hashCode * 59 + SepaCreditorId.GetHashCode();
			}

			if (SepaMandateReference != null)
			{
				hashCode = hashCode * 59 + SepaMandateReference.GetHashCode();
			}

			if (PurposeOfUsage != null)
			{
				hashCode = hashCode * 59 + PurposeOfUsage.GetHashCode();
			}

			if (Iban != null)
			{
				hashCode = hashCode * 59 + Iban.GetHashCode();
			}

			if (Bic != null)
			{
				hashCode = hashCode * 59 + Bic.GetHashCode();
			}

			if (AccountHolderName != null)
			{
				hashCode = hashCode * 59 + AccountHolderName.GetHashCode();
			}

			if (AccountNumber != null)
			{
				hashCode = hashCode * 59 + AccountNumber.GetHashCode();
			}

			if (BankName != null)
			{
				hashCode = hashCode * 59 + BankName.GetHashCode();
			}

			if (BankAddress != null)
			{
				hashCode = hashCode * 59 + BankAddress.GetHashCode();
			}

			if (SortCode != null)
			{
				hashCode = hashCode * 59 + SortCode.GetHashCode();
			}

			if (RoutingNumber != null)
			{
				hashCode = hashCode * 59 + RoutingNumber.GetHashCode();
			}

			if (IfscCode != null)
			{
				hashCode = hashCode * 59 + IfscCode.GetHashCode();
			}

			if (RoutingCode != null)
			{
				hashCode = hashCode * 59 + RoutingCode.GetHashCode();
			}

			if (CashDiscountDate != null)
			{
				hashCode = hashCode * 59 + CashDiscountDate.GetHashCode();
			}

			if (CashDiscountValue != null)
			{
				hashCode = hashCode * 59 + CashDiscountValue.GetHashCode();
			}

			return hashCode;
		}
	}
}
