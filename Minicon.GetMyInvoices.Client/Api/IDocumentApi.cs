using Minicon.GetMyInvoices.Client.Model;
using Refit;

namespace Minicon.GetMyInvoices.Client.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IDocumentApi
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Delete an existing document in the account.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="documentUid">the id</param>
	/// <returns>Task of DeleteDocument</returns>
	[Delete("/documents/{documentUid}")]
	Task<DeleteDocument> DeleteDocumentAsync(string documentUid);

	/// <summary>
	///     Get list of all documents from the account.
	/// </summary>
	/// <remarks>
	///     This method retrieves a list of all documents from the account based on the provided filters.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="companyFilter">
	///     Filter by company. Possible values: 0 = Any, -1 = unassigned or any companyUid from the /companies api response.
	///     (optional)
	/// </param>
	/// <param name="archivedFilter">
	///     Filter archived documents. Possible values: 0 = Only not archived, 1 = Any, 2 = Only archived (optional)
	/// </param>
	/// <param name="documentTypeFilter">
	///     Document type. Possible values: INCOMING_INVOICE / RECEIPT / PAYMENT_RECEIPT / EXPENSE_REIMBURSEMENT /
	///     SALES_INVOICE / CREDIT_NOTE / STATEMENT / DELIVERY_NOTE / ORDER_CONFIRMATION / PAYROLL /
	///     COMPANY_REGISTRATION_DOCUMENT / MISC / TRAVEL_EXPENSES / REMINDER (optional)
	/// </param>
	/// <param name="documentNumberFilter">
	///     Filter by document number. (optional)
	/// </param>
	/// <param name="noteFilter">
	///     Filter by note. (optional)
	/// </param>
	/// <param name="startDateFilter">
	///     Start document date filter (optional)
	/// </param>
	/// <param name="endDateFilter">
	///     End document date filter (optional)
	/// </param>
	/// <param name="documentUidExclusionFilter">
	///     Array of document Ids that should not be included in the results (optional)
	/// </param>
	/// <param name="documentUidStartFilter">
	///     Document Id that can be used to limit the result to only higher prim_uids (optional)
	/// </param>
	/// <param name="updatedOrNewSinceFilter">
	///     Limit the result to documents modified or created after the given date. (optional)
	/// </param>
	/// <param name="tagFilter">
	///     Filter by tag name. (optional)
	/// </param>
	/// <param name="paymentStatusFilter">
	///     Filter by payment status. Possible values: paid / not_paid / unknown / all (optional)
	/// </param>
	/// <param name="pageNumber">
	///     If there are more documents than the 500 limit, you can use this to get additional pages (optional)
	/// </param>
	/// <returns>
	///     Task representing the asynchronous operation. The task result contains a list of documents.
	/// </returns>
	[Get("/documents")]
	Task<ListDocuments> DocumentsAsync(
		int? companyFilter = null,
		int archivedFilter = 1,
		string? documentTypeFilter = null,
		string? documentNumberFilter = null,
		string? noteFilter = null,
		string? startDateFilter = null,
		string? endDateFilter = null,
		[AliasAs("documentUidExclusionFilter[]")]
		List<string>? documentUidExclusionFilter = null,
		int? documentUidStartFilter = null,
		string? updatedOrNewSinceFilter = null,
		[AliasAs("tagFilter[]")]
		List<string>? tagFilter = null,
		string? paymentStatusFilter = null,
		int? pageNumber = null
	);

	/// <summary>
	/// Get one document from the account.
	/// </summary>
	/// <remarks>
	/// This method retrieves a single document from the account based on the specified document ID.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="documentUid">The unique identifier of the document.</param>
	/// <param name="loadLineItems">Set to true if you want to receive line items as well. (optional)</param>
	/// <param name="readableText">Set to true if you want to receive readable text from the document. (optional)</param>
	/// <param name="includeDocument">Set to false if you want only basic data without the document content. (optional)</param>
	/// <param name="transactions">Set to false if you want only basic data without the connected transactions. (optional)</param>
	/// <param name="documentApproval">
	/// Set to false if you want only basic data without the connected workflow approval.
	/// (optional)
	/// </param>
	/// <returns>
	/// A task representing the asynchronous operation that returns an instance of GetDocument.
	/// </returns>
	[Get("/documents/{documentUid}")]
	Task<GetDocument> GetOneDocumentAsync(
		string documentUid,
		bool? loadLineItems = null,
		bool? readableText = null,
		bool? includeDocument = null,
		bool? transactions = null,
		bool? documentApproval = null
	);

	/// <summary>
	/// </summary>
	/// <remarks>
	///     Update metadata of existing document in the account.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="documentUid">the id</param>
	/// <returns>Task of UpdateDocument</returns>
	[Put("/documents/{documentUid}")]
	Task<UpdateDocument> UpdateDocumentAsync(DocumentsDocumentUidBody body, string documentUid);

	/// <summary>
	/// </summary>
	/// <remarks>
	///     Upload a new document to the account. Supported file types: pdf
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <returns>Task of UploadNewDocument</returns>
	[Post("/documents")]
	Task<UploadNewDocument> UploadNewDocumentAsync(DocumentsBody body);
}
