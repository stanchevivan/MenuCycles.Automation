using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningWeekMealPeriodRow : MenuCyclesBasePage
    {
        public PlanningWeekMealPeriodRow(IWebElement parent, IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(2)")]
        private IWebElement mealPeriod_TotalCost { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(3)")]
        private IWebElement mealPeriod_Revenue { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(4)")]
        private IWebElement mealPeriod_Profit { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(5)")]
        private IWebElement mealPeriod_ActualGP { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data__data-radius > span")]
        private IWebElement MealPeriodName { get; set; }

        public string Name => MealPeriodName.Text;

        public string TotalCost => mealPeriod_TotalCost.Text;
        public string Revenue => mealPeriod_Revenue.Text;
        public string Profit => mealPeriod_Profit.Text;
        public string ActualGP => mealPeriod_ActualGP.Text;

    }
}