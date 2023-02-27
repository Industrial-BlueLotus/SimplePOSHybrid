using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOSHybrid.Models
{
    public class LoginResModel
    {
        public int ResponseType { get; set; }
        public int TotalRecordCount { get; set; }
        public object[] ErrorMessages { get; set; }
        public object[] Messages { get; set; }
        public Responsedata ResponseData { get; set; }
        public bool incomplete_results { get; set; }
    }

    public class Responsedata
    {
        public User User { get; set; }
    }

    public class User
    {
        public object UserName { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public int UserKey { get; set; }
        public bool IsGroup { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsPosUser { get; set; }
        public bool IsOrderHub { get; set; }
        public bool IsWebUser { get; set; }
        public bool IsPDAUser { get; set; }
        public bool IsSysUser { get; set; }
        public bool IsMultiCompanyUser { get; set; }
        public object Email { get; set; }
        public int UserAddressKey { get; set; }
        public string EnvironmentName { get; set; }
        public Usercompany[] UserCompanies { get; set; }
        public Userlocation[] UserLocations { get; set; }
        public object LoginUserId { get; set; }
        public object IntegrationId { get; set; }
        public object RequestingId { get; set; }
        public object Apikey { get; set; }
        public bool IsAllowedForTransaction { get; set; }
        public bool IsAllowedForPrinting { get; set; }
        public int RequestingObjectKey { get; set; }
        public int PersitingObjectKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int ApproveSate { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDefault { get; set; }
        public object CreatedBy { get; set; }
        public object UpdatedBy { get; set; }
        public object IsActiveStr { get; set; }
        public object OwningCompany { get; set; }
        public bool IsRecordLocked { get; set; }
    }

    public class Usercompany
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCode { get; set; }
        public object Address { get; set; }
        public object City { get; set; }
        public bool IsKotVoidAutomation { get; set; }
        public bool IsCheckStockSummary { get; set; }
        public object Town { get; set; }
        public object Telephone1 { get; set; }
        public object Telephone2 { get; set; }
        public object Telephone3 { get; set; }
        public object Country { get; set; }
        public object Email { get; set; }
        public object AlertEmail { get; set; }
        public object TaxNumber { get; set; }
        public object TrnStDt { get; set; }
        public object TrnCnfDt { get; set; }
        public int IsERP { get; set; }
        public object ParentCompany { get; set; }
        public object LocationKey { get; set; }
        public object LocationName { get; set; }
        public int isERP { get; set; }
        public int isMultiAddress { get; set; }
        public bool PartnerOrderingEnabled { get; set; }
        public object IntegrationId { get; set; }
        public object RequestingId { get; set; }
        public object Apikey { get; set; }
        public bool IsAllowedForTransaction { get; set; }
        public bool IsAllowedForPrinting { get; set; }
        public int RequestingObjectKey { get; set; }
        public int PersitingObjectKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int ApproveSate { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDefault { get; set; }
        public object CreatedBy { get; set; }
        public object UpdatedBy { get; set; }
        public object IsActiveStr { get; set; }
        public object OwningCompany { get; set; }
        public bool IsRecordLocked { get; set; }
    }

    public class Userlocation
    {
        public string LocationName { get; set; }
        public object LocationCode { get; set; }
        public int LocationId { get; set; }
        public int PermissionId { get; set; }
        public object Company { get; set; }
        public int ParentId { get; set; }
        public int ParentId2 { get; set; }
        public bool IsUrbanPiper { get; set; }
        public object IntegrationId { get; set; }
        public object RequestingId { get; set; }
        public object Apikey { get; set; }
        public bool IsAllowedForTransaction { get; set; }
        public bool IsAllowedForPrinting { get; set; }
        public int RequestingObjectKey { get; set; }
        public int PersitingObjectKey { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int ApproveSate { get; set; }
        public bool IsActive { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDefault { get; set; }
        public object CreatedBy { get; set; }
        public object UpdatedBy { get; set; }
        public object IsActiveStr { get; set; }
        public object OwningCompany { get; set; }
        public bool IsRecordLocked { get; set; }
    }

}
