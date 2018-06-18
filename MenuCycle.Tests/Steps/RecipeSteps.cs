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

            Assert.IsNotEmpty(recipe.PlannedQuantity);
            Assert.IsNotEmpty(recipe.CostPerUnit);
            Assert.IsNotEmpty(recipe.TotalCosts);
            Assert.IsNotEmpty(recipe.Type);
            Assert.IsNotEmpty(recipe.PriceModel);
            Assert.IsNotEmpty(recipe.Target);
            Assert.IsNotEmpty(recipe.TaxPercentage);
            Assert.IsNotEmpty(recipe.SellPrice);
        }

        [Then(@"verify the following recipes:")]
        public void CheckAllDataForRecipe(Table table)
        {
            if (!planningTabDays.HasMealPeriods)
            {
                throw new System.Exception($"ERROR: No meal periods for the day ! {planningTabDays.HeaderText}");
            }

            var expectedRecipes = table.CreateSet<RecipeModel>();

            var actualRecipes = new List<RecipeModel>();

            expectedRecipes.ToList().ForEach(
                recipe =>
                actualRecipes.Add(
                    planningTabDays
                    .GetMealPeriod(recipe.MealPeriodName)
                    .GetRecipe(recipe.RecipeTitle)
                    .GetDTO()
            ));

            table.CompareToSet(actualRecipes);
        }

        [Given(@"Price model for recipe ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        [When(@"Price model for recipe ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenPriceModelForRecipeInMealPeriodIsSetTo(string recipeName, string mealPeriod, string priceModel)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .PriceModel = priceModel;
        }

        [Then(@"Target % field for recipe ""(.*)"" in meal period ""(.*)"" is not present")]
        public void ThenTargetFieldIsNotPresent(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName)
                           .IsTargetGPPresent);
        }

        [Then(@"Sell Price for recipe ""(.*)"" in meal period ""(.*)"" is an editable field")]
        public void ThenSellPriceIsChangedFromAuto_CalculatedToEditableField(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName)
                          .IsSellPriceEditable);
        }

        [Given(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        [When(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenTargetGPForRecipeNamedInMealPeriodIsSetTo(string recipeName, string mealPeriod, string value)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
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
                .SellPrice = value;
        }

        [Then(@"SellPrice for recipe named ""(.*)"" in meal period ""(.*)"" is equal to ""(.*)""")]
        public void ThenSellPriceForRecipeNamedInMealPeriodIs(string recipeName, string mealPeriod, string value)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .SellPrice,
                        Is.EqualTo(value));
        }

        [Then(@"CostPerUnit for recipe named ""(.*)"" in meal period ""(.*)"" is equal to ""(.*)""")]
        public void ThenCostPerUnitForRecipeNamedInMealPeriodIs(string recipeName, string mealPeriod, string price)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .CostPerUnit,
                        Is.EqualTo(price));
        }

        [When(@"red border is displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundTargetForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName).IsTargetGPWithRedBorder);
        }

        [When(@"red border is not displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is not displayed around Target% for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundTargetForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).IsTargetGPWithRedBorder);
        }

        [When(@"red border is not displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is not displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundSellPriceForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).SellPriceHasRedBorder);
        }

        [When(@"red border is displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is displayed around Sell Price for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundSellPriceForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName).SellPriceHasRedBorder);
        }

        [Then(@"red border is not displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsNotDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealPeriod)
        {
            Assert.IsFalse(planningTabDays
                           .GetMealPeriod(mealPeriod)
                           .GetRecipe(recipeName).IsPlannedQuantityWithRedBorder);
        }


        [When(@"red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        [Then(@"red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealperiod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealperiod)
                          .GetRecipe(recipeName).IsPlannedQuantityWithRedBorder);
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
                        fieldValue = recipe.Target;
                        break;
                    }
                case "Sell Price":
                    {
                        fieldValue = recipe.SellPrice;
                        break;
                    }
                case "Planned Qty":
                    {
                        fieldValue = recipe.PlannedQuantity;
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
                        .PlannedQtyContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [Then(@"red border and contextual error message ""(.*)"" is displayed for TargetGP field for recipe ""(.*)"" in meal period ""(.*)""")]
        [When(@"red border and contextual error message ""(.*)"" is displayed for TargetGP field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForTargetGPfieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
               .GetMealPeriod(mealPeriod)
               .GetRecipe(recipeName).IsTargetGPWithRedBorder);
            
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .TargetPercentageContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [When(@"red border and contextual error message ""(.*)"" is displayed for Sell Price field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForSellPricefieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
                          .GetMealPeriod(mealPeriod)
                          .GetRecipe(recipeName)
                          .SellPriceHasRedBorder);

            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .SellPriceContextualErrorMessage, Is.EqualTo(errorMessage));
        }

        [When(@"red border and contextual error message ""(.*)"" is displayed for Planned Quantity field for recipe ""(.*)"" in meal period ""(.*)""")]
        public void WhenRedBorderAndContextualErrorMessageIsDisplayedForPlannedQuantityFieldForRecipeInMealPeriod(string errorMessage, string recipeName, string mealPeriod)
        {
            Assert.IsTrue(planningTabDays
              .GetMealPeriod(mealPeriod)
              .GetRecipe(recipeName)
                          .IsPlannedQuantityWithRedBorder);

            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
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
    }
}