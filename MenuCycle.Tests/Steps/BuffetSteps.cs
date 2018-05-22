using MenuCycle.Tests.Models;
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
        readonly MenuCycleCalendarView menuCycleCalendarView;
        readonly CreateMealPeriod createMealPeriod;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;

        public BuffetSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleCalendarView menuCycleCalendarView,
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

        [When(@"data for items is set")]
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
                    case "A LA CARTE":
                        {
                            item = planningTabDays.GetMealPeriod(data.MealPeriodName)
                                                  .GetALaCarte(data.RecipeTitle);
                            break;
                        }

                    default:
                        {
                            item = planningTabDays.GetMealPeriod(data.MealPeriodName)
                                                  .GetRecipe(data.RecipeTitle);
                            break;
                        }
                }

                if (data.PlannedQuantity != null) item.PlannedQuantity = data.PlannedQuantity;

                if (data.TariffType != null) item.TariffType = data.TariffType;

                if (data.PriceModel != null) item.PriceModel = data.PriceModel;

                if (data.Target != null) 
                {
                    if (item.PriceModel == "GP" || item.PriceModel == "Markup")
                    {
                        item.Target = data.Target;
                    }
                    else
                    {
                        throw new System.Exception($"Price model is {item.PriceModel} (Target field is not present)!");
                    }
                }

                if (data.SellPrice != null) 
                {
                    if (item.PriceModel == "Fixed")
                    {
                        item.SellPrice = data.SellPrice;
                    }
                    else
                    {
                        throw new System.Exception($"Price model is {item.PriceModel} (Sell Price field is not present)!");
                    }
                }

                if (data.TaxPercentage != null) item.TaxPercentage = data.TaxPercentage;
            }

            planningTabDays.FocusOut();
        }

        [When(@"Verify data for items is")]
        [Then(@"Verify data for items is")]
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
                    case "A LA CARTE":
                        {
                            item = planningTabDays.GetMealPeriod(expectedItem.MealPeriodName)
                                                  .GetALaCarte(expectedItem.RecipeTitle);
                            break;
                        }

                    default:
                        {
                            item = planningTabDays.GetMealPeriod(expectedItem.MealPeriodName)
                                                  .GetRecipe(expectedItem.RecipeTitle);
                            break;
                        }
                }

                if (expectedItem.PlannedQuantity != null)
                {
                    Assert.That(item.PlannedQuantity, Is.EqualTo(expectedItem.PlannedQuantity));
                }

                if (expectedItem.CostPerUnit != null)
                {
                    Assert.That(item.CostPerUnit, Is.EqualTo(expectedItem.CostPerUnit));
                }

                if (expectedItem.TotalCosts != null)
                {
                    Assert.That(item.TotalCosts, Is.EqualTo(expectedItem.TotalCosts));
                }

                if (expectedItem.TariffType != null)
                {
                    Assert.That(item.TariffType, Is.EqualTo(expectedItem.TariffType));
                }

                if (expectedItem.PriceModel != null)
                {
                    Assert.That(item.PriceModel, Is.EqualTo(expectedItem.PriceModel));
                }

                if (expectedItem.Target != null)
                {
                    Assert.That(item.Target, Is.EqualTo(expectedItem.Target));
                }

                if (expectedItem.TaxPercentage != null)
                {
                    Assert.That(item.TaxPercentage, Is.EqualTo(expectedItem.TaxPercentage));
                }

                if (expectedItem.SellPrice != null)
                {
                    Assert.That(item.SellPrice, Is.EqualTo(expectedItem.SellPrice));
                }

                if (expectedItem.Revenue != null)
                {
                    Assert.That(item.Revenue, Is.EqualTo(expectedItem.Revenue));
                }

                if (expectedItem.ActualGP != null)
                {
                    Assert.That(item.ActualGP, Is.EqualTo(expectedItem.ActualGP));
                }
            }
        }

        [When(@"data for recipes in buffet ""(.*)"" in meal period ""(.*)"" is set")]
        public void WhenDataForRecipesInBuffetInMealPeriodIsSet(string buffetName, string mealPeriod, Table table)
        {
            var itemData = table.CreateSet<RecipeModel>();

            var buffet = planningTabDays.GetMealPeriod(mealPeriod).GetBuffet(buffetName);

            foreach (var data in itemData)
            {
                buffet.GetRecipe(data.RecipeTitle).PlannedQuantity = data.PlannedQuantity;
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
                Assert.That(buffet.GetRecipe(data.RecipeTitle).PlannedQuantity, Is.EqualTo(data.PlannedQuantity));
            }
        }
    }
}