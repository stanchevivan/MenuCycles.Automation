using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionTabWeeks : PlanningView
    {
        public NutritionTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.XPath, Using = "//button[text()='Weeks']")]
        private IWebElement WeeklyViewButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement weeklyTotal_EnergyKJ { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(2) > span:last-of-type")]
        private IWebElement weeklyTotal_EnergyKCAL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement weeklyTotal_Fat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(4) > span:last-of-type")]
        private IWebElement weeklyTotal_SaturatedFat { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(5) > span:last-of-type")]
        private IWebElement weeklyTotal_Sugar { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(6) > span:last-of-type")]
        private IWebElement weeklyTotal_Salt { get; set; }

        public string WeeklyEnergyKJTotal => weeklyTotal_EnergyKJ.Text;
        public string WeeklyEnergyKCALTotal => weeklyTotal_EnergyKCAL.Text;
        public string WeeklyFatTotal => weeklyTotal_Fat.Text;
        public string WeeklySaturatedFatTotal => weeklyTotal_SaturatedFat.Text;
        public string WeeklySugarTotal => weeklyTotal_Sugar.Text;
        public string WeeklySaltTotal => weeklyTotal_Salt.Text;
    }
}
