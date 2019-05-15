using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningDayRow : MenuCyclesBasePage
    {
        IWebElement parent_DaysWrapper;

        public PlanningDayRow(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            this.parent_DaysWrapper = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".day-data__name > span")]
        private IWebElement DayName { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(2)")]
        private IWebElement dailyTotal_TotalCost { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(3)")]
        private IWebElement dailyTotal_Revenue { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(4)")]
        private IWebElement dailyTotal_Profit { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(5)")]
        private IWebElement dailyTotal_ActualGP { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data__row .day-data__columns-row")]
        private IList<IWebElement> DayMealPeriodsRows { get; set; }

        public IList<PlanningWeekMealPeriod> MealPeriodsRows => this.DayMealPeriodsRows.Select(p => new PlanningWeekMealPeriod(p, Driver)).ToList();

        public string NutritionDayName => DayName.Text;

        public string DailyTotalTotalCost => dailyTotal_TotalCost.Text;
        public string DailyTotalRevenue => dailyTotal_Revenue.Text;
        public string DailyTotalProfit => dailyTotal_Profit.Text;
        public string DailyTotalActualGP => dailyTotal_ActualGP.Text;

        public PlanningWeekMealPeriod GetMealPeriod(string name)
        {
            if (!MealPeriodsRows.Any(x => x.MealPeriodNameText == name))
            {
                throw new System.Exception($"Meal Period {name} not found !");
            }
            return MealPeriodsRows.First(x => x.MealPeriodNameText == name);
        }
    }
}