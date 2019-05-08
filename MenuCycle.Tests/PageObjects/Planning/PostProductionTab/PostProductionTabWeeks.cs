using System.Collections.Generic;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PostProductionTabWeeks : PlanningView
    {
        public PostProductionTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement weeklyTotal_QtyReqd { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(2) > span:last-of-typey")]
        private IWebElement weeklyTotal_QtyProd { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement weeklyTotal_QtySold { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(4) > span:last-of-type")]
        private IWebElement weeklyTotal_NoChargeApplied { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(5) > span:last-of-type")]
        private IWebElement weeklyTotal_ReturnToStock { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(6) > span:last-of-type")]
        private IWebElement weeklyTotal_Wastage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".main > .week-data")]
        private IList<IWebElement> DayWrappers { get; set; }

        public string QtyReqdTotal => weeklyTotal_QtyReqd.Text;
        public string QtyProdTotal => weeklyTotal_QtyProd.Text;
        public string QtySoldTotal => weeklyTotal_QtySold.Text;
        public string NoChargeAppliedTotal => weeklyTotal_NoChargeApplied.Text;
        public string ReturnToStockTotal => weeklyTotal_ReturnToStock.Text;
        public string WastageTotal => weeklyTotal_Wastage.Text;
    }
}