using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class DailyCalendarSteps
    {
        readonly PlanningView dailyPlanningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleDailyCalendarView dailyCalendarView;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;
        readonly WeeklyCalendarView weeklyCalendarView;

        public DailyCalendarSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleDailyCalendarView menuCycleDailyCalendarView,
            RecipeSearch recipeSearch, ToastNotification notification,
                              ModalDialogPage modalDialogPage, WeeklyCalendarView weeklyCalendarView)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTabDays;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTabDays;
            this.dailyCalendarView = menuCycleDailyCalendarView;
            this.recipeSearch = recipeSearch;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;
            this.weeklyCalendarView = weeklyCalendarView;

            this.scenarioContext = scenarioContext;
        }

        [When(@"daily calendar view is switched")]
        public void WhenDailyCalendarViewIsSwitched()
        {
            dailyCalendarView.SwitchView();
        }

        [When(@"Verify day ""(.*)"" is visible")]
        [Then(@"Verify day ""(.*)"" is visible")]
        public void VerifyDayByNameIsVisible(string dayName)
        {
            Assert.IsTrue(dailyCalendarView.GetDay(dayName).IsVisible);
        }

        [When(@"Verify day ""(.*)"" is not visible")]
        [Then(@"Verify day ""(.*)"" is not visible")]
        public void VerifyDayByNameIsNotVisible(string dayName)
        {
            Assert.IsFalse(dailyCalendarView.GetDay(dayName).IsVisible);
        }
    }
}