using System;
using OpenQA.Selenium;
using UserInterfaceTesting.Framework.Lion.Enums;
using UserInterfaceTesting.Framework.Lion.Models;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.PageActions
{
    internal class Sprint3PageActions
    {
        internal Sprint3Page Sprint3Page { get; set; }

        internal Sprint3PageActions(IWebDriver driver)
        {
            Sprint3Page = new Sprint3Page(driver);
        }

        internal void FillOutFormWithRadioButtonAndSubmit(User user)
        {
            SetGender(user);
            Sprint3Page.FirstNameField.SendKeys(user.FirstName);
            Sprint3Page.LastNameField.SendKeys(user.LastName);
            Sprint3Page.SubmitButton.Submit();
        }

        private void SetGender(User user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    break;
                case Gender.Female:
                    Sprint3Page.FemaleGenderRadioButton.Click();
                    break;
                case Gender.Other:
                    Sprint3Page.OtherGenderRadioButton.Click();
                    break;
                case Gender.None:
                    throw new Exception($"Request type: {user.GenderType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {user.GenderType} is not implemented.");
            }
        }
    }
}