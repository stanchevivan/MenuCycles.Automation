using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class PlanningSteps
    {
        private DailyPlanningView dailyPlanningView;
        private PlanningTabDays planningTabDays;
        private PlanningTabWeeks planningTabWeeks;
        private NutritionTabDays nutritionTabDays;
        private MenuCycleCalendarView menuCycleCalendarView;
        private CreateMealPeriod createMealPeriod;
        private RecipeSearch recipeSearch;
        private ToastNotification notification;
        private ScenarioContext scenarioContext;

        public PlanningSteps(ScenarioContext scenarioContext, DailyPlanningView dailyPlanningView, PlanningTabDays planningTab, PlanningTabWeeks planningTabWeeks, NutritionTabDays nutritionTab, MenuCycleCalendarView menuCycleCalendarView,
            CreateMealPeriod createMealPeriod, RecipeSearch recipeSearch, ToastNotification notification)
        {
            this.dailyPlanningView = dailyPlanningView;
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
            Assert.That(dailyPlanningView.GetHeaderText(), Is.EqualTo(weekDay.ToUpper()));
        }

        [Then(@"planning screen engine is loaded")]
        public void ThenPlanningScreenEngineIsLoaded()
        {
            Assert.IsTrue(planningTabDays.IsEngineLoaded());
        }

        [When(@"daily nutrition tab is opened")]
        public void WhenNutritionTabIsOpened()
        {
            dailyPlanningView.OpenDailyNutritionTab();
            nutritionTabDays.WaitForLoad();
        }

        [When(@"daily planning tab is opened")]
        public void WhenPlanningTabIsOpened()
        {
            dailyPlanningView.OpenDailyPlanningTab();
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
    }
}
