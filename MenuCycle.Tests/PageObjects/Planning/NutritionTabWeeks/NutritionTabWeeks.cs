using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class NutritionTabWeeks : PlanningView
    {
        public NutritionTabWeeks(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".close-planning-page")]
        private IWebElement XButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".weekly-nutrition_content")]
        private IWebElement pageContent { get; set; }
        [FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
        private IWebElement SpinningWheel { get; set; }

        public void ClickXButton()
        {
            XButton.Click();
        }

        public override void WaitForLoad()
        {
            base.WaitForLoader();
            Driver.WaitElementToExists(pageContent);
            Driver.WaitElementToDisappear(SpinningWheel);
        }
    }
}
