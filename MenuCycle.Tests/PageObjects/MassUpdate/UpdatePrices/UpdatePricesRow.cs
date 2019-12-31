using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium.Support.UI;

namespace MenuCycle.Tests.PageObjects
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
        [FindsBy(How = How.ClassName, Using = "icon-bin")]
        private IWebElement deleteType { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sell-price .error-notification .error-content")]
        private IWebElement SellPriceContextualMessage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".target .error-notification .error-content")]
        private IWebElement TargetContextualMessage { get; set; }

        public string SellPriceContextualErrorMessage => SellPriceContextualMessage.Text;
        public string TargetPercentageContextualErrorMessage => TargetContextualMessage.Text;

        public bool IsSellPriceEditable => sellPrice.Enabled;
        public bool SellPriceHasRedBorder => sellPrice.Get().HasClass("border-error");
        public bool IsTargetGPWithRedBorder => targetGP.Get().HasClass("border-error");
        public bool IsDeleteIconPresent => deleteType.Get().ElementPresent;
        public bool IsTariffTypePresent => tariffType.Get().ElementPresent;

        public void DeleteType()
        {
            deleteType.Click();
        }

        public string TariffType
        {
            get => new SelectElement(this.tariffType).SelectedOption.Text.Trim();
            set => new SelectElement(this.tariffType).SelectByText(value);
        }

        public void SetSellPrice(string value)
        {
            sellPrice.Do(Driver).ClearAndSendKeys(value);
        }

        public void SetTargetGP(string value)
        {
            targetGP.Do(Driver).ClearAndSendKeys(value);
        }

        public string PriceModel
        {
            get => new SelectElement(this.priceModel).SelectedOption.Text.Trim();
            set => new SelectElement(this.priceModel).SelectByText(value);
        }

        public string TaxPercentage
        {
            get => new SelectElement(this.taxPercentage).SelectedOption.Text.Trim();
            set => new SelectElement(this.taxPercentage).SelectByText(value);
        }
    }
}
