using System.Collections.Generic;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Reporting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace MenuCycle.Tests.PageObjects
{
    public class ConsumerFacingReportPage : MenuCyclesBasePage
    {
        public ConsumerFacingReportPage(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver, artefacts)
        {
        }

        [FindsBy(How = How.ClassName, Using = "report-main-right_consumer-facing_price_select")]
        private IWebElement PriceTypeDropDown { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".sell-price > .squaredOne")]
        private IWebElement SellPriceCheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".calories > .squaredOne")]
        private IWebElement CaloriesCheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".kj > .squaredOne")]
        private IWebElement KilojoulesCheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".report-main-right_consumer-facing_date-from_date > input")]
        private IWebElement StartDate { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".report-main-right_consumer-facing_date-to_date > input")]
        private IWebElement EndDate { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='reports-main-right_consumer-facing']//div[contains(text(), 'Export CSV')]")]
        private IWebElement ExportCsvButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(text(), 'Export PDF')]")]
        private IWebElement ExportPdfButton { get; set; }

        public bool IsSellPriceSelected => SellPriceCheckBox.Selected;
        public bool IsPriceDropDownVisible => PriceTypeDropDown.Displayed;
        public bool IsPriceDropDownEnabled => PriceTypeDropDown.Get().HasAttribute("disabled");
        public bool IsExportCSVButonVisible => ExportCsvButton.Get().ElementPresent;
        public bool IsExportPDFButonVisible => ExportPdfButton.Get().ElementPresent;


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

        public void IncludeCalories()
        {
            if (!CaloriesCheckBox.Selected)
            {
                CaloriesCheckBox.Click();
            }
        }

        public void IncludeKilojoules()
        {
            if (!KilojoulesCheckBox.Selected)
            {
                KilojoulesCheckBox.Click();
            }
        }

        public void UseExportCsvButton()
        {
            ExportCsvButton.Click();
        }

        public void UseExportPdfButton()
        {
            ExportPdfButton.Click();
        }
    }
}