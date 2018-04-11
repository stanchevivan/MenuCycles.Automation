using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCyclePlanningView : BasePage
    {
        public MenuCyclePlanningView(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = "total-bottom__title")]
        private IWebElement DailyTotalLabel { get; set; }
        [FindsBy(How = How.ClassName, Using = "header-navigation__day-and-week")]
        private IWebElement HeaderDayAndWeekText { get; set; }

        public void WaitPageToLoad()
        {
            Driver.WaitElementToExists(DailyTotalLabel);
        }

        public string GetHeaderText()
        {
            return HeaderDayAndWeekText.Text;
        }
    }
}