using Minicon.GetMyInvoices.Client.Model;

namespace Minicon.GetMyInvoices.Client.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IGeneralEndpointsApi
{

	/// <summary>
	/// </summary>
	/// <remarks>
	///     Check API status.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ApiStatus</returns>
	Task<ApiStatus> ApiStatusAsync();

	/// <summary>
	/// </summary>
	/// <remarks>
	///     Get list of all available countries.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of GetCountries</returns>
	Task<GetCountries> GetCountryListAsync();
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Get list of all available currencies.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of GetCurrencies</returns>
	Task<GetCurrencies> GetCurrencyListAsync();

	/// <summary>
	/// </summary>
	/// <remarks>
	///     Get list of all available Tags in GMI user.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of GetTags</returns>
	Task<GetTags> GetTagListAsync();
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Get list of all vat rates from the account.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of GetVatRates</returns>
	Task<GetVatRates> GetVatRatesAsync();
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     List of all portals.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <returns>Task of ListPortals</returns>
	Task<ListPortals> ListPortalsAsync();
}
