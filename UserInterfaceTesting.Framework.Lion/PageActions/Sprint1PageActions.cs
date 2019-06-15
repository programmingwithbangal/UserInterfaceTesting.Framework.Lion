using OpenQA.Selenium;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.PageActions
{
    internal class Sprint1PageActions
    {
        internal Sprint1Page Sprint1Page { get; set; }

        internal Sprint1PageActions(IWebDriver driver)
        {
            Sprint1Page = new Sprint1Page(driver);
        }

        internal void FillOutFormAndSubmit(string firstname)
        {
            Sprint1Page.FirstNameField.SendKeys(firstname);
            Sprint1Page.SubmitButton.Submit();
        }
    }
}