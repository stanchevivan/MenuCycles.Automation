using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionWeekMealPeriod : MenuCyclesBasePage
    {
        public NutritionWeekMealPeriod(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(2)")]
        private IWebElement mealPeriod_energyKJ { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(3)")]
        private IWebElement mealPeriod_EnergyKCAL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(4)")]
        private IWebElement mealPeriod_Fat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(5)")]
        private IWebElement mealPeriod_SaturatedFat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(6)")]
        private IWebElement mealPeriod_Sugar { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".day-data__columns-row > div:nth-of-type(7)")]
        private IWebElement mealPeriod_Salt { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data__data-radius > span")]
        private IWebElement MealPeriodName { get; set; }

        public string Name => MealPeriodName.Text;

        public string MealPeriodEnergyKJTotal => mealPeriod_energyKJ.Text;
        public string MealPeriodEnergyKCALTotal => mealPeriod_EnergyKCAL.Text;
        public string MealPeriodFatTotal => mealPeriod_Fat.Text;
        public string MealPeriodSaturatedFatTotal => mealPeriod_SaturatedFat.Text;
        public string MealPeriodSugarTotal => mealPeriod_Sugar.Text;
        public string MealPeriodSaltTotal => mealPeriod_Salt.Text;

    }
}