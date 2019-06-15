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
            var sprint2Page = new Sprint2Page(Driver);
            GotoSampleApplicationPage(sprint2Page, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
            sprint2PageActions.FillOutFormAndSubmit(UserConstants.DefaultFirstName, UserConstants.DefaultLastName);
            ValidatePageTitle(sprint2Page, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint2 successfully using alternate method with User.")]
        [TestProperty("Author", "Bob")]
        public void Test4Sprint2Refactor()
        {
            var sprint2PageActions = new Sprint2PageActions(Driver);
            var sprint2Page = new Sprint2Page(Driver);
            GotoSampleApplicationPage(sprint2Page, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
            sprint2PageActions.FillOutFormAndSubmit(TestUser.FirstName, TestUser.LastName);
            ValidatePageTitle(sprint2Page, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint2 successfully using valid data.")]
        [TestProperty("Author", "Bob")]
        public void Test5Sprint2Refactor2()
        {
            var sprint2PageActions = new Sprint2PageActions(Driver);
            var sprint2Page = new Sprint2Page(Driver);
            GotoSampleApplicationPage(sprint2Page, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
            sprint2PageActions.FillOutFormAndSubmit(TestUser);
            ValidatePageTitle(sprint2Page, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint2 successfully using alternate locators.")]
        [TestProperty("Author", "Bob")]
        public void Test6Sprint2Alternate()
        {
            var sprint2PageActions = new Sprint2PageActions(Driver);
            var sprint2Page = new Sprint2Page(Driver);
            GotoSampleApplicationPage(sprint2Page, PageConstants.Sprint2Url, PageConstants.Sprint2Title);
            sprint2PageActions.FillOutFormAndSubmitAlternate(TestUser);
            ValidatePageTitle(sprint2Page, PageConstants.UltimateQaHomePageTitle);
        }

        private void GotoSampleApplicationPage(BasePage basePage, string url, string title)
        {
            basePage.GoTo(url);
            Assert.IsTrue(basePage.IsLoaded(title), $"{ErrorConstants.SampleApplicationPageError} Expected: {title} Actual: {Driver.Title}");
        }

        private void ValidatePageTitle(BasePage basePage, string ultimateQaHomePageTitle) => Assert.IsTrue(basePage.IsLoaded(ultimateQaHomePageTitle), 
            $"{ErrorConstants.UltimateQaHomePageError} Expected: {ultimateQaHomePageTitle} Actual: {Driver.Title}");
    }
}