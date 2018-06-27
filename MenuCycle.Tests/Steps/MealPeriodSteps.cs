﻿using System;
using System.Collections.Generic;
using System.Linq;
using MenuCycle.Data.Models;
using MenuCycle.Tests.Models;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

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
        readonly ModalDialogPage modalDialogPage;

        public MealPeriodSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleCalendarView menuCycleCalendarView,
                               CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification, ModalDialogPage modalDialogPage)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTabDays;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTabDays;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;

            this.scenarioContext = scenarioContext;
        }

        [Given(@"a Meal Period for (.*) is added")]
        public void GivenAMealPeriodForIsAddedToAMenuCycle(string weekDayName)
        {
            menuCycleCalendarView.AddMealPeriod(weekDayName);
            createMealPeriod.SelectMealPeriod(scenarioContext.Get<IList<MealPeriods>>().First().Name);
        }

        [Given(@"Meal Period ""(.*)"" is expanded")]
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

        [Given(@"Meal Period names for ""(.*)"" are saved")]
        public void GivenMealPeriodNamesForAreSaved(string weekDay)
        {
            scenarioContext.Add("MealPeriodNames", menuCycleCalendarView.GetMealPeriodNames(weekDay));
        }

        /// <summary>
        /// Must be used with the step "Meal Period colours for ""(.*)"" are saved"
        /// </summary>
        [Then(@"Meal Period names match the calendar view names")]
        public void ThenMealPeriodNamessMatchTheCalendarViewNames()
        {
            Assert.That(planningTabDays.MealPeriods.Select(x => x.Name).ToList(), Is.EqualTo(scenarioContext.Get<IList<string>>("MealPeriodNames")));
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

        [Then(@"number of covers for meal period ""(.*)"" is equal to ""(.*)""")]
        public void NumberOfCoversForMealPeriodIs(string mealPeriodName, string numberOfCovers)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);
            Assert.That(mealPeriod.NumberOfCovers, Is.EqualTo(numberOfCovers));
        }

        [When(@"Open all is clicked")]
        public void WhenOpenAllIsClicked()
        {
            planningTabDays.ExpandAllMealPeriods();
        }

        [When(@"Close all is clicked")]
        public void WhenCloseAllIsClicked()
        {
            planningTabDays.CollapseAllMealPeriods();
        }

        [When(@"all meal periods are expanded")]
        [Then(@"all meal periods are expanded")]
        public void ThenAllMealPeriodsAreExpanded()
        {
            Assert.IsTrue(planningTabDays.AreAllMealPeriodsExpanded);
        }

        [When(@"all meal periods are collapsed")]
        [Then(@"all meal periods are collapsed")]
        public void ThenAllMealPeriodsAreCollapsed()
        {
            Assert.IsTrue(planningTabDays.AreAllMealPeriodsCollapsed);

        }

        [Then(@"Value for fields for meal period ""(.*)"" is")]
        public void TotalPlannedQuantityforMealPeriodIs(string mealPeriodName, Table table)
        {
            dynamic values = table.CreateDynamicInstance();

            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            if (!string.IsNullOrEmpty(Convert.ToString(values.PlannedQty)))
            {
                Assert.That(mealPeriod.PlannedQuantity, Is.EqualTo(Convert.ToString(values.PlannedQty)));
            }

            if (!string.IsNullOrEmpty(Convert.ToString(values.TotalCost)))
            {
                Assert.That(mealPeriod.TotalCost, Is.EqualTo(Convert.ToString(values.TotalCost)));
            }
            if (!string.IsNullOrEmpty(Convert.ToString(values.Revenue)))
            {
                Assert.That(mealPeriod.Revenue, Is.EqualTo(Convert.ToString(values.Revenue)));
            }
            if (!string.IsNullOrEmpty(Convert.ToString(values.ActualGP)))
            {
                Assert.That(mealPeriod.ActualGP, Is.EqualTo(Convert.ToString(values.ActualGP)));
            }
        }

        [Given(@"Modal dialog Yes is selected")]
        [When(@"Modal dialog Yes is selected")]
        public void ModalDialogYes()
        {
            modalDialogPage.UseYesButton();
            menuCycleCalendarView.WaitPageLoad();
        }

        [Given(@"Verify items for meal period ""(.*)"" are \(check count ""(.*)""\)")]
        public void VerifyMealPeriodItems(string mealPeriodName, string checkRecipeCount, Table table)
        {
            var expectedRecipes = table.CreateSet<RecipeModel>();

            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            if (checkRecipeCount.ToUpper() == "YES")
            {
                Assert.AreEqual(expectedRecipes.Count(), mealPeriod.Recipes.Count);
            }
            else if (checkRecipeCount.ToUpper() != "NO")
            {
                throw new Exception("Accepted values are Yes/No!");
            }

            foreach (var expectedRecipe in expectedRecipes)
            {
                mealPeriod.GetRecipe(expectedRecipe.RecipeTitle).GetRow().VerifyData(expectedRecipe);
            }
        }

        [Then(@"""(.*)"" recipies are present in meal period ""(.*)""")]
        public void ThenRecipiesArePresentInMealPeriod(int expectedNumberOfRecipes, string mealPeriodName)
        {
            var actualNumberOfRecipes = planningTabDays
                .GetMealPeriod(mealPeriodName)
                .Recipes.Count;

            Assert.That(actualNumberOfRecipes, Is.EqualTo(expectedNumberOfRecipes));
        }
    }
}