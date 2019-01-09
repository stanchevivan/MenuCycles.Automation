﻿using System.Collections.Generic;
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
        [FindsBy(How = How.ClassName, Using = "daily-post-production-meal-period-summary_plannedqty_secondary")]
        private IWebElement dailyTotal_PlannedQty { get; set; }
        [FindsBy(How = How.ClassName, Using = "daily-post-production-meal-period-summary_qty_secondary")]
        private IWebElement dailyTotal_QtyReqd { get; set; }
        [FindsBy(How = How.ClassName, Using = "daily-post-production-meal-period-summary_prod_secondary")]
        private IWebElement dailyTotal_QtyProd { get; set; }
        [FindsBy(How = How.ClassName, Using = "daily-post-production-meal-period-summary_sold_secondary")]
        private IWebElement dailyTotal_QtySold { get; set; }
        [FindsBy(How = How.ClassName, Using = "daily-post-production-meal-period-summary_no_charge_secondary")]
        private IWebElement dailyTotal_NoChargeApplied { get; set; }
        [FindsBy(How = How.ClassName, Using = "daily-post-production-meal-period-summary_return_secondary")]
        private IWebElement dailyTotal_ReturnToStock { get; set; }
        [FindsBy(How = How.ClassName, Using = "daily-post-production-meal-period-wastage_secondary")]
        private IWebElement dailyTotal_Wastage { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".main > div")]
        private IList<IWebElement> MealPeriodWrappers { get; set; }

        public IList<DailyMealPeriodPostProduction> MealPeriods => this.MealPeriodWrappers.Select(p => new DailyMealPeriodPostProduction(p, Driver)).ToList();

        public string DailyTotal_PlannedQty => dailyTotal_PlannedQty.Text;
        public string DailyTotal_QtyReqd => dailyTotal_QtyReqd.Text;
        public string DailyTotal_QtyProd => dailyTotal_QtyProd.Text;
        public string DailyTotal_QtySold => dailyTotal_QtySold.Text;
        public string DailyTotal_NoChargeApplied => dailyTotal_NoChargeApplied.Text;
        public string DailyTotal_ReturnToStock => dailyTotal_ReturnToStock.Text;
        public string DailyTotal_Wastage => dailyTotal_Wastage.Text;

        public bool AreAllMealPeriodsExpanded => MealPeriods.All(period => period.IsExpanded);
        public bool AreAllMealPeriodsCollapsed => MealPeriods.All(period => !period.IsExpanded);

        public override void WaitForLoad()
        {
            Driver.WaitElementToExists(PostProductionNavTabs);
            base.WaitForLoader();
        }

        public DailyMealPeriodPostProduction GetMealPeriod(string mealPeriodName)
        {
            return MealPeriods.First(x => x.Name == mealPeriodName);
        }
    }
}