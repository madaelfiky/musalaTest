using Musala.BDD.Tests.Utilities.Configuration;
using Driver;
using TechTalk.SpecFlow;
using static Driver.BrowserFactory;

namespace Musala.BDD.Tests.Hooks
{
    [Binding]
    public sealed class GlobalHooks
    {
        private static CustomWebDriver _globalDriver;
        [BeforeTestRun]
        public static void StartBrwoser(TestThreadContext testThreadContext)
        {               
            _globalDriver = BrowserFactory.GetBrowser();
            testThreadContext.Add("driver", _globalDriver);
        }

        [AfterTestRun]
        public static void StopBrowser()
        {
            _globalDriver.QuitBrowser();
        }
    }
}
