using Fourth.Automation.Framework.Extension;using OpenQA.Selenium;using OpenQA.Selenium.Support.PageObjects;namespace MenuCycle.Tests.PageObjects{    public class PlanningView : MenuCyclesBasePage    {        public PlanningView(IWebDriver webDriver) : base(webDriver)        {        }        [FindsBy(How = How.CssSelector, Using = ".mainheader__period > span:first-of-type")]        private IWebElement HeaderDayText { get; set; }        [FindsBy(How = How.XPath, Using = "//div[text()='Nutrition']")] // Old MC
        [FindsBy(How = How.XPath, Using = "//button[text()='Nutrition']")] // Engine
        private IWebElement NutritionTabButton { get; set; }        [FindsBy(How = How.XPath, Using = "//div[text()='Planning']")] // Old Menu Cycles
        [FindsBy(How = How.XPath, Using = "//button[text()='Planning']")] // Engine
        private IWebElement PlanningTabButton { get; set; }        [FindsBy(How = How.XPath, Using = "//div[text()='Post-Production']")] // Old Menu Cycles
        [FindsBy(How = How.XPath, Using = "//button[text()='Post-Production']")] // Engine
        private IWebElement PostProductionTabButton { get; set; }        [FindsBy(How = How.CssSelector, Using = ".footer__controls > button:last-of-type")]        private IWebElement SaveButton { get; set; }        [FindsBy(How = How.TagName, Using = "body")]        private IWebElement Body { get; set; }        [FindsBy(How = How.ClassName, Using = "mainheader__close-icon")]        private IWebElement HeaderCrossButton { get; set; }        [FindsBy(How = How.ClassName, Using = "loading")]        private IWebElement Loader { get; set; }        [FindsBy(How = How.ClassName, Using = "daily-week-add-group")]        private IWebElement DailyWeekAddGroup { get; set; }        [FindsBy(How = How.CssSelector, Using = ".footer__controls > button:first-of-type")]        private IWebElement CancelButton { get; set; }        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]        private IWebElement ToastMessage { get; set; }        [FindsBy(How = How.ClassName, Using = "no-mealperiods-error")]        private IWebElement MealPeriodMessage { get; set; }        [FindsBy(How = How.ClassName, Using = "modal-backdrop")]        private IWebElement ModalBackdrop { get; set; }
        [FindsBy(How = How.ClassName, Using = "main")]        private IWebElement PageContent { get; set; }        public string HeaderText => HeaderDayText.Text;        public string MealPeriodErrorMessage => MealPeriodMessage.Text;        public bool IsPlanningTabOpen => PlanningTabButton.Get().HasClass("subheader__tab-btn-active");        public void FocusOut()        {            Body.SendKeys(Keys.Tab);        }        public virtual void WaitForLoad()        {            Driver.WaitElementToExists(PageContent);            WaitForLoader();        }        public virtual void WaitForLoader()        {            Driver.WaitElementToDisappear(Loader);        }        public void WaitForBackdropToDisappear()        {            Driver.WaitElementToDisappear(ModalBackdrop);        }        public void OpenDailyNutritionTab()        {            NutritionTabButton.Click();        }        public void OpenPostProductionTab()        {            PostProductionTabButton.Click();        }        public void OpenDailyPlanningTab()        {            WaitForBackdropToDisappear();            PlanningTabButton.Click();        }        public void UseSavebutton()        {            SaveButton.Click();            Driver.WaitElementToDisappear(Loader);        }        public void UseCrossButton()        {            HeaderCrossButton.Click();        }        public void UseCancelButton()        {            CancelButton.Click();        }        public bool IsSaveButtonDisabled()        {            return SaveButton.Get().HasAttribute("disabled");        }    }}