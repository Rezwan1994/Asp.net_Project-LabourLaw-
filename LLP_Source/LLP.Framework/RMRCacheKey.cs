using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLP.Framework
{
    public static class RMRCacheKey
    {
        public static string EmailLogoUrl
        {
            get
            {
                return "__EmailLogoUrl";
            }
        }
        public static string CompanyLogoColored
        {
            get
            {
                return "__CompanyLogoColored";
            }
        }
        public static string CompanyBlacknWhiteLogo
        {
            get
            {
                return "__CompanyBlacknWhiteLogo";
            }
        }

        public static string YoutubeUrl
        {
            get
            {
                return "__YoutubeUrl";
            }
        }
        public static string FacebookUrl
        {
            get
            {
                return "__FacebookUrl";
            }
        }
        public static string AuthAPILoginId
        {
            get
            {
                return "__AuthAPILoginId";
            }
        }
        public static string AuthTransactionKey
        {
            get
            {
                return "__AuthTransactionKey";
            }
        }
        public static string CustomerSearchMaxLoad
        {
            get
            {
                return "__CustomerSearchMaxLoad";
            }
        }
        public static string EquipmentSearchMaxLoad
        {
            get
            {
                return "__EquipmentSearchMaxLoad";
            }
        }
        public static string TeamNameSignatureLoad
        {
            get
            {
                return "__TeamNameSignatureLoad";
            }
        }
        public static string AgreementDocumentHeightLoad
        {
            get
            {
                return "__AgreementDocumentHeightLoad";
            }
        }
        public static string VendorSearchMaxLoad
        {
            get
            {
                return "__VendorSearchMaxLoad";
            }
        }
        public static string PermissionGroups
        {
            get
            {
                return "PermissionGroups";
            }
        }

        public static string LeadCityStateSearchMaxLoad
        {
            get
            {
                return "__LeadCityStateSearchMaxLoad";
            }
        }
        public static string InvoiceMessageGlobal
        {
            get
            {
                return "__InvoiceMessageGlobal";
            }
        }
        public static string EstimateMessageGlobal
        {
            get
            {
                return "__EstimateMessageGlobal";
            }
        }
    }

    public static class SessionKeys
    {
        public static string CompanyConnectionString { get { return "CompanyConnectionString"; } }
        public static string CurrentLoggedInUser { get { return "CurrentLoggedInUser"; } }
        public static string CurrentUserCompanyList { get { return "CurrentUserCompanyList"; } }
        public static string PermissionList { get { return "_PermissionList"; } }
        public static string UserName { get { return "_CurrentUserName"; } }
        public static string UserPermissionList { get { return "UserPermissions"; } }
        public static string UserRole { get { return "_CurrentUserRole"; } }
    }
    public static class CookieKeys
    { 
        public static string CurrentUser { get { return "CurrentUser"; } }
        public static string CurrentUserTimeZone { get { return "CurrentUserTimeZone"; } }
        public static string CurrentUserDate { get { return "CurrentUserDate"; } }
        public static string CurrentUserTime { get { return "CurrentUserTime"; } }
        public static string Customer { get { return "__Customer"; } }

    }

}
