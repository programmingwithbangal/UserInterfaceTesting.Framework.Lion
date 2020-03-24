using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
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
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(new List<string>()
            {
                "--silent-launch",
                "--no-startup-window",
                "no-sandbox",
                "headless"
            });

            var outPutDirectory = GetAssemblysOutputDirectory();
            return new ChromeDriver(outPutDirectory, chromeOptions);
        }

        private static string GetAssemblysOutputDirectory()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
    }
}