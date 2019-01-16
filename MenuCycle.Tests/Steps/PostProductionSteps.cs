﻿using System;using System.Linq;using MenuCycle.Tests.Models;using MenuCycle.Tests.PageObjects;using NUnit.Framework;using TechTalk.SpecFlow;using TechTalk.SpecFlow.Assist;namespace MenuCycle.Tests.Steps{    [Binding]    public class PostProductionSteps    {        readonly PlanningView planningView;        readonly PlanningTabDays planningTabDays;        readonly PlanningTabWeeks planningTabWeeks;        readonly NutritionTabDays nutritionTabDays;        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;        readonly RecipeSearch recipeSearch;        readonly ToastNotification notification;        readonly ScenarioContext scenarioContext;        readonly PostProductionTabDays postProductionTabDays;        public PostProductionSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleDailyCalendarView menuCycleDailyCalendarView,            RecipeSearch recipeSearch, ToastNotification notification, PostProductionTabDays postProductionTabDays)        {            this.planningView = dailyPlanningView;            this.planningTabDays = planningTab;            this.planningTabWeeks = planningTabWeeks;            this.nutritionTabDays = nutritionTab;            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;            this.recipeSearch = recipeSearch;            this.notification = notification;            this.postProductionTabDays = postProductionTabDays;            this.scenarioContext = scenarioContext;        }        [Then(@"Verify all post production meal periods are expanded")]        public void VerifyAllPostProductionMealPeriodsAreExpanded()        {            Assert.IsTrue(postProductionTabDays.AreAllMealPeriodsExpanded);        }        [Then(@"Verify all post production meal periods are collapsed")]        public void VerifyAllPostProductionMealPeriodsAreCollapsed()        {            Assert.IsTrue(postProductionTabDays.AreAllMealPeriodsCollapsed);        }        [When(@"Post-production meal period ""(.*)"" is collapsed")]        public void WhenMealPeriodIsCollapsed(string periodName)        {            postProductionTabDays.GetMealPeriod(periodName).Collapse();        }        [When(@"Post-production meal period ""(.*)"" is expanded")]        public void WhenMealPeriodIsExpanded(string periodName)        {            postProductionTabDays.GetMealPeriod(periodName).Expand();        }        [Then(@"Verify main data for Meal Period ""(.*)"" is collapsed in Post production days")]        public void ThenMainDataForMealPeriodIsCollapsedInPostProductionDays(string periodName)        {            Assert.IsFalse(postProductionTabDays.GetMealPeriod(periodName).IsExpanded);        }        [Then(@"Verify main data for Meal Period ""(.*)"" is expanded in Post production days")]        public void ThenMainDataForMealPeriodIsExpandedInPostProductionDays(string periodName)        {            Assert.IsTrue(postProductionTabDays.GetMealPeriod(periodName).IsExpanded);        }        [Then(@"Verify planned quantity daily total equals the sum of all meal period totals")]        public void VerifyDailyTotalEqualsTheSumOfAllMealPeriodTotals()        {            var sumOfMealPeriodQuantities = postProductionTabDays.MealPeriods.Sum(x => int.Parse(x.PlannedQuantity));            Assert.That(sumOfMealPeriodQuantities, Is.EqualTo(int.Parse(postProductionTabDays.PlannedQtyTotal)));        }        [When(@"values are entered for recipe ""(.*)"" tariff ""(.*)"" in meal period ""(.*)""")]        public void WhenValuesAreEnteredFor(string recipeName, string tariff, string mealPeriod, Table table)        {            var recipeRow = postProductionTabDays.GetMealPeriod(mealPeriod)            .GetRecipe(recipeName)            .GetRow(tariff);                            dynamic values = table.CreateDynamicInstance();
            recipeRow.QuantityProduced = Convert.ToString(values.qtyProd);            recipeRow.QuantitySold = Convert.ToString(values.qtySold);            recipeRow.NoCharge = Convert.ToString(values.noCharge);            recipeRow.ReturnToStock = Convert.ToString(values.returnToStock);        }

        [Then(@"Verify Wastage is correctly calculated for recipe ""(.*)"" tariff ""(.*)"" in meal period ""(.*)""")]        public void ThenVerifyWastageIsCorrectlyCalculatedForRecipe(string recipeName, string tariff, string mealPeriod)        {
            var recipe = postProductionTabDays.GetMealPeriod(mealPeriod)
                 .GetRecipe(recipeName)
                 .GetRow(tariff);            Assert.That(int.Parse(recipe.Wastage), Is.EqualTo(            int.Parse(recipe.QuantityProduced)                 - int.Parse(recipe.QuantitySold) - int.Parse(recipe.NoCharge) - int.Parse(recipe.ReturnToStock)));        }    }}