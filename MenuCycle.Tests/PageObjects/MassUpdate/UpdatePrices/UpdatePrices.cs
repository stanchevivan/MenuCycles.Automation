using System;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.MassUpdate
{
    public class UpdatePrices: MenuCyclesBasePage
    {
        public UpdatePrices(IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".btn-cancel")]
        private IWebElement CancelButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn-apply")]
        private IWebElement ApplyButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".update-prices-toolbar__toolbar-button")]
        private IWebElement AddTypesButton { get; set; }

    }
}