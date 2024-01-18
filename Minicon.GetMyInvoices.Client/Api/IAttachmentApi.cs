using Minicon.GetMyInvoices.Client.Model;

namespace Minicon.GetMyInvoices.Client.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAttachmentApi
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Delete a specific attachment.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="documentUid">DocumentUid</param>
	/// <param name="attachmentUid">AttachmentUid</param>
	/// <returns>Task of DeleteAttachment</returns>
	Task<DeleteAttachment> DeleteOneAttachmentAsync(string documentUid, string attachmentUid);

	/// <summary>
	/// </summary>
	/// <remarks>
	///     Get list of all attachments for an invoice.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="documentUid">DocumentUid</param>
	/// <returns>Task of ListAttachments</returns>
	Task<ListAttachments> GetAttachmentListAsync(string documentUid);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Get specific attachments for an invoice.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="documentUid">DocumentUid</param>
	/// <param name="attachmentUid">AttachmentUid</param>
	/// <returns>Task of GetAttachment</returns>
	Task<GetAttachment> GetOneAttachmentAsync(string documentUid, string attachmentUid);

	/// <summary>
	/// </summary>
	/// <remarks>
	///     Upload a single attachment to invoice.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="documentUid">DocumentUid</param>
	/// <returns>Task of UploadAttachment</returns>
	Task<UploadAttachment> UploadOneAttachmentAsync(DocumentUidAttachmentsBody body, string documentUid);
}
