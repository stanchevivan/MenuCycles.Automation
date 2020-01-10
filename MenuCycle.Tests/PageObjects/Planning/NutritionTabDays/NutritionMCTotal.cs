using System;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionMCTotal: MenuCyclesBasePage
    {
        public NutritionMCTotal(IWebDriver webDriver) : base(webDriver)
        {

        }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(), 'MENU CYCLE TOTAL')]")]
        private IWebElement MCTotalPage { get; set; }

            public void WaitToLoadMCTotal()
            {
                Driver.WaitElementToExists(MCTotalPage);
            }
    }
}
