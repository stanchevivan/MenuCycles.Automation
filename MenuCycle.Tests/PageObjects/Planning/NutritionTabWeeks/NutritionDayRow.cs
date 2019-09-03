using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Reporting;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionDayRow : MenuCyclesBasePage
    {
        IWebElement parent_DaysWrapper;
        private readonly IArtefacts Artefacts;

        public NutritionDayRow(IWebElement parent, IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            this.parent_DaysWrapper = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".day-data__name > span")]
        private IWebElement DayName { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(2)")]
        private IWebElement dailyTotal_energyKJ { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(3)")]
        private IWebElement dailyTotal_EnergyKCAL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(4)")]
        private IWebElement dailyTotal_Fat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(5)")]
        private IWebElement dailyTotal_SaturatedFat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(6)")]
        private IWebElement dailyTotal_Sugar { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".table-section-total__column:nth-of-type(7)")]
        private IWebElement dailyTotal_Salt { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data__row .day-data__columns-row")]
        private IList<IWebElement> DayMealPeriodsRows { get; set; }

        public IList<NutritionWeekMealPeriod> MealPeriodsRows => this.DayMealPeriodsRows.Select(p => new NutritionWeekMealPeriod(p, Driver, Artefacts)).ToList();

        public string NutritionDayName => DayName.Text;

        public string DailyTotalEnergyKJ => dailyTotal_energyKJ.Text;
        public string DailyTotalEnergyKCAL => dailyTotal_EnergyKCAL.Text;
        public string DailyTotalFat => dailyTotal_Fat.Text;
        public string DailyTotalSaturatedFat => dailyTotal_SaturatedFat.Text;
        public string DailyTotalSugar => dailyTotal_Sugar.Text;
        public string DailyTotalSalt => dailyTotal_Salt.Text;

        public NutritionWeekMealPeriod GetMealPeriod(string name)
        {
            if (!MealPeriodsRows.Any(x => x.Name == name))
            {
                throw new System.Exception($"Meal Period {name} not found !");
            }
            return MealPeriodsRows.First(x => x.Name == name);
        }
    }
}