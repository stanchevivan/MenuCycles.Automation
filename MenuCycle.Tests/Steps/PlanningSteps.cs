using System;using System.Linq;using MenuCycle.Tests.Models;using MenuCycle.Tests.PageObjects;using NUnit.Framework;using TechTalk.SpecFlow;
namespace MenuCycle.Tests.Steps{    [Binding]    public class PlanningSteps    {        readonly PlanningView planningView;        readonly PlanningTabDays planningTabDays;        readonly PlanningTabWeeks planningTabWeeks;        readonly NutritionTabDays nutritionTabDays;        readonly MenuCycleCalendarView menuCycleCalendarView;        readonly CreateMealPeriod createMealPeriod;        readonly RecipeSearch recipeSearch;        readonly ToastNotification notification;        readonly ScenarioContext scenarioContext;        public PlanningSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleCalendarView menuCycleCalendarView,            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)        {            this.planningView = dailyPlanningView;            this.planningTabDays = planningTab;            this.planningTabWeeks = planningTabWeeks;            this.nutritionTabDays = nutritionTab;            this.menuCycleCalendarView = menuCycleCalendarView;            this.createMealPeriod = createMealPeriod;            this.recipeSearch = recipeSearch;            this.notification = notification;            this.scenarioContext = scenarioContext;        }        [Then(@"the planning screen for (.*) is open")]        public void ThenThePlanningScreenForADayIsOpened(string weekDay)        {            Assert.That(planningView.HeaderText, Is.EqualTo(weekDay.ToUpper()));        }        [Then(@"planning screen engine is loaded")]        public void ThenPlanningScreenEngineIsLoaded()        {            Assert.IsTrue(planningTabDays.IsEngineLoaded());        }        [Given(@"daily nutrition tab is opened")]        [When(@"daily nutrition tab is opened")]        public void WhenNutritionTabIsOpened()        {            planningView.OpenDailyNutritionTab();            nutritionTabDays.WaitForLoad();        }        [Given(@"daily nutrition tab is clicked")]        [When(@"daily nutrition tab is clicked")]        public void WhenNutritionTabIsClicked()        {            planningView.OpenDailyNutritionTab();        }        [When(@"daily planning tab is opened")]        public void WhenPlanningTabIsOpened()        {            planningView.OpenDailyPlanningTab();            planningTabDays.WaitForLoad();        }        [When(@"weekly planning tab is opened")]        public void WeeklyPlanningTabIsOpened()        {        }        [When(@"weekly nutrition tab is opened")]        public void WeeklyNutritionTabIsOpened()        {        }        [Given(@"switching to Weekly Planning view")]        [When(@"switching to Weekly Planning view")]        public void SwitchingToWeeklyPlanningView()        {            planningTabDays.SwitchToWeeklyView();            planningTabWeeks.WaitForLoad();        }        [Given(@"weekly Planning view link is clicked")]        [When(@"weekly Planning view link is clicked")]        public void WeeklyPlanningViewIsClicked()        {            planningTabDays.SwitchToWeeklyView();        }        [When(@"switching to Daily Planning view")]        public void SwitchingToDailyPlanningView()        {            planningTabWeeks.SwitchToDailyView();            planningTabDays.WaitForLoad();        }        [When(@"switching to Weekly Nutrition view")]        public void SwitchingToWeeklyNutritionView()        {        }        [Given(@"Save button is clicked")]        [When(@"Save button is clicked")]        public void WhenSaveButtonIsClicked()        {            planningTabDays.UseSavebutton();        }        [Then(@"the user stays on the planning page")]        public void ThenTheUserStaysOnThePlanningPage()        {            Assert.IsTrue(planningTabDays.IsPlanningTabOpen);        }        [Given(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to random number")]        [When(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to random number")]        public void WhenQuantityForRecipeNamedInMealPeriodIsSetToRandomNumber(string recipeName, string mealPeriod)        {            var previousValue = planningTabDays                .GetMealPeriod(mealPeriod)                .GetRecipe(recipeName)                .PlannedQuantity;            var randomValue = CommonHerlpers.GetRandomValueExcluding(previousValue);            scenarioContext.Add("RecipeQuantity", randomValue);            planningTabDays                .GetMealPeriod(mealPeriod)                .GetRecipe(recipeName)                .PlannedQuantity = randomValue;        }        [Then(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is equal to the previous inputted number")]        public void ThenQuantityForRecipeNamedInMealPeriodIsEqualTo(string recipeName, string mealPeriod)        {            Assert.That(planningTabDays                        .GetMealPeriod(mealPeriod)                        .GetRecipe(recipeName)                        .PlannedQuantity,                        Is.EqualTo(scenarioContext.Get<string>("RecipeQuantity")));        }        [Given(@"Cancel button is clicked")]        [When(@"Cancel button is clicked")]        public void WhenCancelButtonIsClicked()        {            planningTabDays.UseCancelButton();        }        [Given(@"Cross button is clicked")]        [When(@"Cross button is clicked")]        public void WhenCrossButtonIsClicked()        {            planningTabDays.UseCrossButton();        }        [Given(@"Number of covers for meal period ""(.*)"" is set to random number")]        [When(@"Number of covers for meal period ""(.*)"" is set to random number")]        public void WhenNumberOfCoversValueForMealPeriodIsSetTo(string mealPeriod)        {            var previousValue = planningTabDays                .GetMealPeriod(mealPeriod)                .NumberOfCovers;            var randomValue = CommonHerlpers.GetRandomValueExcluding(previousValue);            scenarioContext.Add("NumberOfCoversValue", randomValue);            planningTabDays                .GetMealPeriod(mealPeriod)                .NumberOfCovers = randomValue;        }        [Given(@"number of covers for meal period ""(.*)"" is equal to the previous inputted number")]        [Then(@"number of covers for meal period ""(.*)"" is equal to the previous inputted number")]        public void ThenQuantityForRecipeNamedNumberOfCoversFoMealPeriodIsEqualToThePreviousInputedNumber(string mealPeriod)        {            Assert.That(planningTabDays                        .GetMealPeriod(mealPeriod)                        .NumberOfCovers,                         Is.EqualTo(scenarioContext.Get<string>("NumberOfCoversValue")));        }        [When(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]        public void WhenQuantityForRecipeNamedInMealPeriodIsSetTo(string recipeName, string mealPeriod, string value)        {            planningTabDays                .GetMealPeriod(mealPeriod)                .GetRecipe(recipeName)                .PlannedQuantity = value;        }        [Given(@"Notification message ""(.*)"" is displayed")]        [When(@"Notification message ""(.*)"" is displayed")]        [Then(@"Notification message ""(.*)"" is displayed")]        public void WhenSaveButtonIsClickedAndTheMessageIsDisplayed(string message)        {            notification.ValidateToastMessage(message);            notification.CloseNotification();            notification.WaitToDisappear();        }        [Then(@"red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]        public void ThenRedBorderIsDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealperiod)        {            Assert.IsTrue(planningTabDays.GetMealPeriod(mealperiod).GetRecipe(recipeName).IsPlannedQuantityWithRedBorder);        }        [Given(@"Menu Cycles app is closed")]        public void GivenMenuCyclesAppIsClosed()        {            planningView.CloseMenuCycles();        }        [Given(@"values for recipe ""(.*)"" in meal period ""(.*)"" are stored")]        [When(@"values for recipe ""(.*)"" in meal period ""(.*)"" are stored")]        public void ValuesForRecipeAreStored(string recipeName, string mealPeriodName)        {            var dto = planningTabDays.GetMealPeriod(mealPeriodName)                           .GetRecipe(recipeName).GetDTO();            scenarioContext.Add("recipeDTO",dto);        }        [Then(@"values for recipe ""(.*)"" in meal period ""(.*)"" are equal to the stored ones")]        public void ValuesForRecipeAreVerified(string recipeName, string mealPeriodName)        {            var recipe = planningTabDays.GetMealPeriod(mealPeriodName)                           .GetRecipe(recipeName);            var recipeDTO = scenarioContext.Get<RecipeModel>("recipeDTO");            recipe.VerifyData(recipeDTO);        }        [When(@"meal periods for the day are ""(.*)""")]        [Then(@"meal periods for the day are ""(.*)""")]        public void MealPeriodsForTheDayAre(string mealperiodNames)        {            var expectedNames = planningTabDays.MealPeriods.Select(x => x.Name).ToList();            var namesList = mealperiodNames.Split(',');            CollectionAssert.AreEqual(namesList.ToList() ,expectedNames);        }    }}