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
        private IWebElement NutritionTabButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Planning']")] // Old Menu Cycles
        [FindsBy(How = How.XPath, Using = "//button[text()='Planning']")] // Engine
        private IWebElement PlanningTabButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "mealperiodLoader")]
        private IWebElement Loader { get; set; }

        public virtual void WaitForLoad()
        {
            new PlanningTabDays(Driver).WaitForLoad();
        }

        public virtual void WaitForLoader()
        {
            Driver.WaitElementToDisappear(Loader);
        }

        public string GetHeaderText()
        {
            return HeaderDayText.Text;
        }

        public void OpenDailyNutritionTab()
        {
            NutritionTabButton.Click();
        }

        public void OpenDailyPlanningTab()
        {
            PlanningTabButton.Click();
        }
    }
}