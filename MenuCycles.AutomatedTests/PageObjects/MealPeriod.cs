using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class MealPeriod : BasePage
    {
        private readonly IArtefacts Artefacts;

        public MealPeriod(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-header-container .mealPeriodButtons")]
        public IWebElement MealPeriodSearchBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".custom-searchbox-options .clickable")]
        public IList<IWebElement> MealPeriodList { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".addRecipeBtnText")]
        public IWebElement AddRecipeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".addRecipeBtnText")]
        public IWebElement CloseSearch { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#slidingDiv .closeSlider")]
        public IWebElement CloseWindow { get; set; }

        [FindsBy(How = How.Id, Using = "saveBtn")]
        public IWebElement SaveButton { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHideMP")]
        public IWebElement SpinningWHeel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]
        public IWebElement ToastMessage { get; set; }
    }
}
