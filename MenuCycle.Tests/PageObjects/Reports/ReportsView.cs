using Fourth.Automation.Framework.Extension;using OpenQA.Selenium;using OpenQA.Selenium.Support.PageObjects;namespace MenuCycle.Tests.PageObjects{    public class ReportsView : MenuCyclesBasePage    {        public ReportsView(IWebDriver webDriver) : base(webDriver)        {        }        [FindsBy(How = How.ClassName, Using = "reports-main-right")]        private IWebElement RightSection { get; set; }        public bool IsPageLoaded => RightSection.Displayed;        public void WaitForLoad()
        {
            Driver.WaitElementToExists(RightSection);
        }    }}