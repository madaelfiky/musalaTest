

using Musala.BDD.Tests.Pages;
using Musala.BDD.Tests.Selenium.Locators;
using Driver;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Musala.BDD.Tests.Selenium.Pages
{   
    public class MusalaPage : PageBase
    {
        public MusalaPage(CustomWebDriver driver) : base(driver)
        {
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

        public void GivenUserEntersCorrectDataButInvalidEmail()
        {

            driver.SendKeysWithClick(MusalaLocator.musalaContactUsName, "name test");
            driver.SendKeysWithClick(MusalaLocator.musalaContactUsEmail, "test@test");
            driver.SendKeysWithClick(MusalaLocator.musalaContactUsMobileNumber, "Mobile test");
            driver.SendKeysWithClick(MusalaLocator.musalaContactUsSubject, "Subject test");
            driver.SendKeysWithClick(MusalaLocator.musalaContactUsMessage, "Message test");
        }

        public void AssertOnEmailValidationMessage()
        {
          var emailErrormessage = driver.GetText(MusalaLocator.musalaContactUsEmailMessage);
            Assert.AreEqual(emailErrormessage, "The e-mail address entered is invalid.");
        }


    }
}
