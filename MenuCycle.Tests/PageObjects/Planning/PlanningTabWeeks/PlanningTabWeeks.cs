using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningTabWeeks : PlanningView
    {
        private readonly IArtefacts Artefacts;
        public PlanningTabWeeks(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(2) > span:last-of-type")]
        private IWebElement weeklyTotal_TotalCost { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement weeklyTotal_Revenue { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(4) > span:last-of-type")]
        private IWebElement weeklyTotal_Profit { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(5) > span:last-of-type")]
        private IWebElement weeklyTotal_ActualGP { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data")]
        private IList<IWebElement> DaysWrapper { get; set; }

        public string WeeklyTotalCostText => weeklyTotal_TotalCost.Text;
        public string WeeklyRevenueText => weeklyTotal_Revenue.Text;
        public string WeeklyProfitText => weeklyTotal_Profit.Text;
        public string WeeklyActualGPText => weeklyTotal_ActualGP.Text;

        public IList<PlanningDayRow> Days => this.DaysWrapper.Select(p => new PlanningDayRow(p, Driver, Artefacts)).ToList();


        public PlanningDayRow GetDay(string name)
        {
            if (!Days.Any(x => x.NutritionDayName == name.ToUpper()))
            {
                throw new System.Exception($"Day {name} not found !");
            }
            return Days.First(x => x.NutritionDayName == name.ToUpper());
        }
    }
}