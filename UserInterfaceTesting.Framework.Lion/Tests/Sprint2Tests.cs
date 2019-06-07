using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInterfaceTesting.Framework.Lion.Constants;
using UserInterfaceTesting.Framework.Lion.PageActions;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.Tests
{
    [TestClass]
    [TestCategory("Sprint2Tests")]
    public class Sprint2Tests : BaseTests
    {
        private BasePage TestHomePage { get; set; }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint2 successfully using alternate method.")]
        [TestProperty("Author", "Bob")]
        public void Test3Sprint2()
        {
            var sprint2PageActions = new Sprint2PageActions(Driver);
            var sprint2PageHelper = new Sprint2Page(Driver);
            GotoSampleApplicationPage(sprint2PageHelper, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
            TestHomePage = sprint2PageActions.FillOutFormAndSubmit(UserConstants.DefaultFirstName, UserConstants.DefaultLastName);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint2 successfully using alternate method with User.")]
        [TestProperty("Author", "Bob")]
        public void Test4Sprint2Refactor()
        {
            var sprint2PageActions = new Sprint2PageActions(Driver);
            var sprint2PageHelper = new Sprint2Page(Driver);
            GotoSampleApplicationPage(sprint2PageHelper, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
            TestHomePage = sprint2PageActions.FillOutFormAndSubmit(TestUser.FirstName, TestUser.LastName);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint2 successfully using valid data.")]
        [TestProperty("Author", "Bob")]
        public void Test5Sprint2Refactor2()
        {
            var sprint2PageActions = new Sprint2PageActions(Driver);
            var sprint2PageHelper = new Sprint2Page(Driver);
            GotoSampleApplicationPage(sprint2PageHelper, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
            TestHomePage = sprint2PageActions.FillOutFormAndSubmit(TestUser);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint2 successfully using alternate locators.")]
        [TestProperty("Author", "Bob")]
        public void Test6Sprint2Alternate()
        {
            var sprint2PageActions = new Sprint2PageActions(Driver);
            var sprint2PageHelper = new Sprint2Page(Driver);
            GotoSampleApplicationPage(sprint2PageHelper, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
            TestHomePage = sprint2PageActions.FillOutFormAndSubmitAlternate(TestUser);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        private void GotoSampleApplicationPage(BasePage sprint2Page, string url, string title)
        {
            sprint2Page.GoTo(url);
            Assert.IsTrue(sprint2Page.IsLoaded(title), $"{ErrorConstants.SampleApplicationPageError} Expected: {title} Actual: {Driver.Title}");
        }

        private void ValidatePageTitle(BasePage homePage, string ultimateQaHomePageTitle) => Assert.IsTrue(homePage.IsLoaded(ultimateQaHomePageTitle), 
            $"{ErrorConstants.UltimateQaHomePageError} Expected: {ultimateQaHomePageTitle} Actual: {Driver.Title}");
    }
}