using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInterfaceTesting.Framework.Lion.Constants;
using UserInterfaceTesting.Framework.Lion.Enums;
using UserInterfaceTesting.Framework.Lion.Models;
using UserInterfaceTesting.Framework.Lion.PageActions;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.Tests
{
    [TestClass]
    [TestCategory("Sprint5Tests")]
    public class Sprint5Tests : BaseTests
    {
        private User TestEmergencyContactUser { get; set; }

        private BasePage BasePage { get; set; }

        [TestMethod]
        [Description("Validate that when selecting the Female gender type, the form of Sprint5 is submitted successfully.")]
        [TestProperty("Author", "Jack")]
        public void Test11Sprint5()
        {
            var sprint5PageActions = new Sprint5PageActions(Driver);
            GotoSampleApplicationPage(sprint5PageActions.Sprint5Page, PageConstants.Sprint5Url, PageConstants.Sprint5Title);
            SetGenderType(Gender.Female);
            sprint5PageActions.FillOutPrimaryContactForm(TestUser);
            TestEmergencyContactUser = SetUser(UserConstants.EmergencyContactFirstName, UserConstants.EmergencyContactLastName);
            SetEmergencyContactGenderType(Gender.Other);
            BasePage = sprint5PageActions.FillOutEmergencyContactFormAndSubmit(TestEmergencyContactUser);
            Assert.IsTrue(BasePage.IsLoaded(PageConstants.FormPage2Title),
                $"{ErrorConstants.SampleApplicationPage2Error} Expected: {PageConstants.FormPage2Title} Actual: {Driver.Title}");
        }

        [TestMethod]
        [Description("Validate that the second form of Sprint5 is submitted successfully when selecting the Crocodiles animal type.")]
        [TestProperty("Author", "Jack")]
        public void Test12Sprint5()
        {
            Test11Sprint5();
            var sprint5Page2Actions = new Sprint5Page2Actions(Driver);
            BasePage = sprint5Page2Actions.FillOutRadioButtonAndSubmit(Animal.Crocodiles);
            Assert.IsTrue(BasePage.IsLoaded(PageConstants.UltimateQaHomePageTitle),
                $"{ErrorConstants.UltimateQaHomePageError} Expected: {PageConstants.UltimateQaHomePageTitle} Actual: {Driver.Title}");
        }

        [TestMethod]
        [Description("Validate that the second form of Sprint5 is submitted successfully when selecting the Bunnies animal type.")]
        [TestProperty("Author", "Jack")]
        public void Test13Sprint5()
        {
            Test11Sprint5();
            var sprint5Page2Actions = new Sprint5Page2Actions(Driver);
            BasePage = sprint5Page2Actions.FillOutRadioButtonAndSubmit(Animal.Bunnies);
            Assert.IsTrue(BasePage.IsLoaded(PageConstants.UltimateQaHomePageTitle),
                $"{ErrorConstants.UltimateQaHomePageError} Expected: {PageConstants.UltimateQaHomePageTitle} Actual: {Driver.Title}");
        }

        private void GotoSampleApplicationPage(BasePage sprint5Page, string url, string title)
        {
            sprint5Page.GoTo(url);
            Assert.IsTrue(sprint5Page.IsLoaded(title), $"{ErrorConstants.SampleApplicationPageError} Expected: {title} Actual: {Driver.Title}");
        }

        private void SetGenderType(Gender genderType) => TestUser.GenderType = genderType;

        private void SetEmergencyContactGenderType(Gender genderType) => TestEmergencyContactUser.GenderType = genderType;
    }
}