﻿

using OpenQA.Selenium;

namespace Musala.BDD.Tests.Selenium.Locators
{
    public class MusalaLocator
    {

        //homepage

        public static By musalaLogo = By.XPath("//a [@class='brand' and @title=' Musala Soft']");
        public static By musalaContactUs = By.XPath("//* [@data-alt='Contact us']");
        public static By musalaContactUsName = By.XPath("//* [@name='your-name']");
        public static By musalaContactUsEmail = By.XPath("//* [@name='your-email']");
        public static By musalaContactUsMobileNumber = By.XPath("//* [@name='mobile-number']");
        public static By musalaContactUsSubject = By.XPath("//* [@name='your-subject']");
        public static By musalaContactUsMessage = By.XPath("//* [@name='your-message']");
        public static By musalaContactUsEmailMessage = By.XPath("//* [@data-name='your-email']/span");


        //Company

        public static By musalaCompany = By.XPath("//ul[@class='nav']/li/a [text()='Company']");
        public static By musalaLeaderShipSection = By.XPath("//* [@class='company-members']");
        public static By musalaFaceBook = By.XPath("//* [@class='musala musala-icon-facebook']");
        public static By musalaProfilePicture = By.XPath("//* [@aria-label='Musala Soft profile photo']");



    }
}
