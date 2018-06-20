using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class RecipeSteps
    {
        readonly PlanningView dailyPlanningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleCalendarView menuCycleCalendarView;
        readonly CreateMealPeriod createMealPeriod;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;

        public RecipeSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleCalendarView menuCycleCalendarView,
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTabDays;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTabDays;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
        }

        [Then(@"all data is populated for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenAllDataIsPopulatedForRecipeInMealPeriod(string recipeName, string mealPeriodName)
        {
            var recipe = planningTabDays.GetMealPeriod(mealPeriodName).GetRecipe(recipeName);

            Assert.IsNotEmpty(recipe.GetRow().PlannedQuantity);
            Assert.IsNotEmpty(recipe.GetRow().CostPerUnit);
            Assert.IsNotEmpty(recipe.GetRow().TotalCosts);
            Assert.IsNotEmpty(recipe.Type);
            Assert.IsNotEmpty(recipe.GetRow().PriceModel);
            Assert.IsNotEmpty(recipe.GetRow().Target);
            Assert.IsNotEmpty(recipe.GetRow().TaxPercentage);
            Assert.IsNotEmpty(recipe.GetRow().SellPrice);
        }

        [Given(@"Price model for recipe ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        [When(@"Price model for recipe ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenPriceModelForRecipeInMealPeriodIsSetTo(string recipeName, string mealPeriod, string priceModel)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .GetRow()
                .PriceModel = priceModel;
        }

        [Then(@"Target % field for recipe ""(.*)"" in meal period ""(.*)"" is not present")]
        public void ThenTargetFieldIsNotPresent(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName)
                           .GetRow()
                           .IsTargetGPPresent);
        }

        [Then(@"Sell Price for recipe ""(.*)"" in meal period ""(.*)"" is an editable field")]
        public void ThenSellPriceIsChangedFromAuto_CalculatedToEditableField(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName)
                          .GetRow()
                          .IsSellPriceEditable);
        }

        [Given(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        [When(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenTargetGPForRecipeNamedInMealPeriodIsSetTo(string recipeName, string mealPeriod, string value)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .GetRow()
                .Target = value;
        }

        [Given(@"the user focus out")]
        [When(@"the user focus out")]
        public void WhenTheUserFocusOut()
        {
            planningTabDays.FocusOut();
        }

        [Then(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is equal to ""(.*)""")]
        public void ThenTargetGPIsAutomaticallyChangedToTwoDecimalNumber(string recipeName, string mealPeriod, string value)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetRow()
                        .Target,
                        Is.EqualTo(value));
        }

        [Given(@"SellPrice for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        [When(@"SellPrice for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenSellPriceForRecipeNamedInMealPeriodIsSetTo(string recipeName, string mealPeriod, string value)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .GetRow()
                .SellPrice = value;
        }

        [Then(@"SellPrice for recipe named ""(.*)"" in meal period ""(.*)"" is equal to ""(.*)""")]
        public void ThenSellPriceForRecipeNamedInMealPeriodIs(string recipeName, string mealPeriod, string value)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetRow()
                        .SellPrice,
                        Is.EqualTo(value));
        }

        [Then(@"CostPerUnit for recipe named ""(.*)"" in meal period ""(.*)"" is equal to ""(.*)""")]
        public void ThenCostPerUnitForRecipeNamedInMealPeriodIs(string recipeName, string mealPeriod, string price)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetRow()
                        .CostPerUnit,
                        Is.EqualTo(price));
        }

        [When(@"red border is displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundTargetForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName).GetRow().IsTargetGPWithRedBorder);
        }

        [When(@"red border is not displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is not displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundTargetForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).GetRow().IsTargetGPWithRedBorder);
        }

        [When(@"red border is not displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is not displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundSellPriceForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).GetRow().SellPriceHasRedBorder);
        }

        [When(@"red border is displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundSellPriceForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName).GetRow().SellPriceHasRedBorder);
        }

        [Then(@"red border is not displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).GetRow().IsPlannedQuantityWithRedBorder);
        }


        [When(@"red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealperiod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealperiod)
                          .GetRecipe(recipeName).GetRow().IsPlannedQuantityWithRedBorder);
        }

        [When(@"field ""(.*)"" for single recipe ""(.*)"" in meal period ""(.*)"" is empty")]
        [Then(@"field ""(.*)"" for single recipe ""(.*)"" in meal period ""(.*)"" is empty")]
        public void ThenTargetPercentageFieldForRecipeInMealPeriodIsEmpty(string field, string recipeName, string mealPeriod)
        {
            var recipe = planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeName);
            string fieldValue;


            switch (field)
            {
                case "Target":
                    {
                        fieldValue = recipe.GetRow().Target;
                        break;
                    }
                case "Sell Price":
                    {
                        fieldValue = recipe.GetRow().SellPrice;
                        break;
                    }
                case "Planned Qty":
                    {
                        fieldValue = recipe.GetRow().PlannedQuantity;
                        break;
                    }
                default:
                    {
                        throw new System.Exception($"Verification for field {field} is not implemented!");
                    }
            }

            Assert.IsEmpty(fieldValue);
        }

        [When(@"contextual error message ""(.*)"" is displayed under planned quantity field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenContextualErrorMessageIsDisplayedUnderPlannedQuantityFieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetRow()
                        .PlannedQtyContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [Then(@"red border and contextual error message ""(.*)"" is displayed for TargetGP field for recipe ""(.*)"" in meal period ""(.*)""")]
        [When(@"red border and contextual error message ""(.*)"" is displayed for TargetGP field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForTargetGPfieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
               .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName).GetRow().IsTargetGPWithRedBorder);

            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetRow()
                        .TargetPercentageContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [When(@"red border and contextual error message ""(.*)"" is displayed for Sell Price field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForSellPricefieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName)
                          .GetRow()
                          .SellPriceHasRedBorder);

            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetRow()
                        .SellPriceContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [When(@"red border and contextual error message ""(.*)"" is displayed for Planned Quantity field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForPlannedQuantityFieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
              .GetMealPeriod(mealPeriod)
              .GetRecipe(recipeName)
                          .GetRow()
                          .IsPlannedQuantityWithRedBorder);

            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetRow()
                        .PlannedQtyContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [When(@"Price is updated for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenPriceIsUpdatedForRecipe(string recipe, string mealPeriod)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipe)
                .UseUpdatePricesButton();

            planningTabDays.ConfirmDialog();
        }

        [When(@"Update prices button is clicked for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenUpdatePricesButtonIsClickedForRecipe(string recipe, string mealPeriod)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipe)
                .UseUpdatePricesButton();
        }

        [When(@"Confirm is selected on unsaved changes dialog")]
        public void ConfirmIsSelectedOnUnsavedChangesDialog()
        {
            planningTabDays.ConfirmDialog();
        }

        [Then(@"Existing types for recipe ""(.*)"" in meal period ""(.*)"" are")]
        public void ExistingTypesForRecipeInMealPeriodAre(string recipeTitle, string mealPeriod, Table table)
        {
            var expectedValues = table.Rows.Select(x => x["TariffType"]).ToList();

            var recipe = planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeTitle);

            var actualValues = recipe.Rows.Select(x => x.TariffType).ToList();

            Assert.That(actualValues, Is.EqualTo(expectedValues));
        }

        [Given(@"Add type is clicked for recipe ""(.*)"" in meal period ""(.*)""")]
        [When(@"Add type is clicked for recipe ""(.*)"" in meal period ""(.*)""")]
        public void GivenAddTypeIsClickedForRecipeInMealPeriod(string recipeTitle, string mealPeriod)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeTitle)
                .AddType();
        }

        [Then(@"delete icon is present for recipe ""(.*)"" in meal period ""(.*)"" tariff type ""(.*)""")]
        public void DeleteIconIsPresentForRecipeInMealPeriodTariffType(string recipeTitle, string mealPeriod, string tariffType)
        {
            var recipeRow = planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeTitle)
                .GetRow(tariffType);

            Assert.IsTrue(recipeRow.IsDeleteIconPresent);
        }

        [When(@"types are saved in context for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenTypesAreSavedInContextForRecipeInMealPeriod(string recipeTitle, string mealPeriod)
        {
            var tariffTypes = planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeTitle)
                .Rows.Select(x => x.TariffType).ToList();

            scenarioContext.Add("tariffTypes", tariffTypes);
        }

        [When(@"""(.*)"" is saved in context for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenFieldAreSavedInContextForRecipeInMealPeriod(string field, string recipeTitle, string mealPeriod)
        {
            var defaultRecipeRow = planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeTitle).GetRow();
            var value = CommonHerlpers.GetValueForFieldInRecipeRow(field, defaultRecipeRow);

            scenarioContext.Add(field, value);
        }

        [Then(@"""(.*)"" is equal to the value saved in context for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenFieldIsEqualToContextForRecipeInMealPeriod(string field, string recipeTitle, string mealPeriod)
        {
            var defaultRecipeRow = planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeTitle).GetRow();
            var value = CommonHerlpers.GetValueForFieldInRecipeRow(field, defaultRecipeRow);

            Assert.That(value, Is.EqualTo(scenarioContext.Get<string>(field)));
        }

        [Then(@"existing types are same as from the context for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenExistingTypesAreSameAsFromTheContextForRecipeInMealPeriod(string recipeTitle, string mealPeriod)
        {
            var expectedTariffTypes = scenarioContext.Get<IList<string>>("tariffTypes");

            var actualTariffTypes = planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeTitle)
                .Rows.Select(x => x.TariffType).ToList();

            Assert.That(actualTariffTypes, Is.EqualTo(expectedTariffTypes));
        }

        [When(@"TariffType is set to ""(.*)"" for recipe ""(.*)"" with current TariffType ""(.*)"" in meal period ""(.*)""")]
        public void ChangeTariffTypeForSingleRecipe(string newTariffType, string recipeTitle, string currentTariffType, string mealPeriod)
        {
            planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeTitle).GetRow(currentTariffType).TariffType = newTariffType;
        }
    }
}