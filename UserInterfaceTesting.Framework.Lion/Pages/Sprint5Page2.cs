using OpenQA.Selenium;

namespace UserInterfaceTesting.Framework.Lion.Pages
{
    internal class Sprint5Page2 : BasePage
    {
        internal Sprint5Page2(IWebDriver driver) : base(driver){}

        internal IWebElement SubmitButton => Driver.FindElement(By.XPath("//*[@type='submit']"));

        internal IWebElement CrocodilesRadioButton => Driver.FindElement(By.XPath("//input[@value='crocodiles']"));

        internal IWebElement BunniesRadioButton => Driver.FindElement(By.XPath("//input[@value='bunnies']"));
    }
}