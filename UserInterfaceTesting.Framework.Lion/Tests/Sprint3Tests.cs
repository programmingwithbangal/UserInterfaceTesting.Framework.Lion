using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInterfaceTesting.Framework.Lion.Constants;
using UserInterfaceTesting.Framework.Lion.Enums;
using UserInterfaceTesting.Framework.Lion.PageActions;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.Tests
{
    [TestClass]
    [TestCategory("Sprint3Tests")]
    public class Sprint3Tests : BaseTests
    {
        [TestMethod]
        [Description("Validate that when selecting the Other gender type, the form of Sprint3 is submitted successfully.")]
        [TestProperty("Author", "Jack")]
        public void Test7Sprint3()
        {
            var sprint3PageActions = new Sprint3PageActions(Driver);
            GotoSampleApplicationPage(sprint3PageActions.Sprint3Page, PageConstants.Sprint3Url, PageConstants.Sprint3Title);
            SetGenderType(Gender.Other);
            sprint3PageActions.FillOutFormWithRadioButtonAndSubmit(TestUser);
            ValidatePageTitle(sprint3PageActions.Sprint3Page, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that when selecting the Female gender type, the form of Sprint3 is submitted successfully.")]
        [TestProperty("Author", "Jack")]
        public void Test8Sprint3()
        {
            var sprint3PageActions = new Sprint3PageActions(Driver);
            GotoSampleApplicationPage(sprint3PageActions.Sprint3Page, PageConstants.Sprint3Url, PageConstants.Sprint3Title);
            SetGenderType(Gender.Female);
            sprint3PageActions.FillOutFormWithRadioButtonAndSubmit(TestUser);
            ValidatePageTitle(sprint3PageActions.Sprint3Page, PageConstants.UltimateQaHomePageTitle);
        }

        private void GotoSampleApplicationPage(BasePage basePage, string url, string title)
        {
            basePage.GoTo(url);
            Assert.IsTrue(basePage.IsLoaded(title), $"{ErrorConstants.SampleApplicationPageError} Expected: {title} Actual: {Driver.Title}");
        }

        private void SetGenderType(Gender genderType) => TestUser.GenderType = genderType;

        private void ValidatePageTitle(BasePage basePage, string ultimateQaHomePageTitle) => Assert.IsTrue(basePage.IsLoaded(ultimateQaHomePageTitle),
            $"{ErrorConstants.UltimateQaHomePageError} Expected: {ultimateQaHomePageTitle} Actual: {Driver.Title}");
    }
}