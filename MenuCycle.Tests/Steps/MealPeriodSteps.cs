using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class MealPeriodSteps
    {
        private DailyPlanningView dailyPlanningView;
        private PlanningTabDays planningTabDays;
        private PlanningTabWeeks planningTabWeeks;
        private NutritionTabDays nutritionTabDays;
        private MenuCycleCalendarView menuCycleCalendarView;
        private CreateMealPeriod createMealPeriod;
        private RecipeSearch recipeSearch;
        private ToastNotification notification;
        private ScenarioContext scenarioContext;

        public MealPeriodSteps(ScenarioContext scenarioContext, DailyPlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleCalendarView menuCycleCalendarView,
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTab;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTab;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
        }

        [Given(@"a Meal Period for (.*) is added")]
        public void GivenAMealPeriodForIsAddedToAMenuCycle(string weekDayName)
        {
            menuCycleCalendarView.AddMealPeriod(weekDayName);
            createMealPeriod.SelectMealPeriod(scenarioContext.Get<IList<MealPeriods>>().First().Name);
        }

        [When(@"Meal Period ""(.*)"" is expanded")]
        public void WhenMealPeriodIsExpanded(string periodName)
        {
            planningTabDays.ExpandMealPeriod(periodName);
        }

        [When(@"Meal Period ""(.*)"" is collapsed")]
        public void WhenMealPeriodIsCollapsed(string periodName)
        {
            planningTabDays.CollapseMealPeriod(periodName);
        }

        [Then(@"main data for Meal Period ""(.*)"" is collapsed")]
        public void ThenMainDataForMealPeriodIsCollapsed(string periodName)
        {
            Assert.IsFalse(planningTabDays.IsMealPeriodExpanded(periodName));
        }

        [Then(@"main data for Meal Period ""(.*)"" is expanded")]
        public void ThenMainDataForMealPeriodIsShown(string periodName)
        {
            Assert.IsTrue(planningTabDays.IsMealPeriodExpanded(periodName));
        }

        [Given(@"Meal Period colours for ""(.*)"" are saved")]
        public void GivenMealPeriodColoursForAreSaved(string weekDay)
        {
            scenarioContext.Add("MealPeriodColours", menuCycleCalendarView.GetMealPeriodColours(weekDay));
        }

        [Then(@"Meal Period colours match the calendar view colours")]
        public void ThenMealPeriodColoursMatchTheCalendarViewColours()
        {
            Assert.That(planningTabDays.GetMealPeriodColours(), Is.EqualTo(scenarioContext.Get<IList<string>>("MealPeriodColours")));
        }

    }
}
