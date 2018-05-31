using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningView : MenuCyclesBasePage
    {
        public PlanningView(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".mainheader__period > span:first-of-type")]
        IWebElement HeaderDayText { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Planning']")] // Old MC
        [FindsBy(How = How.XPath, Using = "//button[text()='Nutrition']")] // Engine
        IWebElement NutritionTabButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Planning']")] // Old Menu Cycles
        [FindsBy(How = How.XPath, Using = "//button[text()='Planning']")] // Engine
        IWebElement PlanningTabButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".footer__controls > button:last-of-type")]
        IWebElement SaveButton { get; set; }
        [FindsBy(How = How.TagName, Using = "body")]
        IWebElement Body { get; set; }
        [FindsBy(How = How.ClassName, Using = "mainheader__close-icon")]
        IWebElement HeaderCrossButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiodLoader")]
        IWebElement Loader { get; set; }
        [FindsBy(How = How.ClassName, Using = "daily-week-add-group")]
        IWebElement DailyWeekAddGroup { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".footer__controls > button:first-of-type")]
        IWebElement CancelButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]
        public IWebElement ToastMessage { get; set; }

        public string HeaderText => HeaderDayText.Text;

        public bool IsPlanningTabOpen => PlanningTabButton.Get().HasAttribute("subheader__tab-btn-active");

        public void FocusOut()
        {
            Body.SendKeys(Keys.Tab);
        }

        public virtual void WaitForLoad()
        {
            new PlanningTabDays(Driver).WaitForLoad();
        }

        public virtual void WaitForLoader()
        {
            Driver.WaitElementToDisappear(Loader);
        }

        public void OpenDailyNutritionTab()
        {
            NutritionTabButton.Click();
        }

        public void OpenDailyPlanningTab()
        {
            PlanningTabButton.Click();
        }

        public void UseSavebutton()
        {
            SaveButton.Click();
        }

        public void UseCrossButton()
        {
            HeaderCrossButton.Click();
        }

        public void UseCancelButton()
        {
            CancelButton.Click();
        }
    }
}