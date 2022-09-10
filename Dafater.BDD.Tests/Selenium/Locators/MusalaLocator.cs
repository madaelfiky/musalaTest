

using OpenQA.Selenium;

namespace Musala.BDD.Tests.Selenium.Locators
{
    public class MusalaLocator
    {
        public static By musalaLogo = By.XPath("//a [@class='brand' and @title=' Musala Soft']");
        public static By musalaContactUs = By.XPath("//* [@data-alt='Contact us']");

        public static By journalVoucherButton = By.Id("module-anchor-doctype-Journal Voucher");
        public static By salesInvoicButton = By.Id("module-anchor-doctype-Sales Invoice");
        public static By paymentVoucherButton = By.Id("module-anchor-doctype-Payment Voucher");
        public static By newPaymentVoucherButton = By.XPath("//a[@data-doctype='Payment Voucher']");
        public static By receiptVoucherButton = By.Id("module-anchor-doctype-Receipt Voucher");
        public static By returnNoteButton = By.Id("module-anchor-doctype-Return Note");
        public static By chartOfAccountsButton = By.Id("sidebar-accounts-chart-of-accounts");
        public static By chartOfCostCentersButton = By.Id("sidebar-accounts-cost-center");
        public static By newCompanyButton = By.Id("appframe-btn-New Company");
        public static By salesInvoicePageTitle = By.XPath("//div[@id='page-Form/Sales Invoice']//span//h5");
        public static By purchaseInvoicButton = By.Id("module-anchor-doctype-Purchase Invoice");
        public static By fromSalesInvoiceButton = By.Id("appframe-btn-From Sales Invoice");
        public static By fromDeliveryNoteButton = By.Id("appframe-btn-From Delivery Note");
        public static By getButton = By.Id("Button-get");
        public static By purchaseInvoicePageTitle = By.XPath("//div[@id='page-Form/Purchase Invoice']//span//h5");
        public static By companyPageTitle = By.XPath("//div[@id='page-Form/Company']//h5");
        public static By journalVoucherPageTitle = By.XPath("//div[@id='page-Form/Journal Voucher']//h5");
        public static By paymentVoucherPageTitle = By.XPath("//div[@id='page-Form/Payment Voucher']//h5");
        public static By paymentVoucherSubmittedLabel = By.XPath("//div[@id='page-Form/Payment Voucher']//span[@class='label label-success']");
        public static By receiptVoucherSubmittedLabel = By.XPath("//div[@id='page-Form/Receipt Voucher']//span[@class='label label-success']");
        public static By receiptVoucherPageTitle = By.XPath("//div[@id='page-Form/Receipt Voucher']//h5");
        public static By returnNoteSubmittedLabel = By.XPath("//div[@id='page-Form/Return Note']//span[@class='label label-success']");
        public static By returnNotePageTitle = By.XPath("//div[@id='page-Form/Return Note']//span/h5");
        public static By customerLink = By.Id("module-anchor-doctype-Customer");
        public static By paymentReconciliation = By.Id("sidebar-accounts-payment-reconciliation");
        public static By addNewJournalVoucherButton = By.XPath("//a[@class='add add-new-doctype' and @data-doctype='Journal Voucher']/i");
        public static By addNewCompanyAddressButton = By.Id("Company-New Company 1-Button-add_new_address_fields");
        public static By addAddressButton = By.Id("Button-add");
        public static By expandInitiateAccounts = By.Id("sidebar-accounts-initiate-accounts");
        public static By addBudgetDistribution = By.Id("sidebar-accounts-budget-distribution");
        public static By addModeofPayment = By.Id("sidebar-accounts-mode-of-payment");
        public static By addSettlementofSalesInvoicesbutton = By.Id("sidebar-accounts-settlement-of-sales-invoices");

    }
}
