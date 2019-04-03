using MenuCycle.Tests.PageObjects;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class WeeklyCalendarSteps
    {
        readonly PlanningView dailyPlanningView;
        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        readonly WeeklyCalendarView weeklyCalendarView;

        public WeeklyCalendarSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, ToastNotification notification,
                              WeeklyCalendarView weeklyCalendarView)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.notification = notification;
            this.weeklyCalendarView = weeklyCalendarView;

            this.scenarioContext = scenarioContext;
        }

        [When(@"Week ""(.*)"" is copied")]
        public void WeekIsCopied(string weekName)
        {
            
            weeklyCalendarView.GetWeek(weekName).UseCopyButton();
            dailyPlanningView.WaitForBackdropToDisappear();
        }

        [When(@"Delete button is clicked for week ""(.*)""")]
        [Then(@"Delete button is clicked for week ""(.*)""")]
        public void DeleteButtonIsClickedForWeek(string weekName)
        {
            weeklyCalendarView.GetWeek(weekName).UseDeleteButton();
            dailyPlanningView.WaitForBackdropToDisappear();
        }
    }
}