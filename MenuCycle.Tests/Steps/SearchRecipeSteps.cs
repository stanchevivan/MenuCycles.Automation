using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;
using MenuCycle.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public sealed class SearchRecipeSteps
    {
        readonly PlanningView planningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleCalendarView menuCycleCalendarView;
        readonly CreateMealPeriod createMealPeriod;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        
        public SearchRecipeSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleCalendarView menuCycleCalendarView, 
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.planningView = dailyPlanningView;
            this.planningTabDays = planningTab;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTab;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
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
    }
}