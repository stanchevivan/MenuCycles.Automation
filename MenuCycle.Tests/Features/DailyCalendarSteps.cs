using System;
using System.Globalization;
using System.Linq;
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
        readonly MassUpdatePage massUpdate;
        
        ReviewPage reviewPage;

        public DailyCalendarSteps (ToastNotification notification, ScenarioContext scenarioContext, MenuCycleDailyCalendarView menuCycleDailyCalendarView, ReviewPage reviewPage, MassUpdatePage massUpdate)
        {
            this.notification = notification;
            this.scenarioContext = scenarioContext;
            this.reviewPage = reviewPage;
            this.massUpdate = massUpdate;
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
            notification.WaitToAppear();
            notification.CloseNotification();
        }

        [Given(@"daily review page is opened")]
        [When(@"daily review page is opened")]
        public void ReviewPageIsOpened()
        {
            dailyCalendarView.ClickReviewTab();
            reviewPage.WaitForLoad();
        }

        [Then(@"Verify week name is ""(.*)""")]
        public void ThenVerifyWeekNameIs(string weekName)
        {
            Assert.That(dailyCalendarView.WeekName, Is.EqualTo(weekName));
        }

        [Then(@"Verify real world week is opened")]
        public void RealWorldWeekIsOpened()
        {
            var currentDayOfWeek = DateTime.UtcNow.DayOfWeek;
            string currentDay = DateTime.UtcNow.Day.ToString().ToUpper();
            int currentMonth = DateTime.UtcNow.Month;


            DateTimeFormatInfo MonthName = new DateTimeFormatInfo();
            string monthNameAbbr = MonthName.GetAbbreviatedMonthName(currentMonth).ToUpper();

            DateTimeFormatInfo DayNameAbbr = new DateTimeFormatInfo();
            string dayNameAbbr = DayNameAbbr.GetAbbreviatedDayName(currentDayOfWeek).ToUpper();

            dayNameAbbr = dayNameAbbr == "THU" ? "THUR" : dayNameAbbr;

            Assert.That(dailyCalendarView.GetAllDaysText, Has.Member($"{dayNameAbbr} {currentDay} {monthNameAbbr} ▾"));
        }

        [Then(@"Verify meal periods for day ""(.*)"" in daily calendar are:")]
        public void ThenVerifyMealPeriodsAreInCorrectSortOrderForDay(string day, Table table)
        {
            var expectedMealPeriods = table.Rows[0]["mealPeriods"].Split(',');
            var currentMealPeriods = dailyCalendarView.GetDay(day).MealPeriodCards.Select(x => x.Name);

            Assert.That(currentMealPeriods, Is.EqualTo(expectedMealPeriods));
        }

        [When(@"Daily calendar delete week button is clicked")]
        public void WhenCurrentWeekIsDeleted()
        {
            dailyCalendarView.UseDeleteWeekButton();
        }

        [When(@"Calendar tab is clicked and calendar view has loaded")]
        public void WhenCalendarTabIsClickedAndCalendarViewHasLoaded()
        {
            dailyCalendarView.ClickCalendarTab();
            dailyCalendarView.WaitPageLoad();
        }

        [When(@"Mass Update page is opened")]
        [Given(@"Mass Update page is opened")]
        public void WhenMassUpdatePageIsOpened()
        {
            dailyCalendarView.ClickMassUpdateTab();
            massUpdate.WaitForPageToLoad();
        }
    }
}