using System;
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
    public class MassUpdateSteps
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
        readonly MassUpdatePage massUpdate;
        readonly UpdatePrices updatePrices;

        public MassUpdateSteps(ScenarioContext scenarioContext, UpdatePrices updatePrices, PlanningView dailyPlanningView, PlanningTabDays planningTabDays, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTabDays, MenuCycleDailyCalendarView menuCycleDailyCalendarView, RecipeSearch recipeSearch, ToastNotification notification, ModalDialogPage modalDialogPage, CommonElements commonElements, MassUpdatePage massUpdate)
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
            this.massUpdate = massUpdate;
            this.updatePrices = updatePrices;
            this.scenarioContext = scenarioContext;
        }

        [When(@"recipe ""(.*)"" is searched")]
        [Given(@"recipe ""(.*)"" is searched")]
        public void WhenRecipeIsSearched(string recipeName)
        {
            massUpdate.EnterKeywordInSearch(recipeName);
            planningTabDays.FocusOut();
            massUpdate.ClickSearchButton();
            planningTabDays.WaitSpinnerToDisappear();
        }

        [When(@"recipe ""(.*)"" is selected")]
        [Given(@"recipe ""(.*)"" is selected")]
        public void WhenRecipeIsSelected(string recipeName)
        {
            massUpdate.GetRecipe(recipeName).SelectRecipeCard();
        }

        [When(@"checkbox for row ""(.*)"", ""(.*)"", ""(.*)"" in  recipe ""(.*)"" is selected")]
        public void WhenCheckboxForRowInRecipeIsSelected(string week, string day, string mealPeriod, string recipeName)
        {
            massUpdate.GetRecipe(recipeName).GetRow(week, day, mealPeriod).SelectOccurrence();
        }

        [When(@"recipe ""(.*)"" is expanded")]
        [Given(@"recipe ""(.*)"" is expanded")]
        public void WhenRecipeIsExpanded(string recipeName)
        {
            massUpdate.GetRecipe(recipeName).ClickArrow();
            massUpdate.WaitForOccurrencesToLoad();
        }

        [Then(@"The result message is ""(.*)""")]
        public void ThenTheResultMessageIs(string message)
        {
            string actualMessage = massUpdate.NoResultMessageText.ToUpper();
            Assert.AreEqual(message.ToUpper(), actualMessage);
        }

        [When(@"update price is selected")]
        [Given(@"update price is selected")]
        public void WhenUpdatePriceIsSelected()
        {
            massUpdate.SelectUpdatePriceButton();
        }

        [When(@"proceed button is clicked")]
        [Given(@"proceed button is clicked")]
        public void WhenProceedButtonIsClicked()
        {
            modalDialogPage.UseYesButton();
            updatePrices.WaitUpdatePricesToBeVisible();
        }

        [When(@"sell price for ""(.*)"" is set to ""(.*)""")]
        public void WhenSellPriceIsSetTo(string tariffType, string value)
        {
            updatePrices.GetRowByTariff(tariffType).SetSellPrice(value);        
        }

        [When(@"apply button is clicked")]
        [Then(@"apply button is clicked")]
        public void WhenApplyButtonIsClicked()
        {
            updatePrices.SelectApplyButton();
        }

        [When(@"Price model for tariff type ""(.*)"" is set to ""(.*)""")]
        public void WhenPriceModelForTariffTypeIsSetTo(string tariffType, string priceModel)
        {
            updatePrices.GetRowByTariff(tariffType)
                .PriceModel = priceModel;
        }

        [When(@"Verify red border and contextual error message ""(.*)"" is displayed for Sell Price field for ""(.*)"" tariff type")]
        public void WhenVerifyRedBorderAndContextualErrorMessageIsDisplayedForSellPriceField(string errorMessage, string tariffType)
        {
            Assert.IsTrue(updatePrices.GetRowByTariff(tariffType)
                 .SellPriceHasRedBorder, "Red border is not displayed");
            Assert.AreEqual(updatePrices.GetRowByTariff(tariffType)
                 .SellPriceContextualErrorMessage, errorMessage);
        }

        [When(@"Verify red border is not displayed for Sell Price field for ""(.*)"" tariff type")]
        [Then(@"Verify red border is not displayed for Sell Price field for ""(.*)"" tariff type")]
        public void WhenVerifyRedBorderIsNotDisplayedForSellPriceFieldForTariffType(string tariffType)
        {
             Assert.IsFalse(updatePrices.GetRowByTariff(tariffType)
            .SellPriceHasRedBorder);
        }

        [When(@"targetGP% for ""(.*)"" is set to ""(.*)""")]
        public void WhenTargetGPForIsSetTo(string tariffType, string value)
        {
            updatePrices.GetRowByTariff(tariffType).SetTargetGP(value);
        }

        [When(@"Verify red border is not displayed for targetGP% field for ""(.*)"" tariff type")]
        [Then(@"Verify red border is not displayed for targetGP% field for ""(.*)"" tariff type")]
        public void WhenVerifyRedBorderIsNotDisplayedForTargetGPFieldForTariffType(string tariffType)
        {
            Assert.IsFalse(updatePrices.GetRowByTariff(tariffType)
                .IsTargetGPWithRedBorder);

        }

        [When(@"Verify red border and contextual error message ""(.*)"" is displayed for targetGP% field for ""(.*)"" tariff type")]
        [Then(@"Verify red border and contextual error message ""(.*)"" is displayed for targetGP% field for ""(.*)"" tariff type")]
        public void WhenVerifyRedBorderAndContextualErrorMessageIsDisplayedForTargetGPFieldForTariffType(string errorMessage, string tariffType)
        {
            Assert.IsTrue(updatePrices.GetRowByTariff(tariffType)
                 .IsTargetGPWithRedBorder, "Red border is not displayed");
            Assert.AreEqual(updatePrices.GetRowByTariff(tariffType)
                 .TargetPercentageContextualErrorMessage, errorMessage);
        }

        [When(@"add types is selected")]
        public void WhenAddTypesIsSelected()
        {
            updatePrices.SelectAddTypesButton();
        }

        [Then(@"tariff type ""(.*)"" has been added")]
        public void ThenTariffTypeHasBeenAdded(string tariffType)
        {
            Assert.IsTrue(updatePrices.GetRowByTariff(tariffType).IsTariffTypePresent);
        }

        [When(@"tariff type ""(.*)"" is set to ""(.*)""")]
        public void WhenTariffTypeIsSetTo(string tariffType, string newTariffType)
        {
            updatePrices.GetRowByTariff(tariffType)
                .TariffType = newTariffType;
        }

    }
}