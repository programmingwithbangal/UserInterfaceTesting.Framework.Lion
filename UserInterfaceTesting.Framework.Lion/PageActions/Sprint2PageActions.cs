using OpenQA.Selenium;
using UserInterfaceTesting.Framework.Lion.Models;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.PageActions
{
    internal class Sprint2PageActions
    {
        internal Sprint2Page Sprint2Page { get; set; }

        internal Sprint2PageActions(IWebDriver driver)
        {
            Sprint2Page = new Sprint2Page(driver);
        }

        internal void FillOutFormAndSubmit(string firstname, string lastname) => BaseFillOutFormAndSubmit(firstname, lastname);

        internal void FillOutFormAndSubmit(User user) => BaseFillOutFormAndSubmit(user.FirstName, user.LastName);

        internal void FillOutFormAndSubmitAlternate(User user)
        {
            Sprint2Page.FirstNameFieldAlternate.SendKeys(user.FirstName);
            Sprint2Page.LastNameFieldAlternate.SendKeys(user.LastName);
            Sprint2Page.SubmitButton.Submit();
        }

        private void BaseFillOutFormAndSubmit(string firstname, string lastname)
        {
            Sprint2Page.FirstNameField.SendKeys(firstname);
            Sprint2Page.LastNameField.SendKeys(lastname);
            Sprint2Page.SubmitButton.Submit();
        }
    }
}