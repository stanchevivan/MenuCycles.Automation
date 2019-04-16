using System.Linq;
using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
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
        readonly MenuCycleDailyCalendarView dailyCalendarView;

        public WeeklyCalendarSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, ToastNotification notification,
                              WeeklyCalendarView weeklyCalendarView, MenuCycleDailyCalendarView dailyCalendarView)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.notification = notification;
            this.weeklyCalendarView = weeklyCalendarView;
            this.dailyCalendarView = dailyCalendarView;

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

        [Then(@"Verify caledar weeks contains weeks:")]
        [When(@"Verify caledar weeks contains weeks:")]
        public void DeleteButtonIsClickedForWeek(Table table)
        {
            Assert.That(weeklyCalendarView.CalendarWeeks.Select(x => x.WeekTitle).ToList(), Is.EqualTo(table.Header.ToList()));
        }

        [Then(@"Verify next week arrow is not present")]
        public void VerifyNextWeekArrowNotPresent()
        {
            Assert.IsFalse(dailyCalendarView.IsNextWeekArrowPresent);
        }
    }
}