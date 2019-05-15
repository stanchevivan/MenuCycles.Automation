using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningWeekMealPeriod : MenuCyclesBasePage
    {
        public PlanningWeekMealPeriod(IWebElement parent, IWebDriver webDriver) : base(webDriver)
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

        public string MealPeriodNameText => MealPeriodName.Text;

        public string MealPeriodTotalCost => mealPeriod_TotalCost.Text;
        public string MealPeriodRevenue => mealPeriod_Revenue.Text;
        public string MealPeriodProfit => mealPeriod_Profit.Text;
        public string MealPeriodActualGP => mealPeriod_ActualGP.Text;

    }
}