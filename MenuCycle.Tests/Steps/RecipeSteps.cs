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
            Assert.IsNotEmpty(recipe.TargetGP);
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
                    .LoadDTO()
            ));

            table.CompareToSet(actualRecipes);
        }

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

        [When(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenTargetGPForRecipeNamedInMealPeriodIsSetTo(string recipeName, string mealPeriod, string value)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .TargetGP = value;
        }

        [When(@"the user focus out")]
        public void WhenTheUserFocusOut()
        {
            planningTabDays.FocusOut();
        }

        [Then(@"TargetGP% for recipe named ""(.*)"" in meal period ""(.*)"" is automatically changed to two decimal number ""(.*)""")]
        public void ThenTargetGPIsAutomaticallyChangedToTwoDecimalNumber(string recipeName, string mealPeriod, string value)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .TargetGP,
                        Is.EqualTo(value));
        }
    }
}