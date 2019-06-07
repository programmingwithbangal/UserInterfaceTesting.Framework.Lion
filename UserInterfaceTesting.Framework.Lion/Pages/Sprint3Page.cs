using OpenQA.Selenium;

namespace UserInterfaceTesting.Framework.Lion.Pages
{
    internal class Sprint3Page : BasePage
    {
        internal Sprint3Page(IWebDriver driver) : base(driver){}

        internal IWebElement FirstNameField => Driver.FindElement(By.XPath("//*[@name='firstname']"));

        internal IWebElement LastNameField => Driver.FindElement(By.XPath("//*[@name='lastname']"));

        internal IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));

        internal IWebElement FemaleGenderRadioButton => Driver.FindElement(By.XPath("//input[@value='female']"));

        internal IWebElement OtherGenderRadioButton => Driver.FindElement(By.XPath("//input[@value='other']"));
    }
}