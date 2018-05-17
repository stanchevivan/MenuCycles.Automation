using System;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class PlanningSteps
    {
        readonly PlanningView planningView;
        readonly PlanningTabDays planningTabDays;
        readonly PlanningTabWeeks planningTabWeeks;
        readonly NutritionTabDays nutritionTabDays;
        readonly MenuCycleCalendarView menuCycleCalendarView;
        readonly CreateMealPeriod createMealPeriod;
        readonly RecipeSearch recipeSearch;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;

        public PlanningSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleCalendarView menuCycleCalendarView,
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.planningView = dailyPlanningView;
            this.planningTabDays = planningTab;
            this.planningTabWeeks = planningTabWeeks;
            this.nutritionTabDays = nutritionTab;
            this.menuCycleCalendarView = menuCycleCalendarView;
            this.createMealPeriod = createMealPeriod;
            this.recipeSearch = recipeSearch;
            this.notification = notification;

            this.scenarioContext = scenarioContext;
        }

        [Then(@"the planning screen for (.*) is open")]
        public void ThenThePlanningScreenForADayIsOpened(string weekDay)
        {
            Assert.That(planningView.HeaderText, Is.EqualTo(weekDay.ToUpper()));
        }

        [Then(@"planning screen engine is loaded")]
        public void ThenPlanningScreenEngineIsLoaded()
        {
            Assert.IsTrue(planningTabDays.IsEngineLoaded());
        }

        [When(@"daily nutrition tab is opened")]
        public void WhenNutritionTabIsOpened()
        {
            planningView.OpenDailyNutritionTab();
            nutritionTabDays.WaitForLoad();
        }

        [When(@"daily planning tab is opened")]
        public void WhenPlanningTabIsOpened()
        {
            planningView.OpenDailyPlanningTab();
            planningTabDays.WaitForLoad();
        }

        [When(@"weekly planning tab is opened")]
        public void WeeklyPlanningTabIsOpened()
        {
        }

        [When(@"weekly nutrition tab is opened")]
        public void WeeklyNutritionTabIsOpened()
        {
        }

        [When(@"switching to Weekly Planning view")]
        public void SwitchingToWeeklyPlanningView()
        {
            planningTabDays.SwitchToWeeklyView();
            planningTabWeeks.WaitForLoad();
        }

        [When(@"switching to Daily Planning view")]
        public void SwitchingToDailyPlanningView()
        {
            planningTabWeeks.SwitchToDailyView();
            planningTabDays.WaitForLoad();
        }

        [When(@"switching to Weekly Nutrition view")]
        public void SwitchingToWeeklyNutritionView()
        {
        }

        [Given(@"Save button is clicked")]
        [When(@"Save button is clicked")]
        public void WhenSaveButtonIsClicked()
        {
            planningTabDays.UseSavebutton();
            notification.WaitToDisappear();
        }

        [Then(@"the user stays on the planning page")]
        public void ThenTheUserStaysOnThePlanningPage()
        {
            Assert.IsTrue(planningTabDays.IsPlanningTabOpen);
        }

        [Given(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to random number")]
        [When(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to random number")]
        public void WhenQuantityForRecipeNamedInMealPeriodIsSetToRandomNumber(string recipeName, string mealPeriod)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            string recipeQuantity = randomNumber.ToString();

            scenarioContext.Add("RecipeQuantity", recipeQuantity);

            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .PlannedQuantity = recipeQuantity;
        }

        [Then(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is equal to the previous inputted number")]
        public void ThenQuantityForRecipeNamedInMealPeriodIsEqualTo(string recipeName, string mealPeriod)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .GetRecipe(recipeName)
                        .PlannedQuantity,
                        Is.EqualTo(scenarioContext.Get<string>("RecipeQuantity")));
        }

        [Given(@"Cancel button is clicked")]
        [When(@"Cancel button is clicked")]
        public void WhenCancelButtonIsClicked()
        {
            planningTabDays.UseCancelButton();
        }

        [Given(@"Cross button is clicked")]
        [When(@"Cross button is clicked")]
        public void WhenCrossButtonIsClicked()
        {
            planningTabDays.UseCrossButton();
        }

        [When(@"Number of covers value for meal period ""(.*)"" is set to random number")]
        public void WhenNumberOfCoversValueForMealPeriodIsSetTo(string mealPeriod)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 101);
            string coversValue = randomNumber.ToString();

            scenarioContext.Add("NumberOfCoversValue", coversValue);

            planningTabDays
                .GetMealPeriod(mealPeriod)
                .NumberOfCovers = coversValue;
        }

        [Then(@"number of covers for meal period ""(.*)"" is equal to the previous inputted number")]
        public void ThenQuantityForRecipeNamedNumberOfCoversFoMealPeriodIsEqualToThePreviousInputedNumber(string mealPeriod)
        {
            Assert.That(planningTabDays
                        .GetMealPeriod(mealPeriod)
                        .NumberOfCovers, 
                        Is.EqualTo(scenarioContext.Get<string>("NumberOfCoversValue")));
        }

        [When(@"quantity for recipe named ""(.*)"" in meal period ""(.*)"" is set to ""(.*)""")]
        public void WhenQuantityForRecipeNamedInMealPeriodIsSetTo(string recipeName, string mealPeriod, string value)
        {
            planningTabDays
                .GetMealPeriod(mealPeriod)
                .GetRecipe(recipeName)
                .PlannedQuantity = value;
        }

        [When(@"Save button is clicked and the message '(.*)' is displayed")]
        [Then(@"Save button is clicked and the message '(.*)' is displayed")]
        public void WhenSaveButtonIsClickedAndTheMessageIsDisplayed(string message)
        {
            planningView.UseSavebutton();
            notification.ValidateToastMessage(message);
            notification.CloseNotification();
            notification.WaitToDisappear();
        }

        [Then(@"red border is displayed around Planned Quantity for recipe ""(.*)"" in meal period ""(.*)""")]
        public void ThenRedBorderIsDisplayedAroundPlannedQuantityForRecipeInMealPeriod(string recipeName, string mealperiod)
        {
            Assert.IsTrue(planningTabDays.GetMealPeriod(mealperiod).GetRecipe(recipeName).IsPlannedQuantityWithRedBorder);
        }
    }
}
