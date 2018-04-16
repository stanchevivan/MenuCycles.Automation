using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DailyPlanningView : BasePage
    {
        public DailyPlanningView(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".mainheader__period > span:first-of-type")]
        private IWebElement HeaderDayText { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()='Nutrition']")]
        private IWebElement NutritionTab { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Planning']")] // Old Menu Cycles
        [FindsBy(How = How.XPath, Using = "//button[text()='Planning']")] // Engine
        private IWebElement PlanningTab { get; set; }

        public void WaitForLoad()
        {
            Driver.WaitElementToExists(HeaderDayText);
        }

        public string GetHeaderText()
        {
            return HeaderDayText.Text;
        }

        public void OpenDailyNutritionTab()
        {
            NutritionTab.Click();
        }

        public void OpenDailyPlanningTab()
        {
            PlanningTab.Click();
        }
    }
}