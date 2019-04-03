using System.Collections.Generic;
using System.Linq;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class RecipeSteps
    {
        readonly PlanningTabDays planningTabDays;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;

        public RecipeSteps(ScenarioContext scenarioContext, PlanningTabDays planningTabDays, ToastNotification notification,
                           ModalDialogPage modalDialogPage)
        {
            this.planningTabDays = planningTabDays;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;

            this.scenarioContext = scenarioContext;
        }

        [Then(@"all data is populated for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenAllDataIsPopulatedForRecipeInMealPeriod(string recipeName, string mealPeriodName)
        {
            var recipe = planningTabDays.GetMealPeriod(mealPeriodName).GetRecipe(recipeName);

            Assert.IsNotEmpty(recipe.GetFirstRow().PlannedQuantity);
            Assert.IsNotEmpty(recipe.GetFirstRow().CostPerUnit);
            Assert.IsNotEmpty(recipe.GetFirstRow().TotalCosts);
            Assert.IsNotEmpty(recipe.Type);
            Assert.IsNotEmpty(recipe.GetFirstRow().PriceModel);
            Assert.IsNotEmpty(recipe.GetFirstRow().Target);
            Assert.IsNotEmpty(recipe.GetFirstRow().TaxPercentage);
            Assert.IsNotEmpty(recipe.GetFirstRow().SellPrice);
        }

        [Given(@"Price model for recipe ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        [When(@"Price model for recipe ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenPriceModelForRecipeInMealPeriodIsSetTo(string recipeName, string mealPeriod, string priceModel)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .GetFirstRow()
                .PriceModel = priceModel;
        }

        [Then(@"Verify Target % field for recipe ""(.*)"" in meal period ""(.*)"" is not present")]
        public void ThenTargetFieldIsNotPresent(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName)
                           .GetFirstRow()
                           .IsTargetGPPresent);
        }

        [Then(@"Verify Sell Price for recipe ""(.*)"" in meal period ""(.*)"" is an editable field")]
        public void ThenSellPriceIsChangedFromAuto_CalculatedToEditableField(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName)
                          .GetFirstRow()
                          .IsSellPriceEditable);
        }

        [Given(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        [When(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenTargetGPForRecipeNamedInMealPeriodIsSetTo(string recipeName, string mealPeriod, string value)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .GetFirstRow()
                .Target = value;
        }

        [Given(@"the user focus out")]
        [When(@"the user focus out")]
        public void WhenTheUserFocusOut()
        {
            planningTabDays.FocusOut();
        }

        [Then(@"Verify TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is equal to ""(.*)""")]
        public void ThenTargetGPIsAutomaticallyChangedToTwoDecimalNumber(string recipeName, string mealPeriod, string value)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetFirstRow()
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
                .GetFirstRow()
                .SellPrice = value;
        }

        [Then(@"Verify SellPrice for recipe named ""(.*)"" in meal period ""(.*)"" is equal to ""(.*)""")]
        public void ThenSellPriceForRecipeNamedInMealPeriodIs(string recipeName, string mealPeriod, string value)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetFirstRow()
                        .SellPrice,
                        Is.EqualTo(value));
        }

        [Then(@"Verify CostPerUnit for recipe named ""(.*)"" in meal period ""(.*)"" is equal to ""(.*)""")]
        public void ThenCostPerUnitForRecipeNamedInMealPeriodIs(string recipeName, string mealPeriod, string price)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetFirstRow()
                        .CostPerUnit,
                        Is.EqualTo(price));
        }

        [When(@"Verify red border is displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"Verify red border is displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundTargetForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName).GetFirstRow().IsTargetGPWithRedBorder);
        }

        [When(@"Verify red border is not displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"Verify red border is not displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundTargetForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).GetFirstRow().IsTargetGPWithRedBorder);
        }

        [When(@"Verify red border is not displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"Verify red border is not displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundSellPriceForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).GetFirstRow().SellPriceHasRedBorder);
        }

        [When(@"Verify red border is displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"Verify red border is displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundSellPriceForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName).GetFirstRow().SellPriceHasRedBorder);
        }

        [Then(@"Verify red border is not displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).GetFirstRow().IsPlannedQuantityWithRedBorder);
        }


        [When(@"Verify red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"Verify red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealperiod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealperiod)
                          .GetRecipe(recipeName).GetFirstRow().IsPlannedQuantityWithRedBorder);
        }

        [When(@"Verify field ""(.*)"" for single recipe ""(.*)"" in meal period ""(.*)"" is empty")]
        [Then(@"Verify field ""(.*)"" for single recipe ""(.*)"" in meal period ""(.*)"" is empty")]
        public void ThenTargetPercentageFieldForRecipeInMealPeriodIsEmpty(string field, string recipeName, string mealPeriod)
        {
            var recipe = planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeName);
            string fieldValue;


            switch (field)
            {
                case "Target":
                    {
                        fieldValue = recipe.GetFirstRow().Target;
                        break;
                    }
                case "Sell Price":
                    {
                        fieldValue = recipe.GetFirstRow().SellPrice;
                        break;
                    }
                case "Planned Qty":
                    {
                        fieldValue = recipe.GetFirstRow().PlannedQuantity;
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
                        .GetFirstRow()
                        .PlannedQtyContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [Then(@"Verify red border and contextual error message ""(.*)"" is displayed for TargetGP field for recipe ""(.*)"" in meal period ""(.*)""")]
        [When(@"Verify red border and contextual error message ""(.*)"" is displayed for TargetGP field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForTargetGPfieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
               .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName).GetFirstRow().IsTargetGPWithRedBorder);

            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetFirstRow()
                        .TargetPercentageContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [Then(@"Verify red border and contextual error message ""(.*)"" is displayed for Sell Price field for recipe ""(.*)"" in meal period ""(.*)""")]
        [When(@"Verify red border and contextual error message ""(.*)"" is displayed for Sell Price field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForSellPricefieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName)
                          .GetFirstRow()
                          .SellPriceHasRedBorder);

            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetFirstRow()
                        .SellPriceContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [Then(@"Verify red border and contextual error message ""(.*)"" is displayed for Planned Quantity field for recipe ""(.*)"" in meal period ""(.*)""")]
        [When(@"Verify red border and contextual error message ""(.*)"" is displayed for Planned Quantity field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForPlannedQuantityFieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
              .GetMealPeriod(mealPeriod)
              .GetRecipe(recipeName)
                          .GetFirstRow()
                          .IsPlannedQuantityWithRedBorder);

            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .GetFirstRow()
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

        [When(@"Confirm is selected on the Update Prices dialog")]
        [When(@"Confirm is selected on unsaved changes dialog")]
        public void ConfirmIsSelectedOnUnsavedChangesDialog()
        {
            modalDialogPage.UseApplyButton();
            planningTabDays.WaitForLoader();
        }

        [When(@"Verify Future recipe instances count is (.*)")]
        [Then(@"Verify Future recipe instances count is (.*)")]
        public void FutureRecipeInstancesCountIs(string count)
        {
            modalDialogPage.WaitRecipeCountToAppear();
            Assert.That(count, Is.EqualTo(modalDialogPage.RecipeCount));
        }

        [Then(@"Verify existing types for recipe ""(.*)"" in meal period ""(.*)"" are")]
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

        [Then(@"Verify delete icon is present for recipe ""(.*)"" in meal period ""(.*)"" tariff type ""(.*)""")]
        public void DeleteIconIsPresentForRecipeInMealPeriodTariffType(string recipeTitle, string mealPeriod, string tariffType)
        {
            var recipeRow = planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeTitle)
                .GetTariffTypeRow(tariffType);

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
            var defaultRecipeRow = planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeTitle).GetFirstRow();
            var value = CommonHerlpers.GetValueForFieldInRecipeRow(field, defaultRecipeRow);

            scenarioContext.Add(field, value);
        }

        [When(@"sum of planned qty for all tariffs for recipe ""(.*)"" in meal period ""(.*)"" are saved in context")]
        public void WhenSumOfPlannedQtyForAllTariffsForRecipeInMealPeriodAreSavedInContext(string recipeName, string mealPeriod)
        {
            var sum = planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeName).Rows.Sum(x => int.Parse(x.PlannedQuantity));

            scenarioContext.Add("PlanningScreenPlannedQtySum", sum);
        }

        [Then(@"Verify ""(.*)"" is equal to the value saved in context for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenFieldIsEqualToContextForRecipeInMealPeriod(string field, string recipeTitle, string mealPeriod)
        {
            var defaultRecipeRow = planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeTitle).GetFirstRow();
            var value = CommonHerlpers.GetValueForFieldInRecipeRow(field, defaultRecipeRow);

            Assert.That(value, Is.EqualTo(scenarioContext.Get<string>(field)));
        }

        [Then(@"Verify existing types are same as from the context for recipe ""(.*)"" in meal period ""(.*)""")]
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
            planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeTitle).GetTariffTypeRow(currentTariffType).TariffType = newTariffType;
        }

        [Then(@"Verify delete icon is clicked for recipe ""(.*)"" in meal period ""(.*)"" with tariff type ""(.*)""")]
        public void ThenDeleteIconIsClickedForRecipeInMealPeriodWithTariffType(string recipeName, string mealPeriod, string tariffType)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .GetTariffTypeRow(tariffType).DeleteType();
        }

        [When(@"""(.*)"" for recipe with name ""(.*)"" with TariffType ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenPlannedQuantityForRecipeWithNameWithTariffTypeInMealPeriodIsSetTo(string field, string recipeName, string tariffType, string mealPeriod, string value)
        {
            var recipe = planningTabDays.GetMealPeriod(mealPeriod).GetRecipe(recipeName).GetTariffTypeRow(tariffType);
            string fieldValue;

            switch (field)
            {
                case "Target":
                    {
                        fieldValue = recipe.Target = value;
                        break;
                    }
                case "Sell Price":
                    {
                        fieldValue = recipe.SellPrice = value;
                        break;
                    }
                case "Planned Qty":
                    {
                        fieldValue = recipe.PlannedQuantity = value;
                        break;
                    }
                default:
                    {
                        throw new System.Exception($"Field {field} not found!");
                    }
            }

            planningTabDays.FocusOut();
        }
    }
}