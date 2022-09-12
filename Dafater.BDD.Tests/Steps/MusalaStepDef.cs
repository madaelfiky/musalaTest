using Musala.BDD.Tests.Hooks;
using Musala.BDD.Tests.Selenium.Pages;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace Musala.BDD.Tests.Steps
{
    [Binding]
    public sealed class MusalaStepDef : TestState
    {
        public MusalaStepDef(TestThreadContext testThreadContext, ScenarioContext scenarioContext) : base(testThreadContext, scenarioContext)
        {
        }

        [Given(@"the user Scroll to Contact us")]
        public void GivenUserScrollToContactUs()
        {
            new MusalaPage(driver).GivenTheUserScrollToContactUs();
        }

        [Given(@"user click on contact us")]
        public void GivenUserClickOnContactUs()
        {

            new MusalaPage(driver).GivenTheUserClickonContactUs();
        }

        [When(@"user enters correct data but invalid email")]
        public void WhenUserEntersCorrectDataButInvalidEmail()
        {
            new MusalaPage(driver).GivenUserEntersCorrectDataButInvalidEmail();
        }

        [Then(@"validation message should appears under email field")]
        public void ThenValidationMessageShouldAppearsUnderEmailField()
        {
            new MusalaPage(driver).AssertOnEmailValidationMessage();
        }

        [Given(@"the user Click ‘Company’ tap from the top and verifies URL")]
        public void GivenTheUserClickCompanyTapFromTheTopAndVerifiesURL()
        {
            new MusalaCompanyPage(driver).GivenTheUserClickCompanyTapFromTheTopAndVerifiesURL();
        }
        [Given(@"Verify that there is ‘Leadership’ section")]
        public void GivenVerifyThatThereIsLeadershipSection()
        {
            new MusalaCompanyPage(driver).GivenVerifyThatThereIsLeadershipSection();
        }

        [Given(@"Click the Facebook link from the footer")]
        public void GivenClickTheFacebookLinkFromTheFooter()
        {
            new MusalaCompanyPage(driver).GivenClickTheFacebookLinkFromTheFooter();
        }
        [Then(@"Verify that the correct URL and Musala Soft profile picture appears")]
        public void ThenVerifyThatTheCorrectURLAndMusalaSoftProfilePictureAppears()
        {
            new MusalaCompanyPage(driver).ThenVerifyThatTheCorrectURLAndMusalaSoftProfilePictureAppears();
        }

        [Given(@"the user Click ‘Careers’ tap from the top")]
        public void GivenTheUserClickCareersTapFromTheTop()
        {
            new MusalaCareersPage(driver).GivenTheUserClickCareersTapFromTheTop();

        }

        [Given(@"Click ‘Check our open positions’ button and verifies URL")]
        public void GivenClickCheckOurOpenPositionsButtonAndVerifiesURL()
        {
            new MusalaCareersPage(driver).GivenClickCheckOurOpenPositionsButtonAndVerifiesURL();
        }


        [Given(@"From the dropdown ‘Select location’ select ‘Anywhere’")]
        public void GivenFromTheDropdownSelectLocationSelectAnywhere()
        {
            new MusalaCareersPage(driver).GivenFromTheDropdownSelectLocationSelectAnywhere();
        }


        [Given(@"Choose open position by name and apply")]
        public void GivenChooseOpenPositionByNameAndApply()
        {
            new MusalaCareersPage(driver).GivenChooseOpenPositionByNameAndApply();
        }

        [Given(@"Enter wrong details")]
        public void GivenEnterWrongDetails()
        {
            new MusalaCareersPage(driver).GivenEnterWrongDetails();
        }

        [Given(@"Upload a CV document, and click ‘Send’ button")]
        public void GivenUploadACVDocumentAndClickSendButton()
        {
            new MusalaCareersPage(driver).GivenUploadACVDocumentAndClickSendButton();
        }

        [Then(@"Print jobs")]
        public void ThenPrintJobs()
        {
            new MusalaCareersPage(driver).ThenPrintJobs();
        }




    }
}
