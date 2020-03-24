using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UserInterfaceTesting.Framework.Lion.Pages
{
    internal class BasePage
    {
        internal IWebDriver Driver { get; set; }

        internal WebDriverWait Wait()
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(3));
        }

        internal BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        internal bool IsLoaded(string expected)
        {
            try
            {
                return Driver.Title.Contains(expected);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        internal void GoTo(string uri)
        {
            Driver.Navigate().GoToUrl(uri);
        }
    }
}