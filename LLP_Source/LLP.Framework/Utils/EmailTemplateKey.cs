using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLP.Framework.Utils
{
    public class EmailTemplateKey
    { 
        public static class Contact
        {
            public static string ContactUs { get { return "ContactUs"; } }
            public static string ContactUsNotification { get { return "ContactUsNotification"; } }
             
        } 
        public static class PasswordReset
        {
            public static string ResetPassword { get { return "ResetPassword"; } }
            public static string PasswordHasBeenReset { get { return "PasswordHasBeenReset"; } }
        }
        public static class TaxInvoice
        {
            public static string SendTaxInvoice { get { return "SendTaxInvoice"; } }
        }
        public static class Registration
        {
            public static string ThanksForJoiningNoPurchase { get { return "ThanksForJoiningNoPurchase"; } }
            public static string ThanksForJoining { get { return "ThanksForJoining"; } }
            public static string VerifyEmailAddress { get { return "VerifyEmailAddress"; } }
 
        }
        public static class ReminderEmail
        {
            public static string ReminderTemplate { get { return "ReminderTemplate"; } }
        }

        public static class EmailToSalesPersonFromLeads
        {       
            public static string EmailToSalesPersonFromLead { get { return "EmailToSalesPersonFromLead"; } }
        }

        public static class EmailWorkOrderComplete
        {
            public static string mailWorkOrderComplete { get { return "mailWorkOrderComplete"; } }
        }

        public static class EmailServiceOrderComplete
        {
            public static string mailServiceOrderComplete { get { return "mailServiceOrderComplete"; } }
        }

        public static class EmailToResponsiblePersonFromCustomerNote
        {
            public static string mailToResponsiblePersonFromCustomerNote { get { return "mailToResponsiblePersonFromCustomerNote"; } }
        }

        public static class EmailToLeadSignAgreement
        {
            public static string mailToLeadSignAgreement { get { return "mailToLeadSignAgreement"; } }
        }

        public static class WorkOrderInformationSendEMail
        {
            public static string WorkOrderInformationSendMail { get { return "WorkOrderInformationSendMail"; } }
        }
        public static class ServiceOrderInformationSendEMail
        {
            public static string ServiceOrderInformationSendMail { get { return "ServiceOrderInformationSendMail"; } }
        }

        public static class EmailToLeadFromCurrentLoggedinUser
        {
            public static string EmailToLeadFromCurrentLoggedInUser { get { return "EmailToLeadFromCurrentLoggedinUser"; } }
        }

        public static class EmailConvertLeadToCustomer
        {
            public static string mailConvertLeadToCustomer { get { return "mailConvertLeadToCustomer"; } }
        }

        public static class EmailNotConvertLeadToCustomer
        {
            public static string mailNotConvertLeadToCustomer { get { return "mailNotConvertLeadToCustomer"; } }
        }

        public static class EmailCreateWorkOrder
        {
            public static string mailCreateWorkOrder { get { return "mailCreateWorkOrder"; } }
        }
        public static class EmailCreateServiceOrder
        {
            public static string mailCreateServiceOrder { get { return "mailCreateServiceOrder"; } }
        }
        public static class EmailToSetUpCustomer
        {
            public static string mailCreateCustomerSetup { get { return "mailCreateCustomerSetup"; } }
        }
        public static class mailtoLeadsAggrement
        {
            public static string EmailtoLeadsAggrement { get { return "EmailtoLeadsAggrement"; } }
        }
        public static class EmailToCustomerForTransaction
        {
            public static string mailtoCustomerforTransaction { get { return "mailtoCustomerforTransaction"; } }
        }
        public static class EmailToLeadtoCusforQA
        {
            public static string QAforLeadtoCusConvert { get { return "QAforLeadtoCusConvert"; } }
        }
        public static class EmailLeadSuccess
        {
            public static string mailleadSuccessSetup { get { return "mailleadSuccessSetup"; } }
        }
        public static class EmailNotSetCustomerBilling
        {
            public static string mailNotSetCustomerBilling { get { return "mailNotSetCustomerBilling"; } }
        }

        public static class EmailToEmployeeFromCustomerNote
        {
            public static string EmailToEmployeeFromCustomerNotes { get { return "EmailToEmployeeFromCustomerNotes"; } }
        }

        public static class EmailToEmployeeFromFollowUpNote
        {
            public static string mailToEmployeeFromFollowUpNote { get { return "mailToEmployeeFromFollowUpNote"; } }
        }

        public static class Invoice
        {
            public static string InvoiceEmail { get { return "InvoiceEmail"; } }
        }
        public static class Estimate
        {
            public static string EstimateEmail { get { return "EstimateEmail"; } }
        }
    }
}
