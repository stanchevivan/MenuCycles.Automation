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
    public class WeeklyCalendar
    {
        readonly PlanningView dailyPlanningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;
        readonly WeeklyCalendarView weeklyCalendarView;

        public WeeklyCalendar(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleDailyCalendarView menuCycleDailyCalendarView,
            RecipeSearch recipeSearch, ToastNotification notification,
                              ModalDialogPage modalDialogPage, WeeklyCalendarView weeklyCalendarView)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTabDays;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTabDays;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;
            this.recipeSearch = recipeSearch;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;
            this.weeklyCalendarView = weeklyCalendarView;

            this.scenarioContext = scenarioContext;
        }

        [When(@"Week ""(.*)"" is copied")]
        public void WeekIsCopied(string weekName)
        {
            
            weeklyCalendarView.GetWeek(weekName).UseCopyButton();
            dailyPlanningView.WaitForBackdropToDisappear();
        }

        [When(@"Delete button is clicked for week ""(.*)""")]
        [Then(@"Delete button is clicked for week ""(.*)""")]
        public void DeleteButtonIsClickedForWeek(string weekName)
        {
            weeklyCalendarView.GetWeek(weekName).UseDeleteButton();
            dailyPlanningView.WaitForBackdropToDisappear();
        }
    }
}