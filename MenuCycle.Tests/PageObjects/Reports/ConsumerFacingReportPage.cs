using System.Collections.Generic;
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

        [FindsBy(How = How.ClassName, Using = "report-consumer-facing__tariff-select")]
        private IWebElement PriceTypeDropDown { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".report-consumer-facing__price-options__include-price > label > span:first-of-type")]
        private IWebElement SellPriceCheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[name='calories'] + span")]
        private IWebElement CaloriesCheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input[name='kilojoules'] + span")]
        private IWebElement KilojoulesCheckBox { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".report-main-right_consumer-facing_date-from_date > input")]
        private IWebElement StartDate { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".report-main-right_consumer-facing_date-to_date > input")]
        private IWebElement EndDate { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text() = 'Export CSV']")]
        private IWebElement ExportCsvButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text() = 'Export PDF']")]
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