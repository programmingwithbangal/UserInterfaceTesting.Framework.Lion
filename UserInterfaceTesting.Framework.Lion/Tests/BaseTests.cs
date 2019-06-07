using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using UserInterfaceTesting.Framework.Lion.Constants;
using UserInterfaceTesting.Framework.Lion.Models;
using UserInterfaceTestingResources;

namespace UserInterfaceTesting.Framework.Lion.Tests
{
    public class BaseTests
    {
        internal IWebDriver Driver { get; set; }

        internal User TestUser { get; set; }

        [TestInitialize]
        public void SetupBeforeEveryTest()
        {
            Driver = GetChromeDriver();
            TestUser = SetUser(UserConstants.DefaultFirstName, UserConstants.DefaultLastName);
        }

        internal static User SetUser(string firstName, string lastName)
        {
            return new User
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        private static IWebDriver GetChromeDriver()
        {
            var factory = new WebDriverFactory();
            var driver = factory.Create(BrowserType.Chrome);
            return driver;
        }

        [TestCleanup]
        public void CleanupAfterEveryTest()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}