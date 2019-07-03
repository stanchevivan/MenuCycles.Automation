using System.Linq;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class MealMeriodDetailSteps
    {
        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly MealPeriodDetails mealPeriodDetails;
        readonly RecipeSearch recipeSearch;

        public MealMeriodDetailSteps(ScenarioContext scenarioContext, MenuCycleDailyCalendarView menuCycleDailyCalendarView,
                                     ToastNotification notification, MealPeriodDetails mealPeriodDetails,
                                     RecipeSearch recipeSearch)
        {
            this.scenarioContext = scenarioContext;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;
            this.notification = notification;
            this.mealPeriodDetails = mealPeriodDetails;
            this.recipeSearch = recipeSearch;

            this.scenarioContext = scenarioContext;
        }

        [When(@"Details for meal period ""(.*)"" in ""(.*)"" are opened")]
        [Then(@"Details for meal period ""(.*)"" in ""(.*)"" are opened")]
        public void WhenDetailsForMealPeriodInAreOpened(string mealPeriod, string weekDay)
        {
            menuCycleDailyCalendarView.GetDay(weekDay).GetMealPeriodCard(mealPeriod).OpenMealPeriodDetails();
            mealPeriodDetails.WaitForLoad();
            menuCycleDailyCalendarView.WaitPageLoad();
        }

        [When(@"Recipe search is opened")]
        public void WhenRecipeSearchIsOpened()
        {
            mealPeriodDetails.AddRecipe();
        }

        [When(@"Buffet ""(.*)"" is searched")]
        [When(@"Recipe ""(.*)"" is searched")]
        public void RecipeIsSearched(string text)
        {
            recipeSearch.SearchRecipeByName(text);
        }

        [When(@"Recipe ""(.*)"" is added")]
        public void RecipeIsAdded(string text)
        {
            recipeSearch.AddRecipe(text);
            mealPeriodDetails.WaitForSaveButtonToBeEnabled();
        }

        [When(@"Recipe ""(.*)"" is deleted")]
        public void RecipeIsDeleted(string text)
        {
            mealPeriodDetails.GetRecipeCard(text).Delete();
        }

        [When(@"Buffet ""(.*)"" is added")]
        public void BuffetIsAdded(string buffetName)
        {
            recipeSearch.AddBuffet(buffetName);
            mealPeriodDetails.WaitForSaveButtonToBeEnabled();
        }

        [Then(@"Verify items in the meal period are")]
        public void ThenVerifyItemsInTheMealPeriodAre(Table table)
        {
            foreach (TableRow row in table.Rows)
            {
                Assert.That(mealPeriodDetails.GetRecipeCard(row["Name"]).Cost, Is.EqualTo(row["Cost"]));
            }
        }

        [When(@"Buffet ""(.*)"" is expanded")]
        public void WhenBuffetIsExpanded(string buffetName)
        {
            mealPeriodDetails.GetBuffetCard(buffetName).Expand();
        }

        [Then(@"Verify recipes in meal period details for buffet ""(.*)"" are")]
        public void ThenVerifyRecipesInMealPeriodDetailsForBuffetAre(string buffetName, Table table)
        {
            var buffetCard = mealPeriodDetails.GetBuffetCard(buffetName);

            // TODO: Should use ExpandedRecipes related to buffet card, not the whole meal period

            Assert.That(mealPeriodDetails.ExpandedRecipes.Select(x => x.Name), Is.EqualTo(table.Rows.Select(x => x["Name"])));
            Assert.That(mealPeriodDetails.ExpandedRecipes.Select(x => x.Cost), Is.EqualTo(table.Rows.Select(x => x["Cost"])));
        }

        [When(@"Verify items present in the search results are")]
        [Then(@"Verify items present in the search results are")]
        public void VerifyItemsReturnedFromSearchAre(Table table)
        {
            Assert.That(recipeSearch.Recipes.Select(x => x.Title).ToList(), Is.EquivalentTo(table.Rows.Select(x => x["Name"]).ToList()));
            Assert.That(recipeSearch.Recipes.Select(x => x.Cost).ToList(), Is.EquivalentTo(table.Rows.Select(x => x["Cost"]).ToList()));
        }

        [When(@"Verify items in meal period detailed view")]
        [Then(@"Verify items in meal period detailed view")]
        public void VerifyItemsInMealPriodDetailedView(Table table)
        {
            Assert.That(mealPeriodDetails.Recipes.Select(x => x.Title).ToList(), Is.EqualTo(table.Rows.Select(x => x["Name"]).ToList()));
            Assert.That(mealPeriodDetails.Recipes.Select(x => x.Cost).ToList(), Is.EqualTo(table.Rows.Select(x => x["Cost"]).ToList()));
        }

        [When(@"meal period detailed view is closed")]
        [Then(@"meal period detailed view is closed")]
        public void WhenMealPeriodDetailedViewIsClosed()
        {
            mealPeriodDetails.UseCrossButton();
        }

        [When(@"Verify meal period copy button is disabled")]
        [Then(@"Verify meal period copy button is disabled")]
        public void ThenVerifySaveButtonIsDeleted()
        {
            Assert.IsFalse(mealPeriodDetails.IsCopyButtonEnabled, "Copy button is NOT disabled");
        }

        [When(@"Verify meal period delete button is disabled")]
        [Then(@"Verify meal period delete button is disabled")]
        public void ThenVerifyDeleteButtonIsDeleted()
        {
            Assert.IsFalse(mealPeriodDetails.IsDeleteButtonEnabled, "Delete button is NOT disabled");
        }

        [When(@"Verify meal period copy button is enabled")]
        [Then(@"Verify meal period copy button is enabled")]
        public void ThenVerifySaveButtonIsEnabled()
        {
            Assert.IsTrue(mealPeriodDetails.IsCopyButtonEnabled, "Copy button is NOT enabled");
        }

        [When(@"Verify meal period delete button is enabled")]
        [Then(@"Verify meal period delete button is enabled")]
        public void ThenVerifyDeleteButtonIsEnabled()
        {
            Assert.IsTrue(mealPeriodDetails.IsDeleteButtonEnabled, "Delete button is NOT enabled");
        }

        [Then(@"Verify order for item ""(.*)"" is ""(.*)""")]
        public void ThenVerifyOrderForItemIs(string recipeName, int order)
        {
            Assert.That(mealPeriodDetails.ItemCards.FindIndex(x => x.Name == recipeName) + 1, 
                Is.EqualTo(order), "The expected order is different than the actual order");
        }

        [StepDefinition(@"Recipe ""(.*)"" order is moved down ""(.*)"" times")]
        public void WhenRecipeOrderIsMovedDownTimes(string recipeName, int order)
        {
            var card = mealPeriodDetails.ItemCards.First(x => x.Name == recipeName);
            for (int i = 0; i < order; i++)
            {
                card.MoveDown();
            }
        }

        [StepDefinition(@"Recipe ""(.*)"" order is moved up ""(.*)"" times")]
        public void WhenRecipeOrderIsMovedUpTimes(string recipeName, int order)
        {
            var card = mealPeriodDetails.ItemCards.First(x => x.Name == recipeName);
            for (int i = 0; i < order; i++)
            {
                card.MoveUp();
            }
        }

        [StepDefinition(@"Recipe ""(.*)"" order is set to ""(.*)""")]
        public void WhenRecipeOrderIsSetTo(string recipeName, int newOrder)
        {
            var card = mealPeriodDetails.ItemCards.First(x => x.Name == recipeName);
            var currentOrder = mealPeriodDetails.ItemCards.FindIndex(x => x.Name == card.Name);
            newOrder--;

            do
            {
                if (newOrder > currentOrder)
                {
                    card.MoveDown();
                    currentOrder++;

                }
                if (newOrder < currentOrder)
                {
                    card.MoveUp();
                    currentOrder--;
                }

            } while (newOrder != currentOrder);
        }
    }
}