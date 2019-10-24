using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects.MassUpdate
{
    public class UpdatePricesRow : MenuCyclesBasePage
    {
        public UpdatePricesRow (IWebElement parent, IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "select-type")]
        private IWebElement tariffType { get; set; }
        [FindsBy(How = How.ClassName, Using = "select-price-model")]
        private IWebElement priceModel { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".target .input__cell")]
        private IWebElement targetGP { get; set; }
        [FindsBy(How = How.ClassName, Using = "select-tax")]
        private IWebElement taxPercentage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sell-price > div > input")]
        [FindsBy(How = How.CssSelector, Using = ".sell-price > span")]
        private IWebElement sellPrice { get; set; }
    }
}
