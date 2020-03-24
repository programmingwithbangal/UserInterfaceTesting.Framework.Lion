using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using UserInterfaceTesting.Framework.Lion.Enums;
using UserInterfaceTesting.Framework.Lion.Models;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.PageActions
{
    internal class Sprint4PageActions
    {
        internal Sprint4Page Sprint4Page { get; set; }

        private Actions WebDriverActions => new Actions(Sprint4Page.Driver);

        internal Sprint4PageActions(IWebDriver driver)
        {
            Sprint4Page = new Sprint4Page(driver);
        }

        internal void FillOutPrimaryContactForm(User user)
        {
            SetPrimaryContactGender(user);
            Sprint4Page.FirstNameField.SendKeys(user.FirstName);
            Sprint4Page.LastNameField.SendKeys(user.LastName);
        }

        internal void FillOutEmergencyContactFormAndSubmit(User emergencyContactUser)
        {
            SetEmergencyContactGender(emergencyContactUser);
            Sprint4Page.FirstNameEmergencyContactField.SendKeys(emergencyContactUser.FirstName);
            Sprint4Page.LastNameEmergencyContactField.SendKeys(emergencyContactUser.LastName);
            Sprint4Page.SubmitEmergencyContactButton.Submit();
        }

        private void SetPrimaryContactGender(User user)
        {
            switch (user.GenderType)
            {
                case Gender.Male:
                    break;
                case Gender.Female:
                    Sprint4Page.FemaleGenderRadioButton.Click();
                    break;
                case Gender.Other:
                    Sprint4Page.OtherGenderRadioButton.Click();
                    break;
                case Gender.None:
                    throw new Exception($"Request type: {user.GenderType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {user.GenderType} is not implemented.");
            }
        }

        private void SetEmergencyContactGender(User emergencyContactUser)
        {
            switch (emergencyContactUser.GenderType)
            {
                case Gender.Male:
                    break;
                case Gender.Female:
                    WebDriverActions.MoveToElement(Sprint4Page.FemaleGenderEmergencyContactRadioButton).Click();
                    break;
                case Gender.Other:
                    WebDriverActions.MoveToElement(Sprint4Page.OtherGenderEmergencyContactRadioButton).Click();
                    break;
                case Gender.None:
                    throw new Exception($"Request type: {emergencyContactUser.GenderType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {emergencyContactUser.GenderType} is not implemented.");
            }
        }
    }
}