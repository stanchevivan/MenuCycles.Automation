using System;
using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class UpdatePrices: MenuCyclesBasePage
    {
        public UpdatePrices(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".btn-cancel")]
        private IWebElement CancelButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".btn-apply")]
        private IWebElement ApplyButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".update-prices-toolbar__toolbar-button")]
        private IWebElement AddTypesButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".update-prices-container__wrapper")]
        private IWebElement UpdatePricesContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".update-prices-card")]
        private IList<IWebElement> UpdatePricesRows { get; set; }

        public IList<UpdatePricesRow> Rows => UpdatePricesRows.Select(p => new UpdatePricesRow(p, Driver)).ToList();

        public void WaitUpdatePricesToBeVisible()
        {
            Driver.WaitIsClickable(ApplyButton);
        }

        public UpdatePricesRow GetRowByTariff(string tariffType)
        {
            return Rows.First(x => x.TariffType.ToUpper() == tariffType.ToUpper());
        }

        public void SelectApplyButton()
        {
            ApplyButton.Click();
        }

        public void SelectCancelButton()
        {
            CancelButton.Click();
        }

        public void SelectAddTypesButton()
        {
            AddTypesButton.Click();
        }

        }
}