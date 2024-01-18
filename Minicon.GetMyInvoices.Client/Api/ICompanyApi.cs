using Minicon.GetMyInvoices.Client.Model;
using Refit;

namespace Minicon.GetMyInvoices.Client.Api;

/// <summary>
///     Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICompanyApi //: IApiAccessor
{
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Add new custom company.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <returns>Task of AddCustomCompany</returns>
	[Post("/companies")]
	Task<AddCustomCompany> AddCustomCompanyAsync(CompaniesBody body);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Delete existing custom company.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="companyUid">the id</param>
	/// <returns>Task of DeleteCustomCompany</returns>
	[Delete("/companies/{companyUid}")]
	Task<DeleteCustomCompany> DeleteCustomCompanyAsync(string companyUid);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Get list of all companies from the account.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="statusFilter">
	///     Status filter. Possible values: 0 &#x3D; Any, 1 &#x3D; Active, -1 &#x3D; Inactive, -2 &#x3D;
	///     Pending (optional)
	/// </param>
	/// <param name="companyTypeFilter">
	///     Company type filter. Possible values: 0 &#x3D; Any, ONLINE_PORTAL &#x3D; Online-Portal
	///     only, CUSTOM_COMPANY &#x3D; Custom company only (optional)
	/// </param>
	/// <param name="returnPortalRecords"></param>
	/// <returns>Task of Companies</returns>
	[Get("/companies")]
	Task<Companies> GetCompanyListAsync(
		int statusFilter = 0,
		string? companyTypeFilter = null,
		int returnPortalRecords = 0);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Get one company from the account.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="companyUid">the id</param>
	/// <returns>Task of GetCompany</returns>
	[Get("/companies/{companyUid}")]
	Task<GetCompany> GetOneCompanyAsync(string companyUid);
	
	/// <summary>
	/// </summary>
	/// <remarks>
	///     Update existing custom company.
	/// </remarks>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="body"></param>
	/// <param name="companyUid">the id</param>
	/// <returns>Task of UpdateCustomCompany</returns>
	[Put("/companies/{companyUid}")]
	Task<UpdateCustomCompany> UpdateCustomCompanyAsync(CompaniesCompanyUidBody body, string companyUid);

}
