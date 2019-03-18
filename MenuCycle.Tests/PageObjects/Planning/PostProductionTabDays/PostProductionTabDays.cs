using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PostProductionTabDays : PlanningView
    {
        public PostProductionTabDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".subheader__tab-btn-active.disabled")]
        private IWebElement PostProductionNavTabs { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement dailyTotal_PlannedQty { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(2) > span:last-of-type")]
        private IWebElement dailyTotal_QtyReqd { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(3) > span:last-of-typey")]
        private IWebElement dailyTotal_QtyProd { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(4) > span:last-of-type")]
        private IWebElement dailyTotal_QtySold { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(5) > span:last-of-type")]
        private IWebElement dailyTotal_NoChargeApplied { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(6) > span:last-of-type")]
        private IWebElement dailyTotal_ReturnToStock { get; set; }
        [FindsBy(How = How.ClassName, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(7) > span:last-of-type")]
        private IWebElement dailyTotal_Wastage { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()='Weeks']")]
        private IWebElement WeeklyViewButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".icon-printer")]
        private IWebElement LocalSalesReportButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".main > div")]
        private IList<IWebElement> MealPeriodWrappers { get; set; }

        public IList<DailyMealPeriodPostProduction> MealPeriods => this.MealPeriodWrappers.Select(p => new DailyMealPeriodPostProduction(p, Driver)).ToList();

        public string PlannedQtyTotal => dailyTotal_PlannedQty.Text;
        public string QtyReqdTotal => dailyTotal_QtyReqd.Text;
        public string QtyProdTotal => dailyTotal_QtyProd.Text;
        public string QtySoldTotal => dailyTotal_QtySold.Text;
        public string NoChargeAppliedTotal => dailyTotal_NoChargeApplied.Text;
        public string ReturnToStockTotal => dailyTotal_ReturnToStock.Text;
        public string WastageTotal => dailyTotal_Wastage.Text;

        public bool AreAllMealPeriodsExpanded => MealPeriods.All(period => period.IsExpanded);
        public bool AreAllMealPeriodsCollapsed => MealPeriods.All(period => !period.IsExpanded);

        public DailyMealPeriodPostProduction GetMealPeriod(string mealPeriodName)
        {
            return MealPeriods.First(x => x.Name == mealPeriodName);
        }

        public void UseWeeksButton()
        {
            WeeklyViewButton.Click();
        }

        public void UseExportLocalSalesReportButton()
        {
            LocalSalesReportButton.Click();
        }
    }
}