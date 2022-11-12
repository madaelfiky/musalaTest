

using Musala.BDD.Tests.Pages;
using Musala.BDD.Tests.Selenium.Locators;
using Driver;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Faker;

namespace Musala.BDD.Tests.Selenium.Pages
{   
    public class MusalaPage : PageBase
    {
        public MusalaPage(CustomWebDriver driver) : base(driver)
        {
        }



        public void GivenTheUserEnterallData()
        {

            driver.WaitUntilElementIsVisible(MusalaLocator.kashierFullName, 3);
            driver.SendKeysWithClick(MusalaLocator.kashierFullName, Lorem.GetFirstWord());
            driver.SendKeysWithClick(MusalaLocator.kashierStoreName, Lorem.Sentence());
            driver.SendKeysWithClick(MusalaLocator.kashierPhoneNumber, "01234567890");
            driver.SendKeysWithClick(MusalaLocator.kashierEmail, "test@test.com");
            driver.SendKeysWithClick(MusalaLocator.kashierPassword, "Test_12345");
            driver.SendKeysWithClick(MusalaLocator.kashierPassword2, "Test_12345");

        }


        public void WhenUserClicksSingupButton()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.kashierSignup, 3);
            driver.ClickOn(MusalaLocator.kashierSignup);

        }

        public void AssertUserIsSignedUP()
        {
            driver.WaitUntilElementIsVisible(MusalaLocator.kashierSignupNextpage, 3);

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
