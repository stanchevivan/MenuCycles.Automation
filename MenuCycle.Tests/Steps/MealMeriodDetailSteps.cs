﻿
using System;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class MealMeriodDetailSteps
    {
        readonly MenuCycleCalendarView menuCycleCalendarView;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly MealPeriodDetails mealPeriodDetails;
        readonly RecipeSearch recipeSearch;

        public MealMeriodDetailSteps(ScenarioContext scenarioContext, MenuCycleCalendarView menuCycleCalendarView,
                                     ToastNotification notification, MealPeriodDetails mealPeriodDetails,
                                     RecipeSearch recipeSearch)
        {
            this.scenarioContext = scenarioContext;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.notification = notification;
            this.mealPeriodDetails = mealPeriodDetails;
            this.recipeSearch = recipeSearch;
        }

        [When(@"Details for meal period ""(.*)"" in ""(.*)"" are opened")]
        public void WhenDetailsForMealPeriodInAreOpened(string mealPeriod, string weekDay)
        {
            menuCycleCalendarView.GetDay(weekDay).GetMealPeriodCard(mealPeriod).OpenMealPeriodDetails();
            mealPeriodDetails.WaitForLoad();
        }

        [When(@"Recipe search is opened")]
        public void WhenRecipeSearchIsOpened()
        {
            mealPeriodDetails.AddRecipe();
        }

        [When(@"Recipe ""(.*)"" is searched")]
        public void RecipeIsSearched(string text)
        {
            recipeSearch.SearchRecipeByName(text);
        }

        [When(@"Recipe ""(.*)"" is added")]
        public void RecipeIsAdded(string text)
        {
            recipeSearch.AddRecipe(text);
        }

        [Then(@"Verify items in the meal period are")]
        public void ThenVerifyItemsInTheMealPeriodAre(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                Assert.That(mealPeriodDetails.GetRecipeCard(row["Name"]).Cost, Is.EqualTo(row["Cost"]));
            }
        }

        [When(@"Buffet ""(.*)"" is expanded")]
        public void WhenBuffetIsExpanded(string buffetName)
        {
            mealPeriodDetails.GetBuffetCard(buffetName).Expand();
        }

        [Then(@"Verify recipes in meal period details for buffet ""(.*)"" are")]
        public void ThenVerifyRecipesInMealPeriodDetailsForBuffetAre(string buffetName, Table table)
        {
            var buffetCard = mealPeriodDetails.GetBuffetCard(buffetName);

            // TODO: Should use ExpandedRecipes related to buffet card, not the whole meal period
            for (int i = 0; i < table.Rows.Count; i++)
            {
                Assert.That(mealPeriodDetails.ExpandedRecipes[i].Name, Is.EqualTo(table.Rows[i]["Name"]));
                Assert.That(mealPeriodDetails.ExpandedRecipes[i].Cost, Is.EqualTo(table.Rows[i]["Cost"]));
            }
        }

        [When(@"Verify items present in the search results are")]
        [Then(@"Verify items present in the search results are")]
        public void VerifyItemsReturnedFromSearchAre(Table table)
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                Assert.That(recipeSearch.GetRecipeFromSearch(table.Rows[i]["Name"]).Cost, Is.EqualTo(table.Rows[i]["Cost"]));
            }
        }

        [When(@"Verify items in meal period detailed view")]
        [Then(@"Verify items in meal period detailed view")]
        public void VerifyItemsInMealPriodDetailedView(Table table)
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                Assert.That(recipeSearch.GetRecipeFromDetailedView(table.Rows[i]["Name"]).Cost, Is.EqualTo(table.Rows[i]["Cost"]));
            }
        }

        [When(@"meal period detailed view is closed")]
        public void WhenMealPeriodDetailedViewIsClosed()
        {
            mealPeriodDetails.UseCrossButton();
        }
    }
}