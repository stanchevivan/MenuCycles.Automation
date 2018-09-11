using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public sealed class SearchRecipeSteps
    {
        readonly PlanningView planningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly MealPeriodDetails mealPeriodDetails;
        readonly RecipeOverview recipeOverview;

        public SearchRecipeSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleDailyCalendarView menuCycleDailyCalendarView, RecipeSearch recipeSearch, ToastNotification notification, MealPeriodDetails mealPeriodDetails, RecipeOverview recipeOverview)
        {
            this.planningView = dailyPlanningView;
            this.planningTabDays = planningTab;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTab;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;
            this.recipeSearch = recipeSearch;
            this.notification = notification;
            this.mealPeriodDetails = mealPeriodDetails;
            this.recipeOverview = recipeOverview;

            this.scenarioContext = scenarioContext;
        }


        [When(@"detailed view for recipe with name ""(.*)"" is opened")]
        public void WhenRecipeDetailedViewIsOpened(string recipeName)
        {
            mealPeriodDetails.GetRecipeCard(recipeName).OpenRecipeDetailedView();
            recipeOverview.WaitForLoad();
        }

        [Then(@"meal period recipe name is ""(.*)""")]
        public void ThenMealPeriodRecipeNameIs(string recipeName)
        {
            Assert.That(recipeOverview.GetRecipeTitleText, Is.EqualTo(recipeName));
        }

        [Then(@"recipe price is ""(.*)""")]
        public void ThenRecipePriceIs(string price)
        {
            Assert.That(recipeOverview.GetRecipePriceText, Is.EqualTo(price));
        }

        [Then(@"Verify ingredients in the detailed view")]
        public void ThenVerifyIngredientsInTheDetailedView(Table table)
        {
            Assert.That(recipeOverview.Ingredients.Select(x => x.Cost).ToList(), Is.EqualTo(table.Rows.Select(x => x["IngredientCost"]).ToList()));
        }

        [Then(@"Verify ingredients total cost is ""(.*)""")]
        public void ThenVerifyIngredientsTotalCostIs(string totalCost)
        {
            Assert.AreEqual(recipeOverview.TotalCostText, totalCost);
        }

        [When(@"""(.*)"" message is displayed")]
        public void NoResultsFound(string message)
        {
            Assert.AreEqual(recipeSearch.NoResultText, message);
        }
    }
}