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
        private BasePage TestHomePage { get; set; }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint1 successfully using valid data.")]
        [TestProperty("Author", "Alice")]
        public void Test1Sprint1()
        {
            var sprint1PageActions = new Sprint1PageActions(Driver);
            var sprint1PageHelper = new Sprint1Page(Driver);
            GotoSampleApplicationPage(sprint1PageHelper, PageConstants.Sprint1Url, PageConstants.Sprint1Title);
            TestHomePage = sprint1PageActions.FillOutFormAndSubmit(UserConstants.DefaultFirstName);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        [TestMethod]
        [Description("Validate that user is able to fill out the form of Sprint1 successfully using alternate method.")]
        [TestProperty("Author", "Alice")]
        public void Test2Sprint1Refactor()
        {
            var sprint1PageActions = new Sprint1PageActions(Driver);
            var sprint1PageHelper = new Sprint1Page(Driver);
            GotoSampleApplicationPage(sprint1PageHelper, PageConstants.Sprint1Url, PageConstants.Sprint1Title);
            TestHomePage = sprint1PageActions.FillOutFormAndSubmit(TestUser.FirstName);
            ValidatePageTitle(TestHomePage, PageConstants.UltimateQaHomePageTitle);
        }

        private void GotoSampleApplicationPage(BasePage sprint1Page, string url, string title)
        {
            sprint1Page.GoTo(url);
            Assert.IsTrue(sprint1Page.IsLoaded(title), $"{ErrorConstants.SampleApplicationPageError} Expected: {title} Actual: {Driver.Title}");
        }

        private void ValidatePageTitle(BasePage homePage, string ultimateQaHomePageTitle) => Assert.IsTrue(homePage.IsLoaded(ultimateQaHomePageTitle), 
            $"{ErrorConstants.UltimateQaHomePageError} Expected: {ultimateQaHomePageTitle} Actual: {Driver.Title}");
    }
}