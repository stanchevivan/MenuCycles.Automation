using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class FourthAppLocalPage : MenuCyclesBasePage
    {
        public FourthAppLocalPage(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "input[id *= username]")]
        private IWebElement UserName { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[type=password]")]
        private IWebElement Password { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[type=submit]")]
        private IWebElement SignInButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[2]")]
        [FindsBy(How = How.Id, Using = "No")]
        private IWebElement MessageNoButton { get; set; }
        [FindsBy(How = How.Id, Using = "applications-all-apps")]
        private IWebElement AllApplications { get; set; }

        public void WaitMainPageToLoad(IWebElement allApplicationsButton)
        {
            Driver.WaitIsClickable(allApplicationsButton);
        }

        public void ClickNoButton()
        {
            Driver.WaitElementAndClick(MessageNoButton);
            Driver.WaitElementToDisappear(MessageNoButton);
        }

        public void ScrollToAllApplications()
        {
            AllApplications.Do(Driver).ScrollIntoView();
        }
    }
}
