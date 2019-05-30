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
        readonly PlanningTabDays planningTabDays;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;

        public BuffetSteps(ScenarioContext scenarioContext, PlanningTabDays planningTabDays, ToastNotification notification)
        {
            this.planningTabDays = planningTabDays;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
        }

        [When(@"data for recipes is set")]
        public void WhenDataForItemsIsSet(Table table)
        {
            var itemData = table.CreateSet<RecipeModel>();

            RecipeRow item;

            foreach (var data in itemData)
            {

                switch (data.Type)
                {
                    case "RECIPE":
                        {
                            item = planningTabDays.GetMealPeriod(data.MealPeriodName)
                                                  .GetRecipeRowWithTariffType(data.RecipeTitle, data.TariffType);
                            break;
                        }

                    default:
                        {
                            throw new System.Exception($"TYPE is {data.Type}. It should be RECIPE or BUFFET !");
                        }
                }

                item.SetData(data);
            }

            planningTabDays.FocusOut();
        }

        [When(@"data for buffets is set")]
        public void WhenDataForBuffetsIsSet(Table table)
        {
            var itemData = table.CreateSet<RecipeModel>();

            Recipe item;

            foreach (var data in itemData)
            {

                switch (data.Type)
                {
                    case "BUFFET":
                        {
                            item = planningTabDays.GetMealPeriod(data.MealPeriodName)
                                                  .GetBuffet(data.RecipeTitle);
                            break;
                        }

                    default:
                        {
                            throw new System.Exception($"TYPE is {data.Type}. It should be BUFFET !");
                        }
                }

                item.GetFirstRow().SetData(data);
            }

            planningTabDays.FocusOut();
        }

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
                if (expectedItem.Type == "RECIPE" && !string.IsNullOrEmpty(expectedItem.TariffType))
                {
                    item.GetTariffTypeRow(expectedItem.TariffType).VerifyData(expectedItem);
                }

                item.GetFirstRow().VerifyData(expectedItem);
            }
        }

        [StepDefinition(@"Verify data for recipe row is")]
        public void VerifyDataForRecipeRowIs(Table table)
        {
            var expectedItems = table.CreateSet<RecipeModel>();

            RecipeRow item;

            foreach (var expectedItem in expectedItems)
            { 
                item = planningTabDays.GetMealPeriod(expectedItem.MealPeriodName)
                .GetRecipeRowWithTariffType(expectedItem.RecipeTitle, expectedItem.TariffType);

                item.VerifyData(expectedItem);
            }
        }

        [When(@"data for recipes in buffet ""(.*)"" in meal period ""(.*)"" is set")]
        public void WhenDataForRecipesInBuffetInMealPeriodIsSet(string buffetName, string mealPeriod, Table table)
        {
            var itemData = table.CreateSet<RecipeModel>();

            var buffet = planningTabDays.GetMealPeriod(mealPeriod).GetBuffet(buffetName);

            foreach (var data in itemData)
            {
                buffet.GetRecipe(data.RecipeTitle).GetFirstRow().PlannedQuantity = data.PlannedQuantity;
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
                Assert.That(buffet.GetRecipe(data.RecipeTitle).GetFirstRow().PlannedQuantity, Is.EqualTo(data.PlannedQuantity));
            }
        }
    }
}