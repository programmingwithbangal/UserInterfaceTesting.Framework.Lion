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
        private BasePage TestHomePage { get; set; }

        [TestMethod]
        [Description("Validate that when selecting the Other gender type, the form of Sprint3 is submitted successfully.")]
        [TestProperty("Author", "Jack")]
        public void Test7Sprint3()
        {
            var sprint3PageActions = new Sprint3PageActions(Driver);
            var sprint3PageHelper = new Sprint3Page(Driver);
            GotoSampleApplicationPage(sprint3PageHelper, PageConstants.Sprint3Url, PageConstants.Sprint3Title);
            SetGenderType(Gender.Other);
            TestHomePage = sprint3PageActions.FillOutFormWithRadioButtonAndSubmit(TestUser);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that when selecting the Female gender type, the form of Sprint3 is submitted successfully.")]
        [TestProperty("Author", "Jack")]
        public void Test8Sprint3()
        {
            var sprint3PageActions = new Sprint3PageActions(Driver);
            var sprint3PageHelper = new Sprint3Page(Driver);
            GotoSampleApplicationPage(sprint3PageHelper, PageConstants.Sprint3Url, PageConstants.Sprint3Title);
            SetGenderType(Gender.Female);
            TestHomePage = sprint3PageActions.FillOutFormWithRadioButtonAndSubmit(TestUser);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        private void GotoSampleApplicationPage(BasePage sprint3Page, string url, string title)
        {
            sprint3Page.GoTo(url);
            Assert.IsTrue(sprint3Page.IsLoaded(title), $"{ErrorConstants.SampleApplicationPageError} Expected: {title} Actual: {Driver.Title}");
        }

        private void SetGenderType(Gender genderType) => TestUser.GenderType = genderType;

        private void ValidatePageTitle(BasePage homePage, string ultimateQaHomePageTitle) => Assert.IsTrue(homePage.IsLoaded(ultimateQaHomePageTitle), 
            $"{ErrorConstants.UltimateQaHomePageError} Expected: {ultimateQaHomePageTitle} Actual: {Driver.Title}");
    }
}
