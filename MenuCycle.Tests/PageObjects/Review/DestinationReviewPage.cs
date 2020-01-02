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

        [FindsBy(How = How.CssSelector, Using = ".review-destinations")]
        private IWebElement PageBody { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".scrollable-list__controls .mc-checkbox__checkmark")]
        private IWebElement SelectAllCheckbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Run')]")]
        private IWebElement RunButton { get; set; }
        [FindsBy(How = How.Id, Using = "gap-check-report")]
        private IWebElement GapCheckReport { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Done')]")]
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
