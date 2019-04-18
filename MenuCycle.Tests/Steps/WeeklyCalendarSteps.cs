﻿using System.Linq;
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
        readonly MealPeriodDetails mealPeriodDetails;
        readonly ReviewPage reviewPage;

        public WeeklyCalendarSteps(ScenarioContext scenarioContext, PlanningView dailyPlanningView, ToastNotification notification,
                              WeeklyCalendarView weeklyCalendarView, MenuCycleDailyCalendarView dailyCalendarView, MealPeriodDetails mealPeriodDetails, ReviewPage reviewPage)
        {
            this.dailyPlanningView = dailyPlanningView;
            this.notification = notification;
            this.weeklyCalendarView = weeklyCalendarView;
            this.dailyCalendarView = dailyCalendarView;
            this.mealPeriodDetails = mealPeriodDetails;
            this.reviewPage = reviewPage;

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


        [When(@"meal period ""(.*)"" in day ""(.*)"" for week ""(.*)"" is opened")]
        public void WhenMealPeriodInDayForWeekIsOpened(string mealPeriod, string day, string weekName)
        {
            weeklyCalendarView.GetWeek(weekName).GetDay(day).ClickMealPeriod(mealPeriod);
            mealPeriodDetails.WaitForLoad();
        }

        [Then(@"Verify meal period details for ""(.*)"" is open")]
        public void ThenVerifyMealPeriodDetailsForIsOpen(string expectedHeaderText)
        {
            Assert.That(mealPeriodDetails.HeaderText, Is.EqualTo(expectedHeaderText));
        }

        [When(@"weekly review page is opened")]
        public void ReviewPageIsOpened()
        {
            weeklyCalendarView.ClickReviewTab();
            reviewPage.WaitForLoad();
        }
    }
}