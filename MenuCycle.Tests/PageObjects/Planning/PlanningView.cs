using Fourth.Automation.Framework.Extension;using OpenQA.Selenium;using OpenQA.Selenium.Support.PageObjects;namespace MenuCycle.Tests.PageObjects{    public class PlanningView : MenuCyclesBasePage    {        public PlanningView(IWebDriver webDriver) : base(webDriver)        {        }        [FindsBy(How = How.CssSelector, Using = ".mc-header__day")]        private IWebElement HeaderDayText { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Nutrition']")]
        private IWebElement NutritionTabButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(@href, 'planning')]")]
        private IWebElement PlanningTabButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Post-Production']")]
        private IWebElement PostProductionTabButton { get; set; }        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Save')]")]        private IWebElement SaveButton { get; set; }        [FindsBy(How = How.TagName, Using = "body")]        private IWebElement Body { get; set; }        [FindsBy(How = How.ClassName, Using = "close-reports-page")]        [FindsBy(How = How.ClassName, Using = "icon-cross")]        private IWebElement HeaderCrossButton { get; set; }        [FindsBy(How = How.ClassName, Using = "daily-week-add-group")]        private IWebElement DailyWeekAddGroup { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mc-footer__controls > button:first-of-type")]        [FindsBy(How = How.CssSelector, Using = ".review-cancel-button")]        private IWebElement CancelButton { get; set; }        [FindsBy(How = How.CssSelector, Using = "div[id='toast-container'] div[class='toast-message']")]        private IWebElement ToastMessage { get; set; }        [FindsBy(How = How.ClassName, Using = "no-mealperiods-error")]        private IWebElement MealPeriodMessage { get; set; }
        [FindsBy(How = How.ClassName, Using = "main")]        private IWebElement PageContent { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Days']")]        private IWebElement DaysButton { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Weeks']")]        private IWebElement WeeksButton { get; set; }        public string HeaderText => HeaderDayText.Text;        public string MealPeriodErrorMessage => MealPeriodMessage.Text;        public bool IsPlanningTabOpen => PlanningTabButton.Get().HasClass("active");        public bool IsPageLoaded => PageContent.Exist();        public bool IsSaveButtonPresent => SaveButton.Get().ElementPresent;        public void FocusOut()        {            Body.SendKeys(Keys.Tab);        }        public virtual void WaitForLoad()        {            Driver.WaitElementToExists(PageContent);            WaitSpinnerToDisappear();        }        public void OpenNutritionTab()        {            NutritionTabButton.Click();        }        public void OpenPostProductionTab()        {            PostProductionTabButton.Click();        }        public void OpenDailyPlanningTab()        {            WaitSpinnerToDisappear();            PlanningTabButton.Click();        }        public void UseSavebutton()        {            SaveButton.Click();            WaitSpinnerToDisappear();        }        public void UseCrossButton()        {            HeaderCrossButton.Click();        }        public void UseCancelButton()        {            CancelButton.Click();        }        public bool IsSaveButtonDisabled()        {            return SaveButton.Get().HasAttribute("disabled");        }

        public void UseDaysButton()        {            DaysButton.Click();        }        public void UseWeeksButton()        {            WeeksButton.Click();        }    }}