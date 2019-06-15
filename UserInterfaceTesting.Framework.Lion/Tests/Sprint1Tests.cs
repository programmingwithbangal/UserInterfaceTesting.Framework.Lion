using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserInterfaceTesting.Framework.Lion.Constants;
using UserInterfaceTesting.Framework.Lion.PageActions;
using UserInterfaceTesting.Framework.Lion.Pages;

namespace UserInterfaceTesting.Framework.Lion.Tests
{
    [TestClass]
    [TestCategory("Sprint1Tests")]
    public class Sprint1Tests: BaseTests
    {
        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint1 successfully using valid data.")]
        [TestProperty("Author", "Alice")]
        public void Test1Sprint1()
        {
            var sprint1PageActions = new Sprint1PageActions(Driver);
            var sprint1Page = new Sprint1Page(Driver);
            GotoSampleApplicationPage(sprint1Page, PageConstants.Sprint1Url, PageConstants.Sprint1Title);
            sprint1PageActions.FillOutFormAndSubmit(UserConstants.DefaultFirstName);
            ValidatePageTitle(sprint1Page, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint1 successfully using alternate method.")]
        [TestProperty("Author", "Alice")]
        public void Test2Sprint1Refactor()
        {
            var sprint1PageActions = new Sprint1PageActions(Driver);
            var sprint1Page = new Sprint1Page(Driver);
            GotoSampleApplicationPage(sprint1Page, PageConstants.Sprint1Url, PageConstants.Sprint1Title);
            sprint1PageActions.FillOutFormAndSubmit(TestUser.FirstName);
            ValidatePageTitle(sprint1Page, PageConstants.UltimateQaHomePageTitle);
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