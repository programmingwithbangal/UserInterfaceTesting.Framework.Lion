using OpenQA.Selenium;

namespace UserInterfaceTesting.Framework.Lion.Pages
{
    internal class Sprint2Page : BasePage
    {
        internal Sprint2Page(IWebDriver driver) : base(driver){}

        internal IWebElement FirstNameField => Driver.FindElement(By.XPath("//*[@name='firstname']"));

        internal IWebElement LastNameField => Driver.FindElement(By.XPath("//*[@name='lastname']"));

        internal IWebElement FirstNameFieldAlternate => Driver.FindElement(By.Name("firstname"));

        internal IWebElement LastNameFieldAlternate => Driver.FindElement(By.Name("lastname"));

        internal IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));
    }
}