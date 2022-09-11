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


    }
}
