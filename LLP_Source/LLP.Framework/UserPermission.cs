using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLP.Framework
{
    public class UserPermissions
    {

        public static class Dashboard
        {
            public static int View { get { return 101; } }
        }

        public static class LeftMenuPermission
        {
            public static int Dashboard { get { return 1001; } }
            public static int Leads { get { return 1002; } }
            public static int Customer { get { return 1003; } }
            public static int Schedule { get { return 1004; } }
            public static int Inventory { get { return 1005; } }
            public static int Sales { get { return 1006; } }
            public static int Bill { get { return 1007; } }
            public static int Report { get { return 1008; } }
        }
         

        public static class TopMenuPermission
        {
            public static int TopSetUpMenu1         { get { return 20001; } }
            public static int TopSetUpMenu2         { get { return 20002; } }
            public static int TopMenuCompanyEdit    { get { return 20003; } }
        }

        public static class MenuPermissions
        { /*1001*/
            public static int LeftMenuDashboard { get { return 1001; } }
            public static int LeftMenuLeads { get { return 1002; } }
            public static int LeftMenuCustomer { get { return 1003; } }
            public static int LeftMenuSchedule { get { return 1004; } }
            public static int LeftMenuInventory { get { return 1005; } }
            public static int LeftMenuSales { get { return 1006; } }
            public static int LeftMenuExpense { get { return 1007; } }
            public static int LeftMenuReport { get { return 1008; } }
            public static int QuickMenuMyCompany { get { return 1010; } }
            public static int QuickMenuMyCompanyCompanyandSystemSettings { get { return 1011; } }
            public static int QuickMenuMyCompanyFees { get { return 1012; } }
            public static int QuickMenuMyCompanyManageUser { get { return 1013; } }
            public static int QuickMenuMyCompanyBranchSettings { get { return 1014; } }
            public static int QuickMenuMyCompanySalesMatrix { get { return 1015; } }
            public static int QuickMenuMyCompanyInstallationMatrix { get { return 1016; } }
            public static int QuickMenuMyCompanyIncomeAndExpenseSettings { get { return 1017; } }
            public static int QuickMenuProducts { get { return 1018; } }
            public static int QuickMenuProductsProductCatagories { get { return 1019; } }
            public static int QuickMenuProductsProductClass { get { return 1020; } }
            public static int QuickMenuProductsProductsandServices { get { return 1021; } }
            public static int QuickMenuProductsCustomerPanelType { get { return 1022; } }
            public static int QuickMenuProductsManufacturers { get { return 1023; } }
            public static int QuickMenuTools { get { return 1024; } }
            public static int QuickMenuToolsCredentialSetting { get { return 1025; } }
            public static int QuickMenuToolsAccountHolder { get { return 1026; } }
            public static int QuickMenuToolsCustomerSystemNo { get { return 1027; } }
            public static int QuickMenuToolsPackageSetup { get { return 1028; } }
            public static int QuickMenuProfileCompany { get { return 1029; } }
            public static int LeftMenuRecruit{ get { return 1030 ; } }
            public static int QuickMenuMyCompanyManageUserGroup { get { return 1031; } }
        }           //1001
        public static class LeadPermissions
        { /*2001*/
            public static int LeadCreate { get { return 2001; } }
            public static int LeadSetupAfterCreate { get { return 2002; } }
            public static int LeadVarify { get { return 2003; } }
            public static int LeadRequestTech { get { return 2004; } }
            public static int LeadDocumentCenter { get { return 2005; } }
            public static int LeadSetupPackageTab { get { return 2006; } }
            public static int LeadSetupEquipmentsTab { get { return 2007; } }
            public static int LeadSetupServiceTab { get { return 2008; } }
            public static int LeadSetupPaymentTab { get { return 2009; } }
            public static int LeadSetupEmergencyTab { get { return 2010; } }
            public static int LeadEdit { get { return 2011; } }
            public static int LeadDelete { get { return 2012; } }
            public static int LeadSearch { get { return 2013; } }
            public static int LeadFilter { get { return 2014; } }
            public static int LeadList { get { return 2015; } }
            public static int LeadCreateStatement { get { return 2016; } }
            public static int LeadEmailWithPrint { get { return 2017; } }
            public static int ExportLeadList { get { return 2018; } }
            public static int ImportLeads { get { return 2019; } }
            public static int LeadCogwheel { get { return 2020; } }
            public static int LeadCogwheelCustomizecolumn { get { return 2021; } }
            public static int LeadCogwheelCreateEmailTemplate { get { return 2022; } }
            public static int LeadCogwheelSourceSettings { get { return 2023; } }
            public static int LeadDetails { get { return 2024; } }
            public static int LeadDetailsPersonalInfo { get { return 2025; } }
            public static int LeadDetailsSetup { get { return 2026; } }
            public static int LeadDetailsVerifyInfo { get { return 2027; } }
            public static int LeadDetailsQA1 { get { return 2028; } }
            public static int LeadDetailsTechCall { get { return 2029; } }
            public static int LeadDetailsQA2 { get { return 2030; } }
            public static int LeadCreateReport { get { return 2031; } }
            public static int LeadNotesTab { get { return 2032; } }
            public static int LeadNotesAdd { get { return 2033; } }
            public static int LeadNotesEdit { get { return 2034; } }
            public static int LeadNotesDelete { get { return 2035; } }
            public static int LeadNotesList { get { return 2036; } }
            public static int LeadFollowUpTab { get { return 2037; } }
            public static int LeadFollowUpAdd { get { return 2038; } }
            public static int LeadFollowUpEdit { get { return 2039; } }
            public static int LeadFollowUpDelete { get { return 2040; } }
            public static int LeadFollowUpList { get { return 2041; } }
            public static int LeadEmailTab { get { return 2042; } }
            public static int SendEmailToTeam { get { return 2043; } }
            public static int SendEmailToLead { get { return 2044; } }
            public static int LeadTechScheduleTab { get { return 2045; } }
            public static int LeadTechScheduleAdd { get { return 2046; } }
            public static int LeadTechScheduleEdit { get { return 2047; } }
            public static int LeadTechScheduleDelete { get { return 2048; } }
            public static int LeadTechScheduleList { get { return 2049; } }
        }           //2001
        public static class CustomerPermissions
        { /*3001*/
            public static int CustomerCreate { get { return 3001; } }
            public static int CustomerSummmery { get { return 3002; } }
            public static int CustomerVarify { get { return 3003; } }
            public static int CustomerRequestTech { get { return 3004; } }
            public static int CustomerFiles { get { return 3005; } }
            public static int CustomerSetupPackageTab { get { return 3006; } }
            public static int CustomerSetupEquipmentsTab { get { return 3007; } }
            public static int CustomerSetupServiceTab { get { return 3008; } }
            public static int CustomerSetupPaymentTab { get { return 3009; } }
            public static int CustomerSetupEmergencyTab { get { return 3010; } }
            public static int CustomerEdit { get { return 3011; } }
            public static int CustomerDelete { get { return 3012; } }
            public static int CustomerSearch { get { return 3013; } }
            public static int CustomerFilter { get { return 3014; } }
            public static int CustomerList { get { return 3015; } }
            public static int CustomerCreateStatement { get { return 3016; } }
            public static int CustomerPrintList { get { return 3017; } }
            public static int ExportCustomerList { get { return 3018; } }
            public static int ImportCustomers { get { return 3019; } }
            public static int CustomerCogwheel { get { return 3020; } }
            public static int CustomerCogwheelCustomizecolumn { get { return 3021; } }
            public static int CustomerCogwheelCreateEmailTemplate { get { return 3022; } }
            public static int CustomerCogwheelSourceSettings { get { return 3023; } }
            public static int CustomerDetails { get { return 3024; } }
            public static int CustomerDetailsPersonalInfo { get { return 3025; } }
            public static int CustomerDetailsPresentAddress { get { return 3026; } }
            public static int CustomerDetailsBilingInfo { get { return 3027; } }
            public static int CustomerDetailsAccountHistory { get { return 3028; } }
            public static int CustomerDetailsInvoiceHistory { get { return 3029; } }
            public static int CustomerDetailsAccountActivity { get { return 3030; } }
            public static int CustomerCreateReport { get { return 3031; } }
            public static int CustomerFollowUpTab { get { return 3032; } }
            public static int CustomerFollowUpAdd { get { return 3033; } }
            public static int CustomerFollowUpEdit { get { return 3034; } }
            public static int CustomerFollowUpDelete { get { return 3035; } }
            public static int CustomerFollowUpList { get { return 3036; } }
            public static int CustomerEmailTab { get { return 3037; } }
            public static int SendEmailToTeam { get { return 3038; } }
            public static int SendEmailToCustomer { get { return 3039; } }
            public static int CustomerTechScheduleTab { get { return 3040; } }
            public static int CustomerTechScheduCustomerd { get { return 3041; } }
            public static int CustomerTechScheduleEdit { get { return 3042; } }
            public static int CustomerTechScheduleDelete { get { return 3043; } }
            public static int CustomerTechScheduleList { get { return 3044; } }
            public static int CustomerInvoiceList { get { return 3045; } }
            public static int CustomerInvoiceAdd { get { return 3046; } }
            public static int CustomerInvoicePrint { get { return 3047; } }
            public static int CustomerInvoiceAddNote { get { return 3048; } }
            public static int CustomerInvoiceSave { get { return 3049; } }
            public static int CustomerInvoiceReceivePayment { get { return 3050; } }
            public static int CustomerInvoiceReceivePaymentSave { get { return 3051; } }
            public static int CustomerFundingList { get { return 3052; } }
            public static int CustomerWorkOrderList { get { return 3053; } }
            public static int CustomerWorkOrderAdd { get { return 3054; } }
            public static int CustomerServiceOrderList { get { return 3055; } }
            public static int CustomerServiceOrderAdd { get { return 3056; } }
            public static int CustomerFilesList { get { return 3057; } }
            public static int CustomerFilesAdd { get { return 3058; } }
            public static int CustomerNotesList { get { return 3059; } }
            public static int CustomerNotesTab { get { return 3060; } }
            public static int CustomerNotesAdd { get { return 3061; } }
            public static int CustomerNotesEdit { get { return 3062; } }
            public static int CustomerNotesDelete { get { return 3063; } }
            public static int CustomerScheduleTab { get { return 3064; } }
            public static int CustomerScheduleAdd { get { return 3065; } }
            public static int CustomerScheduleEdit { get { return 3066; } }
            public static int CustomerScheduleDelete { get { return 3067; } }


        }       //3001 
        public static class UserMgmtPermissions
        {
            /*4001*/
            public static int UserList { get { return 4001; } }
            public static int UserSearch { get { return 4002; } }
            public static int AddUser { get { return 4003; } }
            public static int ActivateUser{ get { return 4004; } }
            public static int DeactivateUser{ get { return 4005; } }
            public static int UserResendEmail{ get { return 4006; } }
            public static int UserDetailTab { get { return 4007; } }
            public static int UserDetailInformation{ get { return 4008; } }
            public static int UserChangePassword{ get { return 4009; } }
            public static int UserChangePermissionGroup{ get { return 4010; } }
            public static int SaveUserInformation{ get { return 4011; } }
            public static int DeleteUser         { get { return 4012; } }
            public static int EditUserPermissions{ get { return 4013; } }
            public static int HRDocTab   { get { return 4014; } }
            public static int FindHrDoc  { get { return 4015; } }
            public static int DeleteHrDoc{ get { return 4016; } }
            public static int AddHrDoc   { get { return 4017; } }
            public static int UserPermissionsTab { get { return 4018; } }
            public static int UserNameChange { get { return 4019; } }
            public static int PasswordChange { get { return 4020; } }
            public static int ManageUserGroup { get { return 4021; } }
            public static int ManageUserGroupAdd { get { return 4022; } }
            public static int ManageUserGroupEdit { get { return 4023; } }
            public static int ManageUserGroupDelete { get { return 4023; } }
            public static int ManageUserGroupAssignPermission { get { return 4024; } }
        }       //4001 
        public static class SalesPermissions
        {/*5001*/
            public static int AllSalesTab { get { return 5001; } }
            public static int AllSalesSummery { get { return 5002; } }
            public static int AllSalesPrint { get { return 5003; } }
            public static int AllSalesReceivePayment { get { return 5004; } }
            public static int SalesInvoiceTab { get { return 5005; } }
            public static int SalesProductsListTab { get { return 5006; } }
            public static int SalesEditProduct { get { return 5007; } }
            public static int SalesAccountReceivableTab { get { return 5008; } }
        }          //5001
        public static class ExpensePermissions
        { /*6001*/
            public static int ExpenseBillingTab { get { return 6001; } }
            public static int ExpenseBillingSummary { get { return 6002; } }
            public static int ExpenseBillingMakePayment { get { return 6003; } }
            public static int ExpneseBillingAddBill { get { return 6004; } }
            public static int ExpenseBillingPrintCheque { get { return 6005; } }
            public static int ExpenseVendorsTab { get { return 6006; } }
            public static int ExpneseVendorsSummary { get { return 6007; } }
            public static int ExpenseVendorsCreateABill { get { return 6008; } }
            public static int ExpenseVendorsEdit { get { return 6009; } }
            public static int ExpneseVendorsAdd { get { return 6010; } }
            public static int ExpneseVendorsDetail { get { return 6011; } }
            public static int VendorsDetailEditVendor { get { return 6012; } }
            public static int VendorsDetailCreateABill { get { return 6013; } }
            public static int VendorsDetailSummary { get { return 6014; } }
            public static int VendorsDetailOpenPayment { get { return 6015; } }
            public static int VendorsDetailOpenBill { get { return 6016; } }
            public static int VendorsDetailMakePayment { get { return 6017; } }
            public static int VendorsDetailPrintCheque { get { return 6018; } }
            public static int ExpensePayrollTab { get { return 6019; } }
            public static int ExpenseAccountsPayableTab { get { return 6020; } }
            public static int AccountsPayableOpenBill { get { return 6021; } }
            public static int AccountsPayableMakePayment { get { return 6022; } }
        }        //6001
        public static class ReportsPermissions
        {/*7001*/
            public static int LeadsReport                   { get { return 7001 ; } }
            public static int LeadsReportDownload           { get { return 7002 ; } }
            public static int InvoiceReport                 { get { return 7003 ; } }
            public static int InvoiceReportDownload         { get { return 7004 ; } }
            public static int EstimateReport                { get { return 7005 ; } }
            public static int EstimateReportDownload        { get { return 7006 ; } }
            public static int PaymentReceivedReport         { get { return 7007 ; } }
            public static int PaymentReceivedReportDownload { get { return 7008 ; } }
            public static int BillsReport                   { get { return 7009 ; } }
            public static int BillsReportDownload           { get { return 7010 ; } }
            public static int BillPaymentReport             { get { return 7011 ; } }
        }        //7001 
        public static class InventoryPermissions
        { /*8001*/
            public static int InventoryProductstab { get { return 8001; } }
            public static int InventoryProductsEdit { get { return 8002; } }
            public static int InventoryTab { get { return 8003; } }
            public static int AddInventory { get { return 8004; } }
            public static int InventorySummary { get { return 8005; } }
            public static int InventroyFilter { get { return 8006; } }
            public static int PurchaseOrderTab { get { return 8007; } }
            public static int TechnicianInventoryTab { get { return 8008; } }
            public static int AddTechnician { get { return 8009; } }
        }      //8001
        public static class MyCompanyPermissions
        {/*My Company Permissions*/
            public static int CompanyAndSystemSettings{ get { return 9001 ; } }
            public static int GlobalSettingsTab{ get { return 9002 ; } }
            public static int GlobalSettingsEdit{ get { return 9003 ; } }
            public static int AlarmComTab{ get { return 9004 ; } }
            public static int AlarmComAdd{ get { return 9005 ; } }
            public static int AlarmComEdit{ get { return 9006 ; } }
            public static int AlarmComDelete{ get { return 9007 ; } }
            public static int AuthorizeNetTab{ get { return 9008 ; } }
            public static int AuthorizeNetAdd{ get { return 9009 ; } }
            public static int AuthorizeNetEdit{ get { return 9010 ; } }
            public static int AuthorizeNetDelete{ get { return 9011 ; } }
            public static int Fees{ get { return 9101 ; } }
            public static int ActivationFeeTab{ get { return 9102 ; } }
            public static int ActivationFeeAdd{ get { return 9103 ; } }
            public static int ActivationFeeEdit{ get { return 9104 ; } }
            public static int ActivationFeeDelete{ get { return 9105 ; } }
            public static int MMRFeeTab{ get { return 9106 ; } }
            public static int MMRFeeAdd{ get { return 9107 ; } }
            public static int MMRFeeEdit{ get { return 9108 ; } }
            public static int MMRFeeDelete{ get { return 9109 ; } }
            public static int ServiceFeeTab{ get { return 9110 ; } }
            public static int ServiceFeeAdd{ get { return 9111 ; } }
            public static int ServiceFeeEdit{ get { return 9112 ; } }
            public static int ServiceFeeDelete{ get { return 9113 ; } }
            public static int BranchSetting{ get { return 9201 ; } }
            public static int BranchSettingEdit{ get { return 9202 ; } }
            public static int BranchSettingChangeLogo{ get { return 9203 ; } }
            public static int BranchSettingAdd{ get { return 9204 ; } }
            public static int BrnachSettingDelete{ get { return 9205 ; } }
            public static int SalesMatrix{ get { return 9301 ; } }
            public static int SalesMatrixAdd{ get { return 9302 ; } }
            public static int SalesMatrixEdit{ get { return 9303 ; } }
            public static int SalesMatrixDelete{ get { return 9304 ; } }
            public static int InstallationMatrix{ get { return 9401 ; } }
            public static int IncomeAndExpense { get { return 9501 ; } }
        }      //9001
        public static class ProductsPermissions
        {
            public static int ProductCategories { get { return 10001 ; } }
            public static int ProductCategoriesAdd { get { return 10002 ; } }
            public static int ProductCategoriesEdit { get { return 10003 ; } }
            public static int ProductCategoriesDelete { get { return 10004 ; } }
            public static int ProductClass { get { return 10005 ; } }
            public static int ProductClassAdd { get { return 10006 ; } }
            public static int ProductClassEdit { get { return 10007 ; } }
            public static int ProductClassDelete { get { return 10008 ; } }
            public static int ProductsAndServices { get { return 10009 ; } }
            public static int ProductsAndServicesAdd { get { return 10010 ; } }
            public static int ProductsAndServicesEdit { get { return 10011 ; } }
            public static int ProductsAndServicesDelete { get { return 10012 ; } }
            public static int CustomerPanelType { get { return 10013 ; } }
            public static int CustomerPanelTypeAdd { get { return 10014 ; } }
            public static int CustomerPanelTypeEdit { get { return 10015 ; } }
            public static int CustomerPanelTypeDelete { get { return 10016 ; } }
            public static int Manufacturers { get { return 10017 ; } }
            public static int ManufacturersAdd { get { return 10018 ; } }
            public static int ManufacturersEdit { get { return 10019 ; } }
            public static int ManufacturersDelete { get { return 10020; } }
        }       //10001
        public static class ToolsPermissions
        {
            public static int CredentialSettings { get { return 11001 ; } }
            public static int CredentialSettingsAdd { get { return 11002 ; } }
            public static int CredentialSettingsEdit { get { return 11003 ; } }
            public static int CredentialSettingsDelete { get { return 11004 ; } }
            public static int AccountHolder { get { return 11005 ; } }
            public static int AccountHolderAdd { get { return 11006 ; } }
            public static int AccountHolderEdit { get { return 11007 ; } }
            public static int AccountHolderDelete { get { return 11008 ; } }
            public static int CustomerSystemNo { get { return 11009 ; } }
            public static int CustomerSystemNoAdd { get { return 11010 ; } }
            public static int CustomerSystemNoEdit { get { return 11011 ; } }
            public static int CustomerSystemNoDelete { get { return 11012 ; } }
            public static int PackageSetup { get { return 11013 ; } }
            public static int PackageSetupAdd { get { return 11014 ; } }
            public static int PackageSetupEdit { get { return 11015 ; } }
            public static int PackageSetupDelete { get { return 11016 ; } }

        }          //11001
    }
}