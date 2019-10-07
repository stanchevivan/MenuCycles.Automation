using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningTabDays : PlanningView
    {
        public PlanningTabDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".main > div")]
        private IList<IWebElement> MealPeriodWrappers { get; set; }
        [FindsBy(How = How.ClassName, Using = "mc-header")] //Investigate if more suitable element for the check is needed
        private IWebElement EngineCheck { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Weeks']")] // Engine
        private IWebElement WeeksButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(1) > span:last-of-type")]
        private IWebElement DailyPlannedQuantity { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(3) > span:last-of-type")]
        private IWebElement DailyTotalCost { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(9) > span:last-of-type")]
        private IWebElement DailyRevenue { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".mealperiod-totals-footer__fixed .mealperiod-total__column:nth-of-type(10) > span:last-of-type")]
        private IWebElement DailyActualGP { get; set; }
        [FindsBy(How = How.ClassName, Using = "btn-confirm")]
        private IWebElement ConfirmButton { get; set; }
        [FindsBy(How = How.ClassName, Using = "modal-dialog-engine__content")]
        private IWebElement ModalDialog { get; set; }
        [FindsBy(How = How.ClassName, Using = "mainheader__period")]
        private IWebElement PlanningTitle { get; set; }
        [FindsBy(How = How.ClassName, Using = "mealperiod-main")]
        private IWebElement MealPeriodContent { get; set; }


        public IList<DailyMealPeriod> MealPeriods => this.MealPeriodWrappers.Select(p => new DailyMealPeriod(p, Driver)).ToList();
        public IList<string> MealPeriodColours => MealPeriods.Select(x => x.Colour).ToList();

        public bool HasMealPeriods => MealPeriods.Any();
        public bool AreAllMealPeriodsExpanded => MealPeriods.All(period => period.IsExpanded);
        public bool AreAllMealPeriodsCollapsed => MealPeriods.All(period => !period.IsExpanded);

        public string DailyPlanedQuanityText => DailyPlannedQuantity.Text;
        public string DailyTotalCostText => DailyTotalCost.Text;
        public string DailyRevenueText => DailyRevenue.Text;
        public string DailyActualGPText => DailyActualGP.Text;
        public string DailyPlanningTitleText => PlanningTitle.Text;

        public void SwitchToWeeklyView()
        {
            WeeksButton.Click();
        }

        public bool IsEngineLoaded()
        {
            return EngineCheck.Exist();
        }

        public void ExpandMealPeriod(string periodName)
        {
            GetMealPeriod(periodName).Expand();
        }

        public void CollapseMealPeriod(string periodName)
        {
            GetMealPeriod(periodName).Collapse();
        }

        public bool IsMealPeriodExpanded(string periodName)
        {
            return GetMealPeriod(periodName).IsExpanded;
        }

        //TODO Investigate combining GetMealPeriod for all screens
        public DailyMealPeriod GetMealPeriod(string name)
        {
            if (!MealPeriods.Any(x => x.Name == name.ToUpper()))
            {
                throw new System.Exception($"Meal period {name} not found !");
            }
            return MealPeriods.First(x => x.Name == name.ToUpper());
        }

        public void ConfirmDialog()
        {
            ConfirmButton.Click();
            Driver.WaitElementToDisappear(ModalDialog);
        }

        public void WaitMеаlPeriodsToAppear()
        {
            Driver.WaitIsClickable(MealPeriodContent);
        }

        public void WaitMеаlPeriodsToDisappear()
        {
            Driver.WaitElementToDisappear(MealPeriodContent);
        }
    }
}