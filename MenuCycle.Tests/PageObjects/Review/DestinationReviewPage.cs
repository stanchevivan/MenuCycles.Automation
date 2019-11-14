using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace MenuCycle.Tests.PageObjects
{
   public class DestinationReviewPage : MenuCyclesBasePage
    {
        public DestinationReviewPage(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".destination-review-page")]
        private IWebElement PageBody { get; set; }
        [FindsBy(How = How.Id, Using = "checkbox-all")]
        private IWebElement SelectAllCheckbox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".destination-run-btn")]
        private IWebElement RunButton { get; set; }
        [FindsBy(How = How.Id, Using = ".gap-check-report")]
        private IWebElement GapCheckReport { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".footer-btn-donе")]
        private IWebElement DoneButton { get; set; }

        public bool GapCheckReportIsLoaded => GapCheckReport.Displayed;

        public void WaitForLoad()
        {
            Driver.WaitElementToExists(PageBody);
        }

        public void WaitForGapCheckReportToLoad()
        {
            Driver.WaitElementToExists(GapCheckReport);
        }

        public void ClickSelectAllCheckbox()
        {
            SelectAllCheckbox.Click();
        }

        public void ClickRunButton()
        {
            Driver.WaitIsClickable(RunButton);
            RunButton.Click();
            WaitForGapCheckReportToLoad();
        }
    }
}
