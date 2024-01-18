using Minicon.GetMyInvoices.Client.Model;

namespace Minicon.GetMyInvoices.Client.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IBankAccountTransactionApi
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Assign Document to Transaction.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="bankAccountUid">BankAccountUid</param>
	/// <param name="transactionUid">TransactionUid</param>
	/// <returns>Task of AssignTransaction</returns>
	Task<AssignTransaction> AssignTransactionAsync(TransactionUidAssignBody body, string bankAccountUid,
		string transactionUid);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Add new Transaction.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="bankAccountUid">BankAccountUid</param>
	/// <returns>Task of CreateTransaction</returns>
	Task<CreateTransaction> CreateATransactionAsync(BankAccountUidTransactionsBody body, string bankAccountUid);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Delete Transaction.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="bankAccountUid">BankAccountUid</param>
	/// <param name="transactionUid">TransactionUid</param>
	/// <returns>Task of DeleteTransaction</returns>
	Task<DeleteTransaction> DeleteTransactionAsync(string bankAccountUid, string transactionUid);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Set transaction status to ignore or unknown.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="bankAccountUid">BankAccountUid</param>
	/// <param name="transactionUid">TransactionUid</param>
	/// <returns>Task of IgnoreTransaction</returns>
	Task<IgnoreTransaction> IgnoreTransactionAsync(TransactionUidIgnoreBody body, string bankAccountUid,
		string transactionUid);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     List Transaction.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="bankAccountUid">BankAccountUid</param>
	/// <param name="startDateFilter">Start date. (optional)</param>
	/// <param name="endDateFilter">End date. (optional)</param>
	/// <param name="textFilter">search string. (optional)</param>
	/// <param name="statusFilter">search status. (optional)</param>
	/// <param name="offset">return result set from limit to offset (optional)</param>
	/// <param name="limit">Number of transactions set (optional)</param>
	/// <returns>Task of ListTransactions</returns>
	Task<ListTransactions> ListTransactionAsync(string bankAccountUid, string startDateFilter = null,
		string endDateFilter = null, string textFilter = null, string statusFilter = null, int? offset = null,
		int? limit = null);

	/// <summary>
	/// </summary>
	/// <remarks>
	///     Set Transaction&#x60;s Tags
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="bankAccountUid">BankAccountUid</param>
	/// <param name="transactionUid">TransactionUid</param>
	/// <returns>Task of SetTransactionTags</returns>
	Task<SetTransactionTags> SetTransactionsTagsAsync(TransactionUidTagsBody body, string bankAccountUid,
		string transactionUid);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Update Transaction.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="bankAccountUid">BankAccountUid</param>
	/// <param name="transactionUid">TransactionUid</param>
	/// <returns>Task of UpdateTransaction</returns>
	Task<UpdateTransaction> UpdateTransactionAsync(TransactionsTransactionUidBody body, string bankAccountUid,
		string transactionUid);
	
}
