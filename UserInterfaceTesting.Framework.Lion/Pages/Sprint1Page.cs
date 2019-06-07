using OpenQA.Selenium;

namespace UserInterfaceTesting.Framework.Lion.Pages
{
    internal class Sprint1Page : BasePage
    {
        internal Sprint1Page(IWebDriver driver) : base(driver){}

        internal IWebElement FirstNameField => Driver.FindElement(By.XPath("//*[@name='firstname']"));

        internal IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));
    }
}