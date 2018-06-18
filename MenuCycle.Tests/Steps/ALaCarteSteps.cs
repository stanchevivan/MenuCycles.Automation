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
    public class ALaCarteSteps
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

        public ALaCarteSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleCalendarView menuCycleCalendarView,
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

        [When(@"data for recipes in a la carte ""(.*)"" in meal period ""(.*)"" is set")]
        public void WhenDataForRecipesInALaCarteInMealPeriodIsSet(string alacarteName, string mealPeriod, Table table)
        {
            var recipesData = table.CreateSet<RecipeModel>();

            var alacarte = planningTabDays.GetMealPeriod(mealPeriod).GetALaCarte(alacarteName);

            foreach (var recipeData in recipesData)
            {
                alacarte.GetRecipe(recipeData.RecipeTitle)
                        .GetRow()
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
                        .GetRow()
                        .VerifyData(recipeData)
            );
        }
    }
}