using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace UserInterfaceTesting.Framework.Lion.Pages
{
    internal class Sprint5Page2 : BasePage
    {
        internal Sprint5Page2(IWebDriver driver) : base(driver){}

        internal IWebElement SubmitButton => Wait().Until(d => d.FindElement(By.XPath("//*[@type='submit']")));

        internal IWebElement CrocodilesRadioButton => Wait().Until(d => d.FindElement(By.XPath("//input[@value='crocodiles']")));

        internal IWebElement BunniesRadioButton => Wait().Until(d => d.FindElement(By.XPath("//input[@value='bunnies']")));
    }
}