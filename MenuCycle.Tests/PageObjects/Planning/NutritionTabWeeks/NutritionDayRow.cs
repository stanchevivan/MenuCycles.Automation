using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionDayRow : MenuCyclesBasePage
    {
        IWebElement parent_DaysWrapper;

        public NutritionDayRow(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            this.parent_DaysWrapper = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".day-data__name > span")]
        private IWebElement DayName { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(2)")]
        private IWebElement weekTotal_energyKJ { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(3)")]
        private IWebElement weekTotal_EnergyKCAL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(4)")]
        private IWebElement weekTotal_Fat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(5)")]
        private IWebElement weekTotal_SaturatedFat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(6)")]
        private IWebElement weekTotal_Sugar { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(7)")]
        private IWebElement weekTotal_Salt { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data__row .day-data__columns-row")]
        private IList<IWebElement> DayMealPeriodsRows { get; set; }

        public IList<NutritionWeekMealPeriod> MealPeriodsRows => this.DayMealPeriodsRows.Select(p => new NutritionWeekMealPeriod(p, Driver)).ToList();

        public string NutritionDayName => DayName.Text;

        public string WeeklyEnergyKJTotal => weekTotal_energyKJ.Text;
        public string WeeklyEnergyKCALTotal => weekTotal_EnergyKCAL.Text;
        public string WeeklyFatTotal => weekTotal_Fat.Text;
        public string WeeklySaturatedFatTotal => weekTotal_SaturatedFat.Text;
        public string WeeklySugarTotal => weekTotal_Sugar.Text;
        public string WeeklySaltTotal => weekTotal_Salt.Text;

        public NutritionWeekMealPeriod GetMealPeriod(string name)
        {
            if (!MealPeriodsRows.Any(x => x.MealPeriodNameText == name.ToUpper()))
            {
                throw new System.Exception($"Meal Period {name} not found !");
            }
            return MealPeriodsRows.First(x => x.MealPeriodNameText == name.ToUpper());
        }
    }
}