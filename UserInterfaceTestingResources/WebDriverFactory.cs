using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace UserInterfaceTestingResources
{
    public class WebDriverFactory
    {
        public IWebDriver Create(BrowserType browserType)
        {
            IWebDriver driver;

            switch (browserType)
            {
                case BrowserType.Chrome:
                    driver = GetChromeDriver();
                    break;
                default:
                    throw new NotImplementedException("The browser type is not implemented.");
            }
            return driver;
        }

        private IWebDriver GetChromeDriver()
        {
            var outPutDirectory = GetAssemblysOutputDirectory();
            return new ChromeDriver(outPutDirectory);
        }

        private static string GetAssemblysOutputDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}