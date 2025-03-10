﻿using System;using System.Linq;using MenuCycle.Tests.PageObjects;
using NUnit.Framework;using TechTalk.SpecFlow;using TechTalk.SpecFlow.Assist;namespace MenuCycle.Tests.Steps{    [Binding]    public class NutritionSteps    {        readonly PlanningView planningView;        readonly PlanningTabDays planningTabDays;        readonly PlanningTabWeeks planningTabWeeks;        readonly NutritionTabDays nutritionTabDays;        readonly NutritionTabWeeks nutritionTabWeeks;        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;        readonly RecipeSearch recipeSearch;        readonly ToastNotification notification;        readonly ScenarioContext scenarioContext;        readonly PostProductionTabDays postProductionTabDays;        readonly PostProductionTabWeeks postProductionTabWeeks;        public NutritionSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleDailyCalendarView menuCycleDailyCalendarView,                                   RecipeSearch recipeSearch, ToastNotification notification, PostProductionTabDays postProductionTabDays, PostProductionTabWeeks postProductionTabWeeks, NutritionTabWeeks nutritionTabWeeks)        {            this.planningView = dailyPlanningView;            this.planningTabDays = planningTab;            this.planningTabWeeks = planningTabWeeks;            this.nutritionTabDays = nutritionTab;            this.nutritionTabWeeks = nutritionTabWeeks;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;            this.recipeSearch = recipeSearch;            this.notification = notification;            this.postProductionTabDays = postProductionTabDays;            this.postProductionTabWeeks = postProductionTabWeeks;            this.scenarioContext = scenarioContext;        }        [Then(@"Verify all nutrition meal periods are expanded")]        public void VerifyAllNutritionMealPeriodsAreExpanded()        {            Assert.IsTrue(nutritionTabDays.AreAllMealPeriodsExpanded);        }        [Then(@"Verify all nutrition meal periods are collapsed")]        public void VerifyAllNutritionMealPeriodsAreCollapsed()        {            Assert.IsTrue(nutritionTabDays.AreAllMealPeriodsCollapsed);

        }

        [Then(@"Verify nutrition data for recipes are")]        public void ThenVerifyNutritionDataForItemsIs(Table table)        {
            var row = table.Rows[0];

            var recipe = nutritionTabDays.GetMealPeriod(row["MealPeriodName"]).GetRecipe(row["RecipeTitle"]).GetFirstRow();

            if (scenarioContext.ContainsKey("PlannedQuantity")) Assert.That(recipe.PlannedQuantity, Is.EqualTo(scenarioContext.Get<string>("PlannedQuantity")));
            if (row.ContainsKey("MixPercent")) Assert.That(recipe.MixPercentage, Is.EqualTo(row["MixPercent"]));            if (row.ContainsKey("EnergyKJ")) Assert.That(recipe.EnergyKJ, Is.EqualTo(row["EnergyKJ"]));
            if (row.ContainsKey("EnergyKCAL")) Assert.That(recipe.EnergyKCAL, Is.EqualTo(row["EnergyKCAL"]));
            if (row.ContainsKey("Fat")) Assert.That(recipe.Fat, Is.EqualTo(row["Fat"]));
            if (row.ContainsKey("SaturatedFat")) Assert.That(recipe.SaturatesFat, Is.EqualTo(row["SaturatedFat"]));
            if (row.ContainsKey("Sugar")) Assert.That(recipe.Sugar, Is.EqualTo(row["Sugar"]));
            if (row.ContainsKey("Salt")) Assert.That(recipe.Salt, Is.EqualTo(row["Salt"]));
        }

        [When(@"Nutrition meal period ""(.*)"" is collapsed")]        public void WhenNutritionMealPeriodIsCollapsed(string periodName)        {            nutritionTabDays.GetMealPeriod(periodName).Collapse();        }        [When(@"Nutrition meal period ""(.*)"" is expanded")]        public void WhenNutritionMealPeriodIsExpanded(string periodName)        {            nutritionTabDays.GetMealPeriod(periodName).Expand();        }        [Then(@"Verify main data for Meal Period ""(.*)"" is collapsed in Nutrition days")]        public void ThenMainDataForNutritionMealPeriodIsCollapsedInPostProductionDays(string periodName)        {            Assert.IsFalse(nutritionTabDays.GetMealPeriod(periodName).IsExpanded);        }        [Then(@"Verify main data for Meal Period ""(.*)"" is expanded in Nutrition days")]        public void ThenMainDataForNutritionMealPeriodIsExpandedInPostProductionDays(string periodName)        {            Assert.IsTrue(nutritionTabDays.GetMealPeriod(periodName).IsExpanded);        }

        [When(@"Verify all meal periods are expanded in Nutrition screen days")]        [Then(@"Verify all meal periods are expanded in Nutrition screen days")]        public void AllMealPeriodsAreExpandedInNutritionScreenDays()        {            Assert.IsTrue(nutritionTabDays.AreAllMealPeriodsExpanded);        }

        [When(@"Verify all meal periods are collapsed in Nutrition screen days")]        [Then(@"Verify all meal periods are collapsed in Nutrition screen days")]        public void AllMealPeriodsAreCollapsedInNutritionScreenDays()        {            Assert.IsFalse(nutritionTabDays.AreAllMealPeriodsExpanded);        }

        [Then(@"Verify Nutrition Daily Totals are equal to")]        public void ThenNutritionDailyTotalsAreEqualTo(Table table)        {            if (!string.IsNullOrEmpty(table.Rows[0]["PlannedQty"]))            {                Assert.That(nutritionTabDays.DailyPlannedQtyTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["PlannedQty"])));            }            if (!string.IsNullOrEmpty(table.Rows[0]["EnergyKJ"]))            {                Assert.That(nutritionTabDays.DailyEnergyKJTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["EnergyKJ"])));            }            if (!string.IsNullOrEmpty(table.Rows[0]["EnergyKCAL"]))            {                Assert.That(nutritionTabDays.DailyEnergyKCALTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["EnergyKCAL"])));            }            if (!string.IsNullOrEmpty(table.Rows[0]["Fat"]))            {                Assert.That(nutritionTabDays.DailyFatTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["Fat"])));            }
            if (!string.IsNullOrEmpty(table.Rows[0]["SaturatedFat"]))            {                Assert.That(nutritionTabDays.DailySaturatedFatTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["SaturatedFat"])));            }
            if (!string.IsNullOrEmpty(table.Rows[0]["Sugar"]))            {                Assert.That(nutritionTabDays.DailySugarTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["Sugar"])));            }
            if (!string.IsNullOrEmpty(table.Rows[0]["Salt"]))            {                Assert.That(nutritionTabDays.DailySaltTotal, Is.EqualTo(table.Rows[0]["Salt"]));            }        }

        [Then(@"Verify Nutritions Meal Period ""(.*)"" Totals are equal to")]        public void ThenVerifyNutritionsMealPeriodTotalsAreEqualTo(string mealPeriodName, Table table)        {            var mealPeriod = nutritionTabDays.GetMealPeriod(mealPeriodName);            if (!string.IsNullOrEmpty(table.Rows[0]["PlannedQty"]))            {                Assert.That(mealPeriod.MealPeriodPlannedQtyTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["PlannedQty"])));            }            if (!string.IsNullOrEmpty(table.Rows[0]["EnergyKJ"]))            {                Assert.That(mealPeriod.MealPeriodEnergyKJTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["EnergyKJ"])));            }            if (!string.IsNullOrEmpty(table.Rows[0]["EnergyKCAL"]))            {                Assert.That(mealPeriod.MealPeriodEnergyKCALTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["EnergyKCAL"])));            }            if (!string.IsNullOrEmpty(table.Rows[0]["Fat"]))            {                Assert.That(mealPeriod.MealPeriodFatTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["Fat"])));            }
            if (!string.IsNullOrEmpty(table.Rows[0]["SaturatedFat"]))            {                Assert.That(mealPeriod.MealPeriodSaturatedFatTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["SaturatedFat"])));            }
            if (!string.IsNullOrEmpty(table.Rows[0]["Sugar"]))            {                Assert.That(mealPeriod.MealPeriodSugarTotal, Is.EqualTo(Convert.ToString(table.Rows[0]["Sugar"])));            }
            if (!string.IsNullOrEmpty(table.Rows[0]["Salt"]))            {                Assert.That(mealPeriod.MealPeriodSaltTotal, Is.EqualTo(table.Rows[0]["Salt"]));            }
        }        [Then(@"number of covers field is not present")]        public void NumberOfCoversFieldIsNotPresent()        {            Assert.IsFalse(nutritionTabDays.IsNumberOfCoversHiddenForAllMealPeriods);
        }

        [Then(@"Verify daily nutrition totals equals the sum of all meal period totals")]        public void VerifyDailyNutritionTotalEqualsTheSumOfAllMealPeriodTotals()        {            int sumOfMealPeriodQuantities = nutritionTabDays.MealPeriods.Sum(x => int.Parse(x.MealPeriodPlannedQtyTotal));            Assert.That(sumOfMealPeriodQuantities, Is.EqualTo(decimal.Parse(nutritionTabDays.DailyPlannedQtyTotal)));

            decimal sumOfMealPeriodEnergyKJ = nutritionTabDays.MealPeriods.Sum(x => decimal.Parse(x.MealPeriodEnergyKJTotal));            Assert.That(sumOfMealPeriodEnergyKJ, Is.EqualTo(decimal.Parse(nutritionTabDays.DailyEnergyKJTotal)));

            decimal sumOfMealPeriodEnergyKCAL = nutritionTabDays.MealPeriods.Sum(x => decimal.Parse(x.MealPeriodEnergyKCALTotal));            Assert.That(sumOfMealPeriodEnergyKCAL, Is.EqualTo(decimal.Parse(nutritionTabDays.DailyEnergyKCALTotal)));

            decimal sumOfMealPeriodFat = nutritionTabDays.MealPeriods.Sum(x => decimal.Parse(x.MealPeriodFatTotal));            Assert.That(sumOfMealPeriodFat, Is.EqualTo(decimal.Parse(nutritionTabDays.DailyFatTotal)));

            decimal sumOfMealPeriodSaturatedFat = nutritionTabDays.MealPeriods.Sum(x => decimal.Parse(x.MealPeriodSaturatedFatTotal));            Assert.That(sumOfMealPeriodSaturatedFat, Is.EqualTo(decimal.Parse(nutritionTabDays.DailySaturatedFatTotal)));

            decimal sumOfMealPeriodSugar = nutritionTabDays.MealPeriods.Sum(x => decimal.Parse(x.MealPeriodSugarTotal));            Assert.That(sumOfMealPeriodSugar, Is.EqualTo(decimal.Parse(nutritionTabDays.DailySugarTotal)));

            decimal sumOfMealPeriodSalt = nutritionTabDays.MealPeriods.Sum(x => decimal.Parse(x.MealPeriodSaltTotal));            Assert.That(sumOfMealPeriodSalt, Is.EqualTo(decimal.Parse(nutritionTabDays.DailySaltTotal)));        }

        [Then(@"Verify meal period ""(.*)"" nutrition total equals the sum of all recipes nutrition values")]        public void VerifyMealPeriodNutritionTotalEqualsTheSumOfRecipesNutritionValues(string mealPeriodName)        {            var recipes = nutritionTabDays.GetMealPeriod(mealPeriodName).Recipes;            var buffetRecipes = nutritionTabDays.GetMealPeriod(mealPeriodName).Buffets.SelectMany(x => x.Recipes).Select(x => x.GetFirstRow());            var aLaCarteRecipes = nutritionTabDays.GetMealPeriod(mealPeriodName).ALaCartes.SelectMany(x => x.Recipes).Select(x => x.GetFirstRow());            int plannedQtySums = recipes.Sum(x => int.Parse(x.GetFirstRow().PlannedQuantity))             + buffetRecipes.Sum(x => int.Parse(x.PlannedQuantity))             + aLaCarteRecipes.Sum(x => int.Parse(x.PlannedQuantity));
            Assert.That(plannedQtySums, Is.EqualTo(int.Parse(nutritionTabDays.GetMealPeriod(mealPeriodName).MealPeriodPlannedQtyTotal)));

            decimal EnergyKJSums = recipes.Sum(x => decimal.Parse(x.GetFirstRow().EnergyKJ))
              + buffetRecipes.Sum(x => decimal.Parse(x.EnergyKJ))
              + aLaCarteRecipes.Sum(x => decimal.Parse(x.EnergyKJ));            Assert.That(EnergyKJSums, Is.EqualTo(decimal.Parse(nutritionTabDays.GetMealPeriod(mealPeriodName).MealPeriodEnergyKJTotal)));

            decimal EnergyKCALSums = recipes.Sum(x => decimal.Parse(x.GetFirstRow().EnergyKCAL))
              + buffetRecipes.Sum(x => decimal.Parse(x.EnergyKCAL))
              + aLaCarteRecipes.Sum(x => decimal.Parse(x.EnergyKCAL));            Assert.That(EnergyKCALSums, Is.EqualTo(decimal.Parse(nutritionTabDays.GetMealPeriod(mealPeriodName).MealPeriodEnergyKCALTotal)));

            decimal FatSums = recipes.Sum(x => decimal.Parse(x.GetFirstRow().Fat))
              + buffetRecipes.Sum(x => decimal.Parse(x.Fat))
              + aLaCarteRecipes.Sum(x => decimal.Parse(x.Fat));            Assert.That(FatSums, Is.EqualTo(decimal.Parse(nutritionTabDays.GetMealPeriod(mealPeriodName).MealPeriodFatTotal)));

            decimal SaturatedFatSums = recipes.Sum(x => decimal.Parse(x.GetFirstRow().SaturatesFat))
              + buffetRecipes.Sum(x => decimal.Parse(x.SaturatesFat))
              + aLaCarteRecipes.Sum(x => decimal.Parse(x.SaturatesFat));            Assert.That(SaturatedFatSums, Is.EqualTo(decimal.Parse(nutritionTabDays.GetMealPeriod(mealPeriodName).MealPeriodSaturatedFatTotal)));

            decimal SugarSums = recipes.Sum(x => decimal.Parse(x.GetFirstRow().Sugar))
              + buffetRecipes.Sum(x => decimal.Parse(x.Sugar))
              + aLaCarteRecipes.Sum(x => decimal.Parse(x.Sugar));            Assert.That(SugarSums, Is.EqualTo(decimal.Parse(nutritionTabDays.GetMealPeriod(mealPeriodName).MealPeriodSugarTotal)));

            decimal SaltSums = recipes.Sum(x => decimal.Parse(x.GetFirstRow().Salt))
              + buffetRecipes.Sum(x => decimal.Parse(x.Salt))
              + aLaCarteRecipes.Sum(x => decimal.Parse(x.Salt));            Assert.That(SaltSums, Is.EqualTo(decimal.Parse(nutritionTabDays.GetMealPeriod(mealPeriodName).MealPeriodSaltTotal)));
        }

        [Then(@"Verify Planned Qty for recipe ""(.*)"" in meal period ""(.*)"" equals the sum of the tariffs planned qty values")]        public void ThenVerifyPlannedQtyForRecipeInMealPeriodEqualsTheSumOfTheTariffsPlannedQtyValues(string recipeName, string mealPeriod)        {            int recipePlannedQty = int.Parse(nutritionTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeName).GetFirstRow().PlannedQuantity);            Assert.That(scenarioContext.Get<int>("PlanningScreenPlannedQtySum"), Is.EqualTo(recipePlannedQty));
        }

        [Then(@"Verify weekly nutrition totals equals the sum of all meal period totals")]        public void VerifyWeeklyNutritionTotalEqualsTheSumOfAllMealPeriodTotals()        {            decimal sumOfDaysKJ = nutritionTabWeeks.Days.Sum(x => decimal.Parse(x.DailyTotalEnergyKJ));            Assert.That(sumOfDaysKJ, Is.EqualTo(decimal.Parse(nutritionTabWeeks.WeeklyEnergyKJTotal)));
            decimal sumOfDaysKCAL = nutritionTabWeeks.Days.Sum(x => decimal.Parse(x.DailyTotalEnergyKCAL));            Assert.That(sumOfDaysKCAL, Is.EqualTo(decimal.Parse(nutritionTabWeeks.WeeklyEnergyKCALTotal)));

            decimal sumOfDaysFat = nutritionTabWeeks.Days.Sum(x => decimal.Parse(x.DailyTotalFat));            Assert.That(sumOfDaysFat, Is.EqualTo(decimal.Parse(nutritionTabWeeks.WeeklyFatTotal)));

            decimal sumOfDaysSaturatedFat = nutritionTabWeeks.Days.Sum(x => decimal.Parse(x.DailyTotalSaturatedFat));            Assert.That(sumOfDaysSaturatedFat, Is.EqualTo(decimal.Parse(nutritionTabWeeks.WeeklySaturatedFatTotal)));

            decimal sumOfDaysSugar = nutritionTabWeeks.Days.Sum(x => decimal.Parse(x.DailyTotalSugar));            Assert.That(sumOfDaysSugar, Is.EqualTo(decimal.Parse(nutritionTabWeeks.WeeklySugarTotal)));

            decimal sumOfDaysSalt = nutritionTabWeeks.Days.Sum(x => decimal.Parse(x.DailyTotalSalt));            Assert.That(sumOfDaysSalt, Is.EqualTo(decimal.Parse(nutritionTabWeeks.WeeklySaltTotal)));        }        [Then(@"Verify meal periods for day ""(.*)"" in nutrition screen daily are:")]        public void ThenVerifyMealPeriodsForNuritionDayAre(string day,Table table)        {            var expectedMealPeriods = table.Rows[0]["mealPeriods"].Split(',');            var currentMealPeriods =  nutritionTabDays.MealPeriods.Select(x => x.Name);            Assert.That(currentMealPeriods, Is.EqualTo(expectedMealPeriods));        }        [Then(@"Verify meal periods for day ""(.*)"" week ""(.*)"" in nutrition screen weekly are:")]        public void ThenVerifyMealPeriodsForDayInNutritionWeeksAre(string day, string week, Table table)        {            var expectedMealPeriods = table.Rows[0]["mealPeriods"].Split(',');            var currentMealPeriods = nutritionTabWeeks.GetDay(day).MealPeriodsRows.Select(x => x.Name);            Assert.That(currentMealPeriods, Is.EqualTo(expectedMealPeriods));        }

        [Then(@"Verify save button is not present")]
        public void ThenVerifySaveButtonIsNotPresent()
        {
           Assert.IsFalse(planningTabDays.IsSaveButtonPresent);
        }

        [When(@"Meny Cycle Total is opened")]
        public void WhenMenyCycleTotalIsOpened()
        {
            nutritionTabDays.ClickMCTotalButton();
            nutritionTabDays.WaitForLoad();

        }
    }}