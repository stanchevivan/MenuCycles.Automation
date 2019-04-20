using MenuCycle.Tests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Steps
{
    [Binding]
    public class DailyCalendarSteps
    {
        readonly MenuCycleDailyCalendarView dailyCalendarView;

        readonly ToastNotification notification;
        readonly ScenarioContext scenarioContext;
        ReviewPage reviewPage;

        public DailyCalendarSteps (ToastNotification notification, ScenarioContext scenarioContext, MenuCycleDailyCalendarView menuCycleDailyCalendarView, ReviewPage reviewPage)
        {
            this.notification = notification;
            this.scenarioContext = scenarioContext;
            this.reviewPage = reviewPage;

            this.dailyCalendarView = menuCycleDailyCalendarView;
        }

        [When(@"daily calendar view is switched")]
        public void WhenDailyCalendarViewIsSwitched()
        {
            dailyCalendarView.SwitchView();
        }

        [When(@"Verify day ""(.*)"" is visible")]
        [Then(@"Verify day ""(.*)"" is visible")]
        public void VerifyDayByNameIsVisible(string dayName)
        {
            Assert.IsTrue(dailyCalendarView.GetDay(dayName).IsVisible);
        }

        [When(@"Verify day ""(.*)"" is not visible")]
        [Then(@"Verify day ""(.*)"" is not visible")]
        public void VerifyDayByNameIsNotVisible(string dayName)
        {
            Assert.IsFalse(dailyCalendarView.GetDay(dayName).IsVisible);
        }

        [When(@"new week is added")]
        public void AddWeek()
        {
            dailyCalendarView.AddWeek();
            notification.CloseNotification();
        }

        [When(@"daily review page is opened")]
        public void ReviewPageIsOpened()
        {
            dailyCalendarView.ClickReviewTab();
            reviewPage.WaitForLoad();
        }

        [Then(@"Verify week name is ""(.*)""")]
        public void ThenVerifyWeekNameIs(string weekName)
        {
            Assert.That(dailyCalendarView.WeekNameText, Is.EqualTo(weekName));
        }
    }
}