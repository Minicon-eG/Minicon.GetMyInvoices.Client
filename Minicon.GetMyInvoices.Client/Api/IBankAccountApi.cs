using Minicon.GetMyInvoices.Client.Model;

namespace Minicon.GetMyInvoices.Client.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IBankAccountApi
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///     List Bank Accounts.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="offset">return result set from limit to offset (optional)</param>
	/// <param name="limit">Number of accounts set (optional)</param>
	/// <returns>Task of ListBankAccounts</returns>
	Task<ListBankAccounts> ListBankAccountsAsync(int? offset = null, int? limit = null);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Update Bank Account Balance
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="bankAccountUid">BankAccountUid</param>
	/// <returns>Task of UpdateBankAccountBalance</returns>
	Task<UpdateBankAccountBalance> UpdateBankAccountBalanceAsync(BankAccountsBankAccountUidBody body,
		string bankAccountUid);
}
