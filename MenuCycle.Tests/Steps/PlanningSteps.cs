﻿using System;using System.Linq;using MenuCycle.Tests.Models;using MenuCycle.Tests.PageObjects;using NUnit.Framework;using TechTalk.SpecFlow;using TechTalk.SpecFlow.Assist;namespace MenuCycle.Tests.Steps{    [Binding]    public class PlanningSteps    {        readonly PlanningView planningView;        readonly PlanningTabDays planningTabDays;        readonly PlanningTabWeeks planningTabWeeks;        readonly NutritionTabDays nutritionTabDays;        readonly MenuCycleDailyCalendarView menuCycleDailyCalendarView;        readonly RecipeSearch recipeSearch;        readonly ToastNotification notification;        readonly ScenarioContext scenarioContext;        public PlanningSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleDailyCalendarView menuCycleDailyCalendarView,            RecipeSearch recipeSearch, ToastNotification notification)        {            this.planningView = dailyPlanningView;            this.planningTabDays = planningTab;            this.planningTabWeeks = planningTabWeeks;            this.nutritionTabDays = nutritionTab;            this.menuCycleDailyCalendarView = menuCycleDailyCalendarView;            this.recipeSearch = recipeSearch;            this.notification = notification;            this.scenarioContext = scenarioContext;        }        [Then(@"the planning screen for (.*) is open")]        public void ThenThePlanningScreenForADayIsOpened(string weekDay)        {            Assert.That(planningView.HeaderText, Is.EqualTo(weekDay.ToUpper()));        }        [Then(@"planning screen engine is loaded")]        public void ThenPlanningScreenEngineIsLoaded()        {            Assert.IsTrue(planningTabDays.IsEngineLoaded());        }        [Given(@"daily nutrition tab is opened")]        [When(@"daily nutrition tab is opened")]        public void WhenNutritionTabIsOpened()        {            planningView.OpenDailyNutritionTab();            nutritionTabDays.WaitForLoad();            nutritionTabDays.WaitForBackdropToDisappear();        }        [Given(@"daily nutrition tab is clicked")]        [When(@"daily nutrition tab is clicked")]        public void WhenNutritionTabIsClicked()        {            planningView.OpenDailyNutritionTab();        }        [When(@"daily planning tab is opened")]        public void WhenPlanningTabIsOpened()        {            planningView.OpenDailyPlanningTab();            planningTabDays.WaitForLoad();        }        [When(@"weekly planning tab is opened")]        public void WeeklyPlanningTabIsOpened()        {        }        [When(@"weekly nutrition tab is opened")]        public void WeeklyNutritionTabIsOpened()        {        }        [Given(@"switching to Weekly Planning view")]        [When(@"switching to Weekly Planning view")]        public void SwitchingToWeeklyPlanningView()        {            planningTabDays.SwitchToWeeklyView();            planningTabWeeks.WaitForLoad();        }        [Then(@"Verify Weekly Planning view is open")]        public void VerifyWeeklyPlanningViewIsOpen()        {            Assert.IsTrue(planningTabWeeks.IsPageLoaded);        }        [Given(@"weekly Planning view link is clicked")]        [When(@"weekly Planning view link is clicked")]        public void WeeklyPlanningViewIsClicked()        {            planningTabDays.SwitchToWeeklyView();        }        [When(@"switching to Daily Planning view")]        public void SwitchingToDailyPlanningView()        {            planningTabWeeks.SwitchToDailyView();            planningTabDays.WaitForLoad();            planningView.WaitForBackdropToDisappear();        }        [When(@"switching to Weekly Nutrition view")]        public void SwitchingToWeeklyNutritionView()        {        }        [Given(@"Save button is clicked")]        [When(@"Save button is clicked")]        [Then(@"Save button is clicked")]        public void WhenSaveButtonIsClicked()        {            planningTabDays.UseSavebutton();            planningTabDays.WaitForLoader();        }        [Then(@"the user stays on the planning page")]        public void ThenTheUserStaysOnThePlanningPage()        {            Assert.IsTrue(planningTabDays.IsPlanningTabOpen);        }        [Given(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to random number")]        [When(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to random number")]        public void WhenQuantityForRecipeNamedInMealPeriodIsSetToRandomNumber(string recipeName, string mealPeriod)        {            var previousValue = planningTabDays                .GetMealPeriod(mealPeriod)                .GetRecipe(recipeName)                .GetFirstRow()                .PlannedQuantity;            var randomValue = CommonHerlpers.GetRandomValueExcluding(previousValue);            scenarioContext.Add("RecipeQuantity", randomValue);            planningTabDays                .GetMealPeriod(mealPeriod)                .GetRecipe(recipeName)                .GetFirstRow()                .PlannedQuantity = randomValue;        }        [Then(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is equal to the previous inputted number")]        public void ThenQuantityForRecipeNamedInMealPeriodIsEqualTo(string recipeName, string mealPeriod)        {            Assert.That(planningTabDays                        .GetMealPeriod(mealPeriod)                        .GetRecipe(recipeName)                        .GetFirstRow()                        .PlannedQuantity,                        Is.EqualTo(scenarioContext.Get<string>("RecipeQuantity")));        }        [Given(@"SellPrice for recipe named ""(.*)"" in meal period ""(.*)"" is set to random number")]        [When(@"SellPrice for recipe named ""(.*)"" in meal period ""(.*)"" is set to random number")]        public void WhenSellPriceForRecipeNamedInMealPeriodIsSetToRandomNumber(string recipeName, string mealPeriod)        {            var previousValue = planningTabDays                .GetMealPeriod(mealPeriod)                .GetRecipe(recipeName)                .GetFirstRow()                .SellPrice;            var randomValue = CommonHerlpers.GetRandomValueExcluding(previousValue);            scenarioContext.Add("SellPrice", randomValue);            planningTabDays                .GetMealPeriod(mealPeriod)                .GetRecipe(recipeName)                .GetFirstRow()                .SellPrice = randomValue;        }        [Then(@"SellPrice for recipe named ""(.*)"" in meal period ""(.*)"" is equal to the previous inputted number")]        public void ThenSellPriceForRecipeNamedInMealPeriodIsEqualTo(string recipeName, string mealPeriod)        {            Assert.That(planningTabDays                        .GetMealPeriod(mealPeriod)                        .GetRecipe(recipeName)                        .GetFirstRow()                        .SellPrice,                        Is.EqualTo(scenarioContext.Get<string>("SellPrice")));        }        [Given(@"Cancel button is clicked")]        [When(@"Cancel button is clicked")]        public void WhenCancelButtonIsClicked()        {            planningTabDays.UseCancelButton();        }        [Given(@"Cross button is clicked")]        [When(@"Cross button is clicked")]        public void WhenCrossButtonIsClicked()        {            planningTabDays.UseCrossButton();        }

        [Given(@"Cross button is clicked and calendar view has loaded")]        [When(@"Cross button is clicked and calendar view has loaded")]        public void WhenCrossButtonIsClickedAndCalendaarViewHasLoaded()        {            planningTabDays.UseCrossButton();            menuCycleDailyCalendarView.WaitPageLoad();        }        [Given(@"Number of covers for meal period ""(.*)"" is set to random number")]        [When(@"Number of covers for meal period ""(.*)"" is set to random number")]        public void WhenNumberOfCoversValueForMealPeriodIsSetTo(string mealPeriod)        {            var previousValue = planningTabDays                .GetMealPeriod(mealPeriod)                .NumberOfCovers;            var randomValue = CommonHerlpers.GetRandomValueExcluding(previousValue);            scenarioContext.Add("NumberOfCoversValue", randomValue);            planningTabDays                .GetMealPeriod(mealPeriod)                .NumberOfCovers = randomValue;        }        [Given(@"number of covers for meal period ""(.*)"" is equal to the previous inputted number")]        [Then(@"number of covers for meal period ""(.*)"" is equal to the previous inputted number")]        public void ThenQuantityForRecipeNamedNumberOfCoversFoMealPeriodIsEqualToThePreviousInputedNumber(string mealPeriod)        {            Assert.That(planningTabDays                        .GetMealPeriod(mealPeriod)                        .NumberOfCovers,                        Is.EqualTo(scenarioContext.Get<string>("NumberOfCoversValue")));        }        [When(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]        public void WhenQuantityForRecipeNamedInMealPeriodIsSetTo(string recipeName, string mealPeriod, string value)        {            planningTabDays                .GetMealPeriod(mealPeriod)                .GetRecipe(recipeName)                .GetFirstRow()                .PlannedQuantity = value;            planningTabDays.FocusOut();        }        [Given(@"Notification message ""(.*)"" is displayed")]        [When(@"Notification message ""(.*)"" is displayed")]        [Then(@"Notification message ""(.*)"" is displayed")]        public void WhenSaveButtonIsClickedAndTheMessageIsDisplayed(string message)        {            notification.ValidateToastMessage(message);
            // Notification does not disappear on Firefox, when trying to close it when out of focus
            //notification.CloseNotification(); 
            notification.WaitToDisappear();        }        [Then(@"red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]        public void ThenRedBorderIsDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealperiod)        {            Assert.IsTrue(planningTabDays.GetMealPeriod(mealperiod).GetRecipe(recipeName).GetFirstRow().IsPlannedQuantityWithRedBorder);        }        [Given(@"Menu Cycles app is closed")]        public void GivenMenuCyclesAppIsClosed()        {            planningView.CloseMenuCyclesApp();        }        [Given(@"values for recipe ""(.*)"" in meal period ""(.*)"" are stored")]        [When(@"values for recipe ""(.*)"" in meal period ""(.*)"" are stored")]        public void ValuesForRecipeAreStored(string recipeName, string mealPeriodName)        {            var dto = planningTabDays.GetMealPeriod(mealPeriodName)                                     .GetRecipe(recipeName).GetFirstRow().GetDTO();            scenarioContext.Add("recipeDTO", dto);        }        [Then(@"values for recipe ""(.*)"" in meal period ""(.*)"" are equal to the stored ones")]        public void ValuesForRecipeAreVerified(string recipeName, string mealPeriodName)        {            var recipe = planningTabDays.GetMealPeriod(mealPeriodName)                           .GetRecipe(recipeName);            var recipeDTO = scenarioContext.Get<RecipeModel>("recipeDTO");            recipe.GetFirstRow().VerifyData(recipeDTO);        }        [When(@"meal periods for the day are ""(.*)""")]        [Then(@"meal periods for the day are ""(.*)""")]        public void MealPeriodsForTheDayAre(string mealperiodNames)        {            var expectedNames = planningTabDays.MealPeriods.Select(x => x.Name).ToList();            var namesList = mealperiodNames.Split(',');            CollectionAssert.AreEqual(namesList.ToList(), expectedNames);        }        [Then(@"Daily Totals are equal to")]        public void ThenDailyTotalsAreEqualTo(Table table)        {            dynamic values = table.CreateDynamicInstance();            if (!string.IsNullOrEmpty(Convert.ToString(values.PlannedQty)))            {                Assert.That(planningTabDays.DailyPlanedQuanityText, Is.EqualTo(Convert.ToString(values.PlannedQty)));            }            if (!string.IsNullOrEmpty(Convert.ToString(values.TotalCost)))            {                Assert.That(planningTabDays.DailyTotalCostText, Is.EqualTo(Convert.ToString(values.TotalCost)));            }            if (!string.IsNullOrEmpty(Convert.ToString(values.Revenue)))            {                Assert.That(planningTabDays.DailyRevenueText, Is.EqualTo(Convert.ToString(values.Revenue)));            }            if (!string.IsNullOrEmpty(Convert.ToString(values.ActualGP)))            {                Assert.That(planningTabDays.DailyActualGPText, Is.EqualTo(Convert.ToString(values.ActualGP)));            }        }        [Then(@"""(.*)"" message is displayed")]        public void ThenMessageIsDisplayed(string message)        {            Assert.That(planningView.MealPeriodErrorMessage, Is.EqualTo(message));        }        [Then(@"Save button is disabled")]        public void ThenSaveButtonIsDisabled()        {            Assert.IsTrue(planningView.IsSaveButtonDisabled());        }        [Given(@"Wait for Calendar view")]        [When(@"Wait for Calendar view")]        public void GivenWaitForCalendarView()        {            menuCycleDailyCalendarView.WaitPageLoad();        }    }}