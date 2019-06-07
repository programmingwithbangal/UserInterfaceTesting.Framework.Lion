using OpenQA.Selenium;

namespace UserInterfaceTesting.Framework.Lion.Pages
{
    internal class Sprint5Page : BasePage
    {
        internal Sprint5Page(IWebDriver driver) : base(driver){}

        internal IWebElement FirstNameField => Driver.FindElement(By.Id("f1"));

        internal IWebElement LastNameField => Driver.FindElement(By.Id("l1"));

        internal IWebElement FemaleGenderRadioButton => Driver.FindElement(By.Id("radio1-f"));

        internal IWebElement OtherGenderRadioButton => Driver.FindElement(By.Id("radio1-0"));

        internal IWebElement FirstNameEmergencyContactField => Driver.FindElement(By.Id("f2"));

        internal IWebElement LastNameEmergencyContactField => Driver.FindElement(By.Id("l2"));

        internal IWebElement SubmitEmergencyContactButton => Driver.FindElement(By.Id("submit2"));

        internal IWebElement FemaleGenderEmergencyContactRadioButton => Driver.FindElement(By.Id("radio2-f"));

        internal IWebElement OtherGenderEmergencyContactRadioButton => Driver.FindElement(By.Id("radio2-0"));
    }
}