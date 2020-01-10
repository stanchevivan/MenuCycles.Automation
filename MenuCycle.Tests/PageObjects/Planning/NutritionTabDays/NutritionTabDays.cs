using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionTabDays : PlanningView
    {
        public NutritionTabDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".main > div")]
        private IList<IWebElement> MealPeriodWrappers { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()='Weeks']")]
        private IWebElement WeeklyViewButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".icon-stats-bars")]
        private IWebElement MenuCycleTotal { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement dailyTotal_PlannedQty { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement dailyTotal_EnergyKJ { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(4) > span:last-of-type")]
        private IWebElement dailyTotal_EnergyKCAL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(5) > span:last-of-type")]
        private IWebElement dailyTotal_Fat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(6) > span:last-of-type")]
        private IWebElement dailyTotal_SaturatedFat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(7) > span:last-of-type")]
        private IWebElement dailyTotal_Sugar { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(8) > span:last-of-type")]
        private IWebElement dailyTotal_Salt { get; set; }
        //[FindsBy(How = How.XPath, Using = "//span[contains(text(), 'MENU CYCLE TOTAL')]")]
        //private IWebElement MCTotalPage { get; set; }

        public IList<DailyMealPeriodNutrition> MealPeriods => this.MealPeriodWrappers.Select(p => new DailyMealPeriodNutrition(p, Driver)).ToList();


        public bool AreAllMealPeriodsExpanded => MealPeriods.All(period => period.IsExpanded);
        public bool AreAllMealPeriodsCollapsed => MealPeriods.All(period => !period.IsExpanded);
        public bool IsNumberOfCoversHiddenForAllMealPeriods => MealPeriods.All(cover => cover.IsNumberOfCoversPresent);

        public string DailyPlannedQtyTotal => dailyTotal_PlannedQty.Text;
        public string DailyEnergyKJTotal => dailyTotal_EnergyKJ.Text;
        public string DailyEnergyKCALTotal => dailyTotal_EnergyKCAL.Text;
        public string DailyFatTotal => dailyTotal_Fat.Text;
        public string DailySaturatedFatTotal => dailyTotal_SaturatedFat.Text;
        public string DailySugarTotal => dailyTotal_Sugar.Text;
        public string DailySaltTotal => dailyTotal_Salt.Text;

        public DailyMealPeriodNutrition GetMealPeriod(string name)
        {
            if (!MealPeriods.Any(x => x.Name == name.ToUpper()))
            {
                throw new System.Exception($"Meal period {name} not found !");
            }
            return MealPeriods.First(x => x.Name == name.ToUpper());
        }

        public void ClickWeeklyViewButton()
        {
            WeeklyViewButton.Click();
        }

        public void ClickMCTotalButton()
        {
            MenuCycleTotal.Click();
        }

    }
}
