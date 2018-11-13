using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MenuCycle.Tests.PageObjects
{
    public class ConsumerFacingReportPage : MenuCyclesBasePage
    {
        public ConsumerFacingReportPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = "report-main-right_consumer-facing_price_select")]
        private IWebElement PriceTypeDropDown { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sell-price > .squaredOne")]
        private IWebElement SellPriceCheckBox { get; set; }

        public bool IsPriceDropDownVisible => PriceTypeDropDown.Displayed;
        public bool IsPriceDropDownEnabled => PriceTypeDropDown.Enabled;
        public bool IsSellPriceSelected => SellPriceCheckBox.Selected;

        public void IncludeSellPrice()
        {
            if (!SellPriceCheckBox.Selected)
            {
                SellPriceCheckBox.Click();
            }
        }

        public void ExcludeSellPrice()
        {
            if (SellPriceCheckBox.Selected)
            {
                SellPriceCheckBox.Click();
            }
        }

        public void SelectPriceType(string priceType)
        {
            new SelectElement(SellPriceCheckBox).SelectByText(priceType);
        }

        public void WaitPageToLoad()
        {
            Driver.WaitIsClickable(SellPriceCheckBox);
        }
    }
}