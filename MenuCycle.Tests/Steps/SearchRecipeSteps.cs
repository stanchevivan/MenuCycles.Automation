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
        private MenuCyclePlanningView menuCyclePlanningView;
        private MenuCycleCalendarView menuCycleCalendarView;
        private CreateMealPeriod createMealPeriod;
        private RecipeSearch recipeSearch;
        private ToastNotification notification;
        private ScenarioContext scenarioContext;
        
        public SearchRecipeSteps(ScenarioContext scenarioContext, MenuCyclePlanningView menuCyclePlanningView, MenuCycleCalendarView menuCycleCalendarView, 
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.menuCyclePlanningView = menuCyclePlanningView;
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
            menuCyclePlanningView.WaitPageToLoad();
        }

        [Then(@"the planning screen for (.*) is open")]
        public void ThenThePlanningScreenForADayIsOpened(string weekDay)
        {
            Assert.That(menuCyclePlanningView.GetHeaderText(), Is.EqualTo(weekDay.ToUpper()));
        }
    }
}