using Musala.BDD.Tests.Utilities.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Reflection;

namespace Driver
{
    public class BrowserFactory
    {
        private readonly static string _binaryPaath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        private readonly static string _browserType = ConfigManager.Config.BrowserType;

        public static CustomWebDriver GetBrowser()
        {
            IWebDriver driver;
            switch (_browserType.ToUpper())
            {
                case "FireFox":
                    driver = new FirefoxDriver(_binaryPaath);
                    break;
                case "CHROME":
                    driver = new ChromeDriver(_binaryPaath);
                    break;
                default:
                    throw new Exception("Unknow browser type " + _browserType);

            }
            driver.Manage().Window.Maximize();
            return new CustomWebDriver(driver);
        }
    }
}
