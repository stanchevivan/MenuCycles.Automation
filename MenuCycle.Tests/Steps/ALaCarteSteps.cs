using System.Linq;
using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class ALaCarteSteps
    {
        readonly PlanningTabDays planningTabDays;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;

        public ALaCarteSteps(ScenarioContext scenarioContext, PlanningTabDays planningTabDays, ToastNotification notification)
        {
            this.planningTabDays = planningTabDays;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
        }

        [When(@"data for recipes in a la carte ""(.*)"" in meal period ""(.*)"" is set")]
        public void WhenDataForRecipesInALaCarteInMealPeriodIsSet(string alacarteName, string mealPeriod, Table table)
        {
            var recipesData = table.CreateSet<RecipeModel>();

            var alacarte = planningTabDays.GetMealPeriod(mealPeriod).GetALaCarte(alacarteName);

            foreach (var recipeData in recipesData)
            {
                alacarte.GetRecipe(recipeData.RecipeTitle)
                        .GetFirstRow()
                        .SetData(recipeData);
            }

            planningTabDays.FocusOut();
        }

        [Then(@"Verify data for recipes in a la carte ""(.*)"" in meal period ""(.*)"" is")]
        public void ThenVerifyDataForRecipesInBuffetInMealPeriodIs(string alacarteName, string mealPeriod, Table table)
        {
            var recipiesData = table.CreateSet<RecipeModel>();
            var alacarte = planningTabDays.GetMealPeriod(mealPeriod).GetALaCarte(alacarteName);

            recipiesData.ToList().ForEach(
                recipeData =>
                    planningTabDays
                .GetMealPeriod(mealPeriod)
                        .GetALaCarte(alacarteName)
                        .GetRecipe(recipeData.RecipeTitle)
                        .GetFirstRow()
                        .VerifyData(recipeData)
            );
        }
    }
}