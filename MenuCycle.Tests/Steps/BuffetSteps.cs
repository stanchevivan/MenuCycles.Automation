﻿using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class BuffetSteps
    {
        readonly PlanningView dailyPlanningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;
        readonly CreateMealPeriod createMealPeriod;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;

        public BuffetSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleDailyCalendarView menuCycleDailyCalendarView,
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTabDays;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTabDays;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
        }

        [When(@"data for buffets is set")]
        [When(@"data for recipes is set")]
        public void WhenDataForItemsIsSet(Table table)
        {
            var itemData = table.CreateSet<RecipeModel>();

            Recipe item;

            foreach (var data in itemData)
            {

                switch (data.Type)
                {
                    case "RECIPE":
                        {
                            item = planningTabDays.GetMealPeriod(data.MealPeriodName)
                                                  .GetRecipe(data.RecipeTitle);
                            break;
                        }
                    case "BUFFET":
                        {
                            item = planningTabDays.GetMealPeriod(data.MealPeriodName)
                                                  .GetBuffet(data.RecipeTitle);
                            break;
                        }

                    default:
                        {
                            throw new System.Exception($"TYPE is {data.Type}. It should be RECIPE or BUFFET !");
                        }
                }

                item.GetRow().SetData(data);
            }

            planningTabDays.FocusOut();
        }

        [When(@"Verify data for items is")]
        [StepDefinition(@"Verify data for items is")]
        public void WhenVerifyDataForItemsIs(Table table)
        {
            var expectedItems = table.CreateSet<RecipeModel>();

            Recipe item;

            foreach (var expectedItem in expectedItems)
            {
                switch (expectedItem.Type)
                {
                    case "RECIPE":
                        {
                            item = planningTabDays.GetMealPeriod(expectedItem.MealPeriodName)
                                                  .GetRecipe(expectedItem.RecipeTitle);
                            break;
                        }
                    case "BUFFET":
                        {
                            item = planningTabDays.GetMealPeriod(expectedItem.MealPeriodName)
                                                  .GetBuffet(expectedItem.RecipeTitle);
                            break;
                        }

                    default:
                        {
                            item = planningTabDays.GetMealPeriod(expectedItem.MealPeriodName)
                                                  .GetRecipe(expectedItem.RecipeTitle);
                            break;
                        }
                }

                item.GetRow().VerifyData(expectedItem);
            }
        }

        [When(@"data for recipes in buffet ""(.*)"" in meal period ""(.*)"" is set")]
        public void WhenDataForRecipesInBuffetInMealPeriodIsSet(string buffetName, string mealPeriod, Table table)
        {
            var itemData = table.CreateSet<RecipeModel>();

            var buffet = planningTabDays.GetMealPeriod(mealPeriod).GetBuffet(buffetName);

            foreach (var data in itemData)
            {
                buffet.GetRecipe(data.RecipeTitle).GetRow().PlannedQuantity = data.PlannedQuantity;
            }

            planningTabDays.FocusOut();
        }

        [Then(@"Verify data for recipes in buffet ""(.*)"" in meal period ""(.*)"" is")]
        public void ThenVerifyDataForRecipesInBuffetInMealPeriodIs(string buffetName, string mealPeriod, Table table)
        {
            var itemData = table.CreateSet<RecipeModel>();

            var buffet = planningTabDays.GetMealPeriod(mealPeriod).GetBuffet(buffetName);

            foreach (var data in itemData)
            {
                Assert.That(buffet.GetRecipe(data.RecipeTitle).GetRow().PlannedQuantity, Is.EqualTo(data.PlannedQuantity));
            }
        }
    }
}