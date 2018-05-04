using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class MealPeriodSteps
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

        public MealPeriodSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleCalendarView menuCycleCalendarView,
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

        [Given(@"a Meal Period for (.*) is added")]
        public void GivenAMealPeriodForIsAddedToAMenuCycle(string weekDayName)
        {
            menuCycleCalendarView.AddMealPeriod(weekDayName);
            createMealPeriod.SelectMealPeriod(scenarioContext.Get<IList<MealPeriods>>().First().Name);
        }

        [When(@"Meal Period ""(.*)"" is expanded")]
        public void WhenMealPeriodIsExpanded(string periodName)
        {
            planningTabDays.ExpandMealPeriod(periodName);
        }

        [When(@"Meal Period ""(.*)"" is collapsed")]
        public void WhenMealPeriodIsCollapsed(string periodName)
        {
            planningTabDays.CollapseMealPeriod(periodName);
        }

        [Then(@"main data for Meal Period ""(.*)"" is collapsed")]
        public void ThenMainDataForMealPeriodIsCollapsed(string periodName)
        {
            Assert.IsFalse(planningTabDays.IsMealPeriodExpanded(periodName));
        }

        [Then(@"main data for Meal Period ""(.*)"" is expanded")]
        public void ThenMainDataForMealPeriodIsShown(string periodName)
        {
            Assert.IsTrue(planningTabDays.IsMealPeriodExpanded(periodName));
        }

        [Given(@"Meal Period colours for ""(.*)"" are saved")]
        public void GivenMealPeriodColoursForAreSaved(string weekDay)
        {
            scenarioContext.Add("MealPeriodColours", menuCycleCalendarView.GetMealPeriodColours(weekDay));
        }

        /// <summary>
        /// Must be used with the step "Meal Period colours for ""(.*)"" are saved"
        /// </summary>
        [Then(@"Meal Period colours match the calendar view colours")]
        public void ThenMealPeriodColoursMatchTheCalendarViewColours()
        {
            Assert.That(planningTabDays.MealPeriodColours, Is.EqualTo(scenarioContext.Get<IList<string>>("MealPeriodColours")));
        }

        /// <summary>
        /// Checks that meal period has recipe with certain name.
        /// </summary>
        /// <param name="recipeTitle">Recipe name.</param>
        /// <param name="mealPeriodName">Meal period name.</param>
        [Then(@"recipe named ""(.*)"" is present for meal period ""(.*)""")]
        public void ThenRecipeNamedIsPresentForMealPeriod(string recipeTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.IsTrue(mealPeriod.Recipes.Any(a => a.Title == recipeTitle));
        }

        [Then(@"recipe colour for ""(.*)"" match the colour for meal period ""(.*)""")]
        public void ThenRecipeColourForIsTheSameAsTheColourForMealPeriod(string recipeName, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.That(mealPeriod.Colour, Is.EqualTo(mealPeriod.GetRecipe(recipeName).Colour));
        }

        /// <summary>
        /// Checks that meal period has a la carte with certain name.
        /// </summary>
        /// <param name="aLaCarteTitle">A La Carte name.</param>
        /// <param name="mealPeriodName">Meal period name.</param>
        [Then(@"a la carte named ""(.*)"" is present for meal period ""(.*)""")]
        public void ThenALaCarteNamedIsPresentForMealPeriod(string aLaCarteTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.IsTrue(mealPeriod.ALaCartes.Any(a => a.Title == aLaCarteTitle));
        }

        [Then(@"a la carte colour for ""(.*)"" match the colour for meal period ""(.*)""")]
        public void ThenALaCarteColourForIsTheSameAsTheColourForMealPeriod(string aLaCarteTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.That(mealPeriod.Colour, Is.EqualTo(mealPeriod.GetALaCarte(aLaCarteTitle).Colour));
        }

        /// <summary>
        /// Checks that meal period has buffet with certain name.
        /// </summary>
        /// <param name="buffetTitle">Buffet name.</param>
        /// <param name="mealPeriodName">Meal period name.</param>
        [Then(@"buffet named ""(.*)"" is present for meal period ""(.*)""")]
        public void ThenBuffetNamedIsPresentForMealPeriod(string buffetTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.IsTrue(mealPeriod.Buffets.Any(a => a.Title == buffetTitle));
        }

        [Then(@"buffet colour for ""(.*)"" match the colour for meal period ""(.*)""")]
        public void ThenBuffetColourForIsTheSameAsTheColourForMealPeriod(string buffetTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.That(mealPeriod.Colour, Is.EqualTo(mealPeriod.GetBuffet(buffetTitle).Colour));
        }

        [Then(@"in meal period ""(.*)"" all recipe colours inside ""(.*)"" match the A La Carte colour")]
        public void AllRecipeColoursInsideAreTheSameAsTheALaCarteColour(string mealPeriodName, string aLaCarteTitle)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);
            var aLaCarte = mealPeriod.GetALaCarte(aLaCarteTitle);

            Assert.IsTrue(aLaCarte.Recipes.All(r => r.Colour == aLaCarte.Colour));
        }

        [Then(@"in meal period ""(.*)"" all recipe colours inside ""(.*)"" match the buffet colour")]
        public void AllRecipeColoursInsideAreTheSameAsBuffetColour(string mealPeriodName, string buffetTitle)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);
            var buffet = mealPeriod.GetBuffet(buffetTitle);

            Assert.IsTrue(buffet.Recipes.All(r => r.Colour == buffet.Colour));
        }

        [Then(@"number of covers for meal period ""(.*)"" is ""(.*)""")]
        public void NumberOfCoversForMealPeriodIs(string mealPeriodName, string numberOfCoves)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.That(mealPeriod.NumberOfCovers, Is.EqualTo(numberOfCoves));
        }
    }
}