

using Musala.BDD.Tests.Pages;
using Musala.BDD.Tests.Selenium.Locators;
using Driver;
using System;
using TechTalk.SpecFlow;

namespace Musala.BDD.Tests.Selenium.Pages
{
    public class MusalaPage : PageBase
    {
        public MusalaPage(CustomWebDriver driver) : base(driver)
        {
        }

        public void ClickOnJournalVoucherButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.journalVoucherButton, 3);
            driver.ClickOn(MusalaLocator.journalVoucherButton);
        }


        public void GivenTheUserScrollToContactUs()
        {

            driver.WaitUntilElementIsVisible(MusalaLocator.musalaLogo, 3);
            driver.ScrollToElement(MusalaLocator.musalaContactUs);
        }

        public void GivenTheUserClickonContactUs()
        {

            driver.ForceClickOn(MusalaLocator.musalaContactUs);
        }




        public void ClickOnSalesInvoiceButton()
        {
            driver.ClickOn(MusalaLocator.musalaContactUs);
        }

        public string GetSalesInvoicePageTitle()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.salesInvoicePageTitle,5);
            return driver.GetText(MusalaLocator.salesInvoicePageTitle);
        }

        public void ClickOnChartOfAccountsButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.chartOfAccountsButton, 5);
            driver.ClickOn(MusalaLocator.chartOfAccountsButton);
        }

        public void ClickOnChartOfCostCentersButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.chartOfCostCentersButton, 5);
            driver.ClickOn(MusalaLocator.chartOfCostCentersButton);
        }

        public void ClickOnCustomerLink()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.customerLink, 5);
            driver.ClickOn(MusalaLocator.customerLink);
        }

        public void ClickOnNewCompanyButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.newCompanyButton, 5);
            driver.ClickOn(MusalaLocator.newCompanyButton);
        }

        public void ClickOnReturnNoteButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.returnNoteButton, 5);
            driver.ClickOn(MusalaLocator.returnNoteButton);
        }

        public void ClickOnPaymentReconciliationButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.paymentReconciliation, 5);
            driver.ClickOn(MusalaLocator.paymentReconciliation);
        }
        public void ClickOnSettlementOfSalesInvoicesButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.addSettlementofSalesInvoicesbutton, 5);
            driver.ClickOn(MusalaLocator.addSettlementofSalesInvoicesbutton);
        }
        public void ClickOnToolsButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.musalaLogo, 5);
            driver.ClickOn(MusalaLocator.musalaLogo);
        }
        public void AccountSearch()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.musalaLogo, 5);
            driver.ClickOn(MusalaLocator.musalaLogo);
            driver.SendKeys(MusalaLocator.musalaLogo, "Alex");
        }
        public void PullPaymentEnteries()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.musalaLogo, 5);
            driver.ClickOn(MusalaLocator.musalaLogo);
        }
        public void Allocate()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.musalaLogo, 5);
            driver.ClickOn(MusalaLocator.musalaLogo);
        }
        public string AllocationSuccessMessage()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.musalaLogo, 5);
            return driver.GetText(MusalaLocator.musalaLogo);
        }

        public void ClickOnPaymentVoucherButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.paymentVoucherButton, 5);
            driver.ClickOn(MusalaLocator.paymentVoucherButton);
        }

        public void ClickOnNewPaymentVoucherButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.newPaymentVoucherButton, 5);
            driver.ClickOn(MusalaLocator.newPaymentVoucherButton);
        }

        public void ClickOnReceiptVoucherButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.receiptVoucherButton, 3);
            driver.ClickOn(MusalaLocator.receiptVoucherButton);
        }

        public void ClickOnPurchaseInvoiceButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.purchaseInvoicButton, 3);
            driver.ClickOn(MusalaLocator.purchaseInvoicButton);
        }

        public void ClickOnFromSalesInvoiceButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.fromSalesInvoiceButton, 3);
            driver.ClickOn(MusalaLocator.fromSalesInvoiceButton);
        }

        public void ClickOnFromDeliveryNoteButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.fromDeliveryNoteButton, 3);
            driver.ClickOn(MusalaLocator.fromDeliveryNoteButton);
        }

        public void ClickOnGetButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.getButton, 3);
            driver.ClickOn(MusalaLocator.getButton);
            driver.Pause(3);
        }

        public string GetPurchaseInvoicePageTitle()
        {
            return driver.GetText(MusalaLocator.purchaseInvoicePageTitle);
        }

        public string GetCompanyPageTitle()
        {
            return driver.GetText(MusalaLocator.companyPageTitle);
        }

        public string GetJournalVoucherTitle()
        {
            return driver.GetText(MusalaLocator.journalVoucherPageTitle);
        }

        public string GetPaymentVoucherTitle()
        {
            return driver.GetText(MusalaLocator.paymentVoucherPageTitle);
        }

        public bool IsPaymentVoucherSubmitted()
        {
            return driver.IsVisible(MusalaLocator.paymentVoucherSubmittedLabel);
        }

        public bool IsReceiptVoucherSubmitted()
        {
            return driver.IsVisible(MusalaLocator.receiptVoucherSubmittedLabel);
        }

        public string GetReceiptVoucherPageTitle()
        {
            return driver.GetText(MusalaLocator.receiptVoucherPageTitle);
        }

        public bool IsReturnNoteSubmitted()
        {
            return driver.IsVisible(MusalaLocator.returnNoteSubmittedLabel);
        }

        public string GetReturnNotePageTitle()
        {
            return driver.GetText(MusalaLocator.returnNotePageTitle);
        }

        public void ClickAddNewJournalVoucherButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.addNewJournalVoucherButton, 3);
            driver.ClickOn(MusalaLocator.addNewJournalVoucherButton);
        }

        public void ClickAddNewCompanyAddressButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.addNewCompanyAddressButton, 3);
            driver.ClickOn(MusalaLocator.addNewCompanyAddressButton);
        }

        public void ClickAddAddressButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.addAddressButton, 3);
            driver.ClickOn(MusalaLocator.addAddressButton);
        }
        public void ClickInitiateAccounts()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.expandInitiateAccounts, 3);
            driver.ClickOn(MusalaLocator.expandInitiateAccounts);
        }
        public void ClickBudgetDistribution()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.addBudgetDistribution, 3);
            driver.ClickOn(MusalaLocator.addBudgetDistribution);
        }
        public void ClickModeofPayment()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.addModeofPayment, 3);
            driver.ClickOn(MusalaLocator.addModeofPayment);
        }
    }
}
