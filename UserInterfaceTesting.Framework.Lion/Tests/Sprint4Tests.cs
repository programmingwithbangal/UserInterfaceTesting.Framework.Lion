using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInterfaceTesting.Framework.Lion.Constants;
using UserInterfaceTesting.Framework.Lion.Enums;
using UserInterfaceTesting.Framework.Lion.Models;
using UserInterfaceTesting.Framework.Lion.PageActions;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.Tests
{
    [TestClass]
    [TestCategory("Sprint4Tests")]
    public class Sprint4Tests : BaseTests
    {
        private User TestEmergencyContactUser { get; set; }

        private BasePage TestHomePage { get; set; }

        [TestMethod]
        [Description("Validate that when selecting the Other gender type, the form of Sprint4 is submitted successfully.")]
        [TestProperty("Author", "Alice")]
        public void Test9Sprint4()
        {
            var sprint4PageActions = new Sprint4PageActions(Driver);
            var sprint4PageHelper = new Sprint4Page(Driver);
            GotoSampleApplicationPage(sprint4PageHelper, PageConstants.Sprint4Url, PageConstants.Sprint4Title);
            SetGenderType(Gender.Other);
            sprint4PageActions.FillOutPrimaryContactForm(TestUser);
            TestEmergencyContactUser = SetUser(UserConstants.EmergencyContactFirstName, UserConstants.EmergencyContactLastName);
            SetEmergencyContactGenderType(Gender.Other);
            TestHomePage = sprint4PageActions.FillOutEmergencyContactFormAndSubmit(TestEmergencyContactUser);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that when selecting the Female gender type, the form of Sprint4 is submitted successfully.")]
        [TestProperty("Author", "Alice")]
        public void Test10Sprint4()
        {
            var sprint4PageActions = new Sprint4PageActions(Driver);
            var sprint4PageHelper = new Sprint4Page(Driver);
            GotoSampleApplicationPage(sprint4PageHelper, PageConstants.Sprint4Url, PageConstants.Sprint4Title);
            SetGenderType(Gender.Female);
            sprint4PageActions.FillOutPrimaryContactForm(TestUser);
            TestEmergencyContactUser = SetUser(UserConstants.EmergencyContactFirstName, UserConstants.EmergencyContactLastName);
            SetEmergencyContactGenderType(Gender.Female);
            TestHomePage = sprint4PageActions.FillOutEmergencyContactFormAndSubmit(TestEmergencyContactUser);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        private void GotoSampleApplicationPage(BasePage sprint4Page, string url, string title)
        {
            sprint4Page.GoTo(url);
            Assert.IsTrue(sprint4Page.IsLoaded(title), $"{ErrorConstants.SampleApplicationPageError} Expected: {title} Actual: {Driver.Title}");
        }

        private void SetGenderType(Gender genderType) => TestUser.GenderType = genderType;

        private void SetEmergencyContactGenderType(Gender genderType) => TestEmergencyContactUser.GenderType = genderType;

        private void ValidatePageTitle(BasePage homePage, string ultimateQaHomePageTitle) => Assert.IsTrue(homePage.IsLoaded(ultimateQaHomePageTitle), 
            $"{ErrorConstants.UltimateQaHomePageError} Expected: {ultimateQaHomePageTitle} Actual: {Driver.Title}");
    }
}