using System.Collections.Generic;
using TechTalk.SpecFlow;
using System.Linq;
using MenuCycle.Tests.PageObjects;
using MenuCycle.Data.Models;
using NUnit.Framework;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public sealed class SearchRecipeSteps
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
        
        public SearchRecipeSteps(ScenarioContext scenarioContext, DailyPlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleCalendarView menuCycleCalendarView, 
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

        [When(@"the first recipe is searched by name")]
        public void WhenTheFirstRecipeIsSearchedByName()
        {
            createMealPeriod.AddRecipe();
            recipeSearch.SearchRecipeByName(scenarioContext.Get<IList<Recipes>>().First().Name);
        }

        [When(@"recipe is added to a meal period")]
        public void WhenRecipeIsAddedToAMealPeriod()
        {
            recipeSearch.AddRecipe(scenarioContext.Get<IList<Recipes>>().First().Name);
            createMealPeriod.SaveAndCloseMealPeriod();
        }

        [Then(@"recipe is displayed under (.*) column inside the correct Meal Period")]
        public void ThenRecipeIsDiplayedUnderColumnInsideTheCorrectMealPeriod(string weekDayName)
        {
            menuCycleCalendarView.ValidateMealPeriod(weekDayName, scenarioContext.Get<IList<MealPeriods>>().First(), scenarioContext.Get<IList<Recipes>>().First());
        }

        [When(@"planning for (.*) is opened")]
        public void WhenPlanningForADayIsOpened(string weekDay)
        {
            menuCycleCalendarView.OpenDailyPlanningForDay(weekDay);
            dailyPlanningView.WaitForLoad();
        }

        [Then(@"the planning screen for (.*) is open")]
        public void ThenThePlanningScreenForADayIsOpened(string weekDay)
        {
            Assert.That(dailyPlanningView.GetHeaderText(), Is.EqualTo(weekDay.ToUpper()));
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

        [Then(@"planning screen engine is loaded")]
        public void ThenPlanningScreenEngineIsLoaded()
        {
            Assert.IsTrue(planningTabDays.IsEngineLoaded());
        }

        [When(@"daily nutrition tab is opened")]
        public void WhenNutritionTabIsOpened()
        {
            dailyPlanningView.OpenDailyNutritionTab();
            nutritionTabDays.WaitForLoad();
        }

        [When(@"daily planning tab is opened")]
        public void WhenPlanningTabIsOpened()
        {
            dailyPlanningView.OpenDailyPlanningTab();
            planningTabDays.WaitForLoad();
        }

        [When(@"weekly planning tab is opened")]
        public void WeeklyPlanningTabIsOpened()
        {
        }

        [When(@"weekly nutrition tab is opened")]
        public void WeeklyNutritionTabIsOpened()
        {
        }

        [When(@"switching to Weekly Planning view")]
        public void SwitchingToWeeklyPlanningView()
        {
            planningTabDays.SwitchToWeeklyView();
            planningTabWeeks.WaitForLoad();
        }

        [When(@"switching to Daily Planning view")]
        public void SwitchingToDailyPlanningView()
        {
            planningTabWeeks.SwitchToDailyView();
            planningTabDays.WaitForLoad();
        }

        [When(@"switching to Weekly Nutrition view")]
        public void SwitchingToWeeklyNutritionView()
        {
        }
    }
}