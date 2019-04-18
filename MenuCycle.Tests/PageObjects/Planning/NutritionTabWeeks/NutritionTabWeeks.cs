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

        [FindsBy(How = How.CssSelector, Using = ".icon-cross")]
        private IWebElement XButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".main")]
        private IWebElement pageContent { get; set; }
        [FindsBy(How = How.Id, Using = "loading")]
        private IWebElement SpinningWheel { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()='Days']")]
        private IWebElement DaysButton { get; set; }

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
