﻿using System;
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
    public class MealPeriodSteps
    {
        readonly PlanningView dailyPlanningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly ModalDialogPage modalDialogPage;
        readonly CommonElements commonElements;
        readonly MealPeriodDetails mealPeriodDetails;

        public MealPeriodSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleDailyCalendarView menuCycleDailyCalendarView, RecipeSearch recipeSearch, ToastNotification notification, ModalDialogPage modalDialogPage, CommonElements commonElements, MealPeriodDetails mealPeriodDetails)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.planningTabDays = planningTabDays;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTabDays;
            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;
            this.recipeSearch = recipeSearch;
            this.notification = notification;
            this.modalDialogPage = modalDialogPage;
            this.commonElements = commonElements;
            this.mealPeriodDetails = mealPeriodDetails;

            this.scenarioContext = scenarioContext;
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

        [Then(@"Verify main data for Meal Period ""(.*)"" is collapsed")]
        public void ThenMainDataForMealPeriodIsCollapsed(string periodName)
        {
            Assert.IsFalse(planningTabDays.IsMealPeriodExpanded(periodName));
        }

        [Then(@"Verify main data for Meal Period ""(.*)"" is expanded")]
        public void ThenMainDataForMealPeriodIsShown(string periodName)
        {
            Assert.IsTrue(planningTabDays.IsMealPeriodExpanded(periodName));
        }

        [Given(@"Meal Period colours for ""(.*)"" are saved")]
        public void GivenMealPeriodColoursForAreSaved(string weekDay)
        {
            scenarioContext.Add("MealPeriodColours", menuCycleDailyCalendarView.GetMealPeriodColours(weekDay));
        }

        /// <summary>
        /// Must be used with the step "Meal Period colours for ""(.*)"" are saved"
        /// </summary>
        [Then(@"Verify Meal Period colours match the calendar view colours")]
        public void ThenMealPeriodColoursMatchTheCalendarViewColours()
        {
            Assert.That(planningTabDays.MealPeriodColours, Is.EqualTo(scenarioContext.Get<IList<string>>("MealPeriodColours")));
        }

        [Given(@"Meal Period names for ""(.*)"" are saved")]
        public void GivenMealPeriodNamesForAreSaved(string weekDay)
        {
            scenarioContext.Add("MealPeriodNames", menuCycleDailyCalendarView.GetMealPeriodNames(weekDay));
        }

        /// <summary>
        /// Must be used with the step "Meal Period colours for ""(.*)"" are saved"
        /// </summary>
        [Then(@"Verify Meal Period names match the calendar view names")]
        public void ThenMealPeriodNamessMatchTheCalendarViewNames()
        {
            Assert.That(planningTabDays.MealPeriods.Select(x => x.Name).ToList(), Is.EqualTo(scenarioContext.Get<IList<string>>("MealPeriodNames")));
        }

        /// <summary>
        /// Checks that meal period has recipe with certain name.
        /// </summary>
        /// <param name="recipeTitle">Recipe name.</param>
        /// <param name="mealPeriodName">Meal period name.</param>
        [Then(@"Verify recipe named ""(.*)"" is present for meal period ""(.*)""")]
        public void ThenRecipeNamedIsPresentForMealPeriod(string recipeTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.IsTrue(mealPeriod.Recipes.Any(a => a.Title == recipeTitle));
        }

        [Then(@"Verify recipe colour for ""(.*)"" match the colour for meal period ""(.*)""")]
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
        [Then(@"Verify a la carte named ""(.*)"" is present for meal period ""(.*)""")]
        public void ThenALaCarteNamedIsPresentForMealPeriod(string aLaCarteTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.IsTrue(mealPeriod.ALaCartes.Any(a => a.Title == aLaCarteTitle));
        }

        [Then(@"Verify a la carte colour for ""(.*)"" match the colour for meal period ""(.*)""")]
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
        [Then(@"Verify buffet named ""(.*)"" is present for meal period ""(.*)""")]
        public void ThenBuffetNamedIsPresentForMealPeriod(string buffetTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.IsTrue(mealPeriod.Buffets.Any(a => a.Title == buffetTitle));
        }

        [Then(@"Verify buffet colour for ""(.*)"" match the colour for meal period ""(.*)""")]
        public void ThenBuffetColourForIsTheSameAsTheColourForMealPeriod(string buffetTitle, string mealPeriodName)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            Assert.That(mealPeriod.Colour, Is.EqualTo(mealPeriod.GetBuffet(buffetTitle).Colour));
        }

        [Then(@"Verify in meal period ""(.*)"" all recipe colours inside ""(.*)"" match the A La Carte colour")]
        public void AllRecipeColoursInsideAreTheSameAsTheALaCarteColour(string mealPeriodName, string aLaCarteTitle)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);
            var aLaCarte = mealPeriod.GetALaCarte(aLaCarteTitle);

            Assert.IsTrue(aLaCarte.Recipes.All(r => r.Colour == aLaCarte.Colour));
        }

        [Then(@"Verify in meal period ""(.*)"" all recipe colours inside ""(.*)"" match the buffet colour")]
        public void AllRecipeColoursInsideAreTheSameAsBuffetColour(string mealPeriodName, string buffetTitle)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);
            var buffet = mealPeriod.GetBuffet(buffetTitle);

            Assert.IsTrue(buffet.Recipes.All(r => r.Colour == buffet.Colour));
        }

        [Then(@"Verify number of covers for meal period ""(.*)"" is equal to ""(.*)""")]
        public void NumberOfCoversForMealPeriodIs(string mealPeriodName, string numberOfCovers)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);
            Assert.That(mealPeriod.NumberOfCovers, Is.EqualTo(numberOfCovers));
        }

        [When(@"Expand all is clicked")]
        [Then(@"Expand all is clicked")]
        public void WhenOpenAllIsClicked()
        {
            commonElements.UseExpandAllButton();
            planningTabDays.WaitSpinnerToDisappear();
            //planningTabDays.WaitMеаlPeriodsToAppear();
        }

        [When(@"Collapse all is clicked")]
        [Then(@"Collapse all is clicked")]
        public void WhenCloseAllIsClicked()
        {
            commonElements.UseCollapseAllButton();
            //planningTabDays.WaitMеаlPeriodsToDisappear();
        }

        [When(@"Verify all meal periods are expanded in Daily Planning")]
        [Then(@"Verify all meal periods are expanded in Daily Planning")]
        public void AllMealPeriodsAreExpandedInDailyPlanning()
        {
            Assert.IsTrue(planningTabDays.AreAllMealPeriodsExpanded);
        }

        [When(@"Verify all meal periods are collapsed in Daily Planning")]
        [Then(@"Verify all meal periods are collapsed in Daily Planning")]
        public void AllMealPeriodsAreCollapsedInDailyPlanning()
        {
            Assert.IsTrue(planningTabDays.AreAllMealPeriodsCollapsed);
        }

        [When(@"Verify all meal periods are expanded in Daily Calendar")]
        [Then(@"Verify all meal periods are expanded in Daily Calendar")]
        public void AllMealPeriodsAreExpandedInDailyCalendar()
        {
            Assert.IsTrue(menuCycleDailyCalendarView.AreAllMealPeriodsExpanded, "Meal periods are not expanded");
        }

        [When(@"Verify all meal periods are collapsed in Daily Calendar")]
        [Then(@"Verify all meal periods are collapsed in Daily Calendar")]
        public void AllMealPeriodsAreCollapsedInDailyCalendar()
        {
            Assert.IsFalse(menuCycleDailyCalendarView.AreAllMealPeriodsExpanded, "Meal periods are not collapsed");
        }

        [Then(@"Verify value for fields for meal period ""(.*)"" is")]
        public void TotalPlannedQuantityforMealPeriodIs(string mealPeriodName, Table table)
        {
            var mealPeriod = planningTabDays.GetMealPeriod(mealPeriodName);

            if (!string.IsNullOrEmpty(table.Rows[0]["PlannedQty"]))
            {
                Assert.That(mealPeriod.PlannedQuantity, Is.EqualTo(table.Rows[0]["PlannedQty"]));
            }

            if (!string.IsNullOrEmpty(table.Rows[0]["TotalCost"]))
            {
                Assert.That(mealPeriod.TotalCost, Is.EqualTo(table.Rows[0]["TotalCost"]));
            }
            if (!string.IsNullOrEmpty(table.Rows[0]["Revenue"]))
            {
                Assert.That(mealPeriod.Revenue, Is.EqualTo(table.Rows[0]["Revenue"]));
            }
            if (!string.IsNullOrEmpty(table.Rows[0]["ActualGP"]))
            {
                Assert.That(mealPeriod.ActualGP, Is.EqualTo(table.Rows[0]["ActualGP"]));
            }
        }

        [StepDefinition(@"Modal dialog Yes is selected")]
        public void ModalDialogYes()
        {
            modalDialogPage.UseYesButton();
            modalDialogPage.WaitToDisappear();
            dailyPlanningView.WaitSpinnerToDisappear();
        }

        [StepDefinition(@"Calendar Modal dialog Yes is selected")]
        public void ModalDialogYesCalendar()
        {
            modalDialogPage.UseYesButton();
            modalDialogPage.WaitToDisappear();
            planningTabDays.WaitSpinnerToDisappear();
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
                mealPeriod.GetRecipe(expectedRecipe.RecipeTitle).GetFirstRow().VerifyData(expectedRecipe);
            }
        }

        [Then(@"Verify ""(.*)"" recipies are present in meal period ""(.*)""")]
        public void ThenRecipiesArePresentInMealPeriod(int expectedNumberOfRecipes, string mealPeriodName)
        {
            var actualNumberOfRecipes = planningTabDays
                .GetMealPeriod(mealPeriodName)
                .Recipes.Count;

            Assert.That(actualNumberOfRecipes, Is.EqualTo(expectedNumberOfRecipes));
        }

        [When(@"Meal period ""(.*)"" is created for ""(.*)""")]
        public void WhenMealPeriodIsCreatedFor(string mealPeriod, string day)
        {
            menuCycleDailyCalendarView.UseNewMealPeriodButton(day);
            mealPeriodDetails.SelectMealPeriod(mealPeriod);
        }

        [When(@"New meal period button is clicked for ""(.*)""")]
        public void NewMealPeriodButtonIsClicked(string day)
        {
            menuCycleDailyCalendarView.UseNewMealPeriodButton(day);
        }

        [When(@"Meal period is saved with notification ""(.*)""")]
        public void WhenMealPeriodIsSaved(string expectedMessage)
        {
            mealPeriodDetails.UseSaveButton();
            notification.ValidateToastMessage(expectedMessage);
            notification.WaitToDisappear();
        }

        [When(@"Meal period delete button is clicked")]
        [Then(@"Meal period delete button is clicked")]
        public void WhenMealPeriodIsDeleted()
        {
            mealPeriodDetails.UseDeleteButton();
            modalDialogPage.WaitToAppear();
        }

        [Then(@"Verify Meal period ""(.*)"" is not present for ""(.*)""")]
        public void ThenMealPeriodIsNotPresentFor(string mealPeriod, string day)
        {
            Assert.That(menuCycleDailyCalendarView.GetDay(day).MealPeriodCards.Select(x => x.Name).ToList(), Has.No.Member(mealPeriod));
        }

        [Then(@"Verify new meal period header is not clickable")]
        public void VerifyNewMealPeriodHeaderIsNotClickable()
        {
            menuCycleDailyCalendarView.VerifyNewMealPeriodHeaderIsNotClickable();
        }

        [When(@"meal period ""(.*)"" is selected in drop-down")]
        public void MealPeriodIsSelectedInDropDown(string mealPeriodName)
        {
            mealPeriodDetails.SelectMealPeriod(mealPeriodName);
        }

        [Then(@"Verify drop down for meal period has ""(.*)"" selected")]
        public void VerifyDropDownForMealPeriodHasSelected(string mealPeriodName)
        {
            Assert.That(mealPeriodDetails.SelectedMealPeriod, Is.EqualTo(mealPeriodName));
        }

        [Then(@"Verify there are no duplicated items in meal period ""(.*)"" for day ""(.*)"" in the calendar view")]
        public void ThenVerifyThereAreNoDuplicatedItemsInMealPeriodInTheCalendarView(string mealPeriod, string day)
        {
            Assert.IsFalse(menuCycleDailyCalendarView.GetDay(day).GetMealPeriodCard(mealPeriod).NoDuplicateRecipes);
        }
    }
}