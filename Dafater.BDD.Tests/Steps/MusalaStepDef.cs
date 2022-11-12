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

        [Given(@"the user Enters FullData")]
        public void GivenUserScrollToContactUs()
        {
            new MusalaPage(driver).GivenTheUserEnterallData();
        }

        [When(@"user Clicks Singup button")]
        public void WhenUserClicksSingupButton()
        {

            new MusalaPage(driver).WhenUserClicksSingupButton();

        }

        [Then(@"validation message should appears that you're human")]
        public void ThenValidationMessageShouldAppearsThatYoureHuman()
        {

            new MusalaPage(driver).AssertUserIsSignedUP(); 
        }




    }
}
