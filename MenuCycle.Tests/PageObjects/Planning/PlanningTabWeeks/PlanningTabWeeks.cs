using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningTabWeeks : PlanningView
    {
        public PlanningTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement weeklyTotal_TotalCost { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(2) > span:last-of-type")]
        private IWebElement weeklyTotal_Revenue { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement weeklyTotal_Profit { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(4) > span:last-of-type")]
        private IWebElement weeklyTotal_ActualGP { get; set; }

        public string WeeklyTotalCostText => weeklyTotal_TotalCost.Text;
        public string WeeklyRevenueText => weeklyTotal_Revenue.Text;
        public string WeeklyProfitText => weeklyTotal_Profit.Text;
        public string WeeklyActualGPText => weeklyTotal_ActualGP.Text;
    }
}