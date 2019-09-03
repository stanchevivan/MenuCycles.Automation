using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PostProductionTabWeeks : MenuCyclesBasePage
    {
        private readonly IArtefacts Artefacts;
        public PostProductionTabWeeks(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(2) > span:last-of-type")]
        private IWebElement weeklyTotal_QtyReqd { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement weeklyTotal_QtyProd { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(4) > span:last-of-type")]
        private IWebElement weeklyTotal_QtySold { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(5) > span:last-of-type")]
        private IWebElement weeklyTotal_NoChargeApplied { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(6) > span:last-of-type")]
        private IWebElement weeklyTotal_ReturnToStock { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(7) > span:last-of-type")]
        private IWebElement weeklyTotal_Wastage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".day-data")]
        private IList<IWebElement> DaysWrapper { get; set; }

        public string WeeklyTotalQtyReqd => weeklyTotal_QtyReqd.Text;
        public string WeeklyTotalQtyProd => weeklyTotal_QtyProd.Text;
        public string WeeklyTotalQtySold => weeklyTotal_QtySold.Text;
        public string WeeklyTotalNoChargeApplied => weeklyTotal_NoChargeApplied.Text;
        public string WeeklyTotalReturnToStock => weeklyTotal_ReturnToStock.Text;
        public string WeeklyTotalWastage => weeklyTotal_Wastage.Text;

        public IList<PostProductionDayRow> Days => this.DaysWrapper.Select(p => new PostProductionDayRow(p, Driver, Artefacts)).ToList();


        public PostProductionDayRow GetDay(string name)
        {
            if (!Days.Any(x => x.PostProductionDayName == name.ToUpper()))
            {
                throw new System.Exception($"Day {name} not found !");
            }
            return Days.First(x => x.PostProductionDayName == name.ToUpper());
        }
    }
}