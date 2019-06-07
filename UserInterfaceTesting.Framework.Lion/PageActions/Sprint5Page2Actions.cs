using System;
using OpenQA.Selenium;
using UserInterfaceTesting.Framework.Lion.Enums;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.PageActions
{
    internal class Sprint5Page2Actions
    {
        internal Sprint5Page2 Sprint5Page2 { get; set; }

        internal Sprint5Page2Actions(IWebDriver driver)
        {
            Sprint5Page2 = new Sprint5Page2(driver);
        }

        internal BasePage FillOutRadioButtonAndSubmit(Animal animalType)
        {
            SetAnimal(animalType);
            Sprint5Page2.SubmitButton.Submit();
            return new BasePage(Sprint5Page2.Driver);
        }

        private void SetAnimal(Animal animalType)
        {
            switch (animalType)
            {
                case Animal.Wolves:
                    break;
                case Animal.Crocodiles:
                    Sprint5Page2.CrocodilesRadioButton.Click();
                    break;
                case Animal.Bunnies:
                    Sprint5Page2.BunniesRadioButton.Click();
                    break;
                case Animal.None:
                    throw new Exception($"Request type: {animalType} is invalid.");
                default:
                    throw new NotImplementedException($"Request type: {animalType} is not implemented.");
            }
        }
    }
}