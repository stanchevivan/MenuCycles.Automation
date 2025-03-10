﻿using System;using System.Linq;using MenuCycle.Tests.PageObjects;using NUnit.Framework;using TechTalk.SpecFlow;using TechTalk.SpecFlow.Assist;namespace MenuCycle.Tests.Steps{    [Binding]    public class PostProductionSteps    {        readonly PlanningView planningView;        readonly PlanningTabDays planningTabDays;        readonly PlanningTabWeeks planningTabWeeks;        readonly NutritionTabDays nutritionTabDays;        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;        readonly RecipeSearch recipeSearch;        readonly ToastNotification notification;        readonly ScenarioContext scenarioContext;        readonly PostProductionTabDays postProductionTabDays;        readonly PostProductionTabWeeks postProductionTabWeeks;        public PostProductionSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleDailyCalendarView menuCycleDailyCalendarView,                                   RecipeSearch recipeSearch, ToastNotification notification, PostProductionTabDays postProductionTabDays, PostProductionTabWeeks postProductionTabWeeks)        {            this.planningView = dailyPlanningView;            this.planningTabDays = planningTab;            this.planningTabWeeks = planningTabWeeks;            this.nutritionTabDays = nutritionTab;            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;            this.recipeSearch = recipeSearch;            this.notification = notification;            this.postProductionTabDays = postProductionTabDays;            this.postProductionTabWeeks = postProductionTabWeeks;            this.scenarioContext = scenarioContext;        }        [Then(@"Verify all post production meal periods are expanded")]        public void VerifyAllPostProductionMealPeriodsAreExpanded()        {            Assert.IsTrue(postProductionTabDays.AreAllMealPeriodsExpanded);        }        [Then(@"Verify all post production meal periods are collapsed")]        public void VerifyAllPostProductionMealPeriodsAreCollapsed()        {            Assert.IsTrue(postProductionTabDays.AreAllMealPeriodsCollapsed);        }        [When(@"Post-production meal period ""(.*)"" is collapsed")]        public void WhenMealPeriodIsCollapsed(string periodName)        {            postProductionTabDays.GetMealPeriod(periodName).Collapse();        }        [When(@"Post-production meal period ""(.*)"" is expanded")]        public void WhenMealPeriodIsExpanded(string periodName)        {            postProductionTabDays.GetMealPeriod(periodName).Expand();        }        [Then(@"Verify main data for Meal Period ""(.*)"" is collapsed in Post production days")]        public void ThenMainDataForMealPeriodIsCollapsedInPostProductionDays(string periodName)        {            Assert.IsFalse(postProductionTabDays.GetMealPeriod(periodName).IsExpanded);        }        [Then(@"Verify main data for Meal Period ""(.*)"" is expanded in Post production days")]        public void ThenMainDataForMealPeriodIsExpandedInPostProductionDays(string periodName)        {            Assert.IsTrue(postProductionTabDays.GetMealPeriod(periodName).IsExpanded);        }        [Then(@"Verify planned quantity daily total equals the sum of all meal period totals")]        public void VerifyDailyTotalEqualsTheSumOfAllMealPeriodTotals()        {            var sumOfMealPeriodQuantities = postProductionTabDays.MealPeriods.Sum(x => int.Parse(x.PlannedQuantity));            Assert.That(sumOfMealPeriodQuantities, Is.EqualTo(int.Parse(postProductionTabDays.PlannedQtyTotal)));        }        [When(@"values are entered for recipe ""(.*)"" tariff ""(.*)"" in meal period ""(.*)""")]        public void WhenValuesAreEnteredFor(string recipeName, string tariff, string mealPeriod, Table table)        {            var recipeRow = postProductionTabDays.GetMealPeriod(mealPeriod)            .GetRecipe(recipeName)            .GetRow(tariff);

			if (!tariff.Equals("Recipe Total"))
			{
				recipeRow.QuantitySold = table.Rows[0]["qtySold"];
			}
			else
			{
				recipeRow.QuantityRequisitioned = table.Rows[0]["qtyReqd"];
				recipeRow.QuantityProduced = table.Rows[0]["qtyProd"];
				recipeRow.NoCharge = table.Rows[0]["noCharge"];
				recipeRow.ReturnToStock = table.Rows[0]["returnToStock"];
			}        }

        [Then(@"Verify Wastage is correctly calculated for recipe ""(.*)"" tariff ""(.*)"" in meal period ""(.*)""")]        public void ThenVerifyWastageIsCorrectlyCalculatedForRecipe(string recipeName, string tariff, string mealPeriod)        {
            var recipeRow = postProductionTabDays.GetMealPeriod(mealPeriod)
                 .GetRecipe(recipeName)
                 .GetRow(tariff);            Assert.That(int.Parse(recipeRow.Wastage), Is.EqualTo(            int.Parse(recipeRow.QuantityRequisitioned) + int.Parse(recipeRow.QuantityProduced)
                - int.Parse(recipeRow.QuantitySold) - int.Parse(recipeRow.NoCharge) - int.Parse(recipeRow.ReturnToStock)));        }

        [Then(@"Verify values for recipe ""(.*)"" tariff ""(.*)"" in meal period ""(.*)""")]
        public void ThenVerifyValuesForRecipeTariffInMealPeriod(string recipeName, string tariff, string mealPeriod, Table table)
        {
            var recipeRow = postProductionTabDays.GetMealPeriod(mealPeriod)
            .GetRecipe(recipeName)
            .GetRow(tariff);

            Assert.That(recipeRow.QuantitySold, Is.EqualTo(table.Rows[0]["qtySold"]));
            Assert.That(recipeRow.PlannedQuantity, Is.EqualTo(table.Rows[0]["plannedQty"]));
        }        [Then(@"Verify context errors are present for recipe ""(.*)"" tariff ""(.*)"" in meal period ""(.*)""")]        public void ThenVerifyContextErrorsArePresentForFields(string recipeName, string tariff, string mealPeriod, Table table)        {            var recipeRow = postProductionTabDays.GetMealPeriod(mealPeriod)                 .GetRecipe(recipeName)                 .GetRow(tariff);

            if (!tariff.Equals("Recipe Total"))
            {
                Assert.That(recipeRow.QtySoldContextError, Is.EqualTo(table.Rows[0]["qtySold"]));
            }            else
            {
                Assert.That(recipeRow.QtyProdContextError, Is.EqualTo(table.Rows[0]["qtyProd"]));
                Assert.That(recipeRow.QtyReqdContextError, Is.EqualTo(table.Rows[0]["qtyReqd"]));
                Assert.That(recipeRow.NoChargeContextError, Is.EqualTo(table.Rows[0]["noCharge"]));
                Assert.That(recipeRow.ReturnToStockContextError, Is.EqualTo(table.Rows[0]["returnToStock"]));
            }        }        [When(@"switching to Weekly Post-Production view")]        public void WhenSwitchingToWeeklyPost_ProductionView()        {            planningView.UseWeeksButton();            planningView.WaitForLoad();        }        [Then(@"Verify Weekly Post-production view is open")]        public void ThenVerifyWeeklyPost_ProductionViewIsOpen()        {            Assert.IsTrue(planningView.IsPageLoaded);        }

        [Then(@"Verify Qty Sold input field is disabled for buffet ""(.*)"" in meal period ""(.*)""")]        public void ThenVerifyQtySoldInputFieldIsDisabledForBuffet(string buffetName, string mealPeriod)        {            var buffet = postProductionTabDays.GetMealPeriod(mealPeriod).GetBuffet(buffetName);            Assert.IsFalse(buffet.IsSoldQtyEnabled);        }

        [When(@"local sales report is exported")]        public void LocalSalesReportIsExported()        {            postProductionTabDays.UseExportLocalSalesReportButton();            postProductionTabDays.WaitSpinnerToDisappear();        }        [Then(@"Verify Wastage for buffet ""(.*)"" recipe ""(.*)"" in meal period ""(.*)"" is an editable field")]        public void ThenVerifyWastageInputFieldIsEnabledForBuffetRecipe(string buffetName, string recipeName, string mealPeriod)
        {
            var buffetRecipe = postProductionTabDays.GetMealPeriod(mealPeriod).GetBuffet(buffetName).GetRecipe(recipeName);

            Assert.IsTrue(buffetRecipe.GetFirstRow().IsWastageEnabled);        }

        [Then(@"Verify Wastage for recipe ""(.*)"" in meal period ""(.*)"" is disabled")]        public void ThenVerifyWastageInputFieldIsDisabledForRecipes(string recipeName, string mealPeriod)        {            var recipe = postProductionTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeName);            Assert.IsFalse(recipe.GetFirstRow().IsWastageEnabled);        }

        [Then(@"Verify Qty Sold and No Charge fields for buffet ""(.*)"" recipe ""(.*)"" in meal period ""(.*)"" are not present")]        public void VerifyQtySoldAndNoChargeFieldsAreDisabledForBuffetRecipe(string buffetName, string recipeName, string mealPeriod)        {            var buffetRecipe = postProductionTabDays.GetMealPeriod(mealPeriod).GetBuffet(buffetName).GetRecipe(recipeName);

            Assert.IsFalse(buffetRecipe.GetFirstRow().IsQuantitySoldPresent);            Assert.IsFalse(buffetRecipe.GetFirstRow().IsNoChargePresent);
        }

        [When(@"Wastage value ""(.*)"" is inputed for buffet ""(.*)"" recipe ""(.*)"" in meal period ""(.*)""")]        public void WhenWastageValueIsInputedForBuffetRecipeInMealPeriod(string value, string buffetName, string recipeName, string mealPeriodName)        {            var buffetRecipe = postProductionTabDays                .GetMealPeriod(mealPeriodName)                .GetBuffet(buffetName)                .GetRecipe(recipeName).GetFirstRow();            buffetRecipe.Wastage = value;        }

        [Then(@"Verify contextual error message ""(.*)"" is displayed for Wastage field for buffet ""(.*)"" recipe ""(.*)"" in meal period ""(.*)""")]        public void ThenVerifyContextualErrorMessageIsDisplayedForWastageFieldForBuffetRecipeInMealPeriod(string errorMessage, string buffetName, string recipeName, string mealPeriod)        {            var buffetRecipe = postProductionTabDays                    .GetMealPeriod(mealPeriod)                    .GetBuffet(buffetName)                    .GetRecipe(recipeName)                    .GetFirstRow();            Assert.That(buffetRecipe.WastageContextualError, Is.EqualTo(errorMessage));
        }

        [Then(@"Buffet tariff type is present for buffet ""(.*)"" in meal period ""(.*)""")]        public void TarrifTypeForBuffetIsNotEmpty(string buffetName, string mealPeriod)        {
            var buffetTarrifType = postProductionTabDays
                   .GetMealPeriod(mealPeriod)
                   .GetBuffet(buffetName).TariffName;

            Assert.That(buffetTarrifType, Is.Not.Empty);        }        [Then(@"Verify weekly post-production totals equals the sum of all meal period totals")]        public void VerifyWeeklyPostProductionTotalEqualsTheSumOfAllMealPeriodTotals()        {            int sumOfDaysQtyReq = postProductionTabWeeks.Days.Sum(x => int.Parse(x.DailyTotalQtyRequisitioned));            Assert.That(sumOfDaysQtyReq, Is.EqualTo(int.Parse(postProductionTabWeeks.WeeklyTotalQtyReqd)));
            int sumOfDaysQtyProd = postProductionTabWeeks.Days.Sum(x => int.Parse(x.DailyTotalQtyProduced));            Assert.That(sumOfDaysQtyProd, Is.EqualTo(int.Parse(postProductionTabWeeks.WeeklyTotalQtyProd)));

            int sumOfDaysQtySold = postProductionTabWeeks.Days.Sum(x => int.Parse(x.DailyTotalQtySold));            Assert.That(sumOfDaysQtySold, Is.EqualTo(int.Parse(postProductionTabWeeks.WeeklyTotalQtySold)));

            int sumOfDaysNoChargeApplied = postProductionTabWeeks.Days.Sum(x => int.Parse(x.DailyTotalNoChargeApplied));            Assert.That(sumOfDaysNoChargeApplied, Is.EqualTo(int.Parse(postProductionTabWeeks.WeeklyTotalNoChargeApplied)));

            int sumOfDaysReturnToStock = postProductionTabWeeks.Days.Sum(x => int.Parse(x.DailyTotalReturnToStock));            Assert.That(sumOfDaysReturnToStock, Is.EqualTo(int.Parse(postProductionTabWeeks.WeeklyTotalReturnToStock)));

            int sumOfDaysWastage = postProductionTabWeeks.Days.Sum(x => int.Parse(x.DailyTotalWastage));            Assert.That(sumOfDaysWastage, Is.EqualTo(int.Parse(postProductionTabWeeks.WeeklyTotalWastage)));        }        [Then(@"Verify post-production weekly totals are")]        public void VerifyWeeklyTotalsAre(Table table)        {
            Assert.That(postProductionTabWeeks.WeeklyTotalQtyReqd, Is.EqualTo(table.Rows[0]["qtyReqd"]));            Assert.That(postProductionTabWeeks.WeeklyTotalQtyProd, Is.EqualTo(table.Rows[0]["qtyProd"]));            Assert.That(postProductionTabWeeks.WeeklyTotalQtySold, Is.EqualTo(table.Rows[0]["qtySold"]));            Assert.That(postProductionTabWeeks.WeeklyTotalNoChargeApplied, Is.EqualTo(table.Rows[0]["noCharge"]));            Assert.That(postProductionTabWeeks.WeeklyTotalReturnToStock, Is.EqualTo(table.Rows[0]["returnToStock"]));            Assert.That(postProductionTabWeeks.WeeklyTotalWastage, Is.EqualTo(table.Rows[0]["wastage"]));        }        [Then(@"Verify meal periods for day ""(.*)"" in post-production daily are:")]        public void ThenVerifyMealPeriodsForPostProductionDayAre(string day, Table table)        {            var expectedMealPeriods = table.Rows[0]["mealPeriods"].Split(',');            var currentMealPeriods = postProductionTabDays.MealPeriods.Select(x => x.Name);            Assert.That(currentMealPeriods, Is.EqualTo(expectedMealPeriods));        }        [Then(@"Verify meal periods for day ""(.*)"" week ""(.*)"" in post-production weekly are:")]        public void ThenVerifyMealPeriodsForDayInPostProductionWeeksAre(string day, string week, Table table)        {            var expectedMealPeriods = table.Rows[0]["mealPeriods"].Split(',');            var currentMealPeriods = postProductionTabWeeks.GetDay(day).MealPeriodsRows.Select(x => x.Name);            Assert.That(currentMealPeriods, Is.EqualTo(expectedMealPeriods));        }    }}

