﻿using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionTabDays : DailyPlanningView
    {
        public NutritionTabDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = "nutrition-meal-period-content")]
        private IWebElement PageContent { get; set; }

        public new void WaitForLoad()
        {
            Driver.WaitElementToExists(PageContent);
        }
    }
}
