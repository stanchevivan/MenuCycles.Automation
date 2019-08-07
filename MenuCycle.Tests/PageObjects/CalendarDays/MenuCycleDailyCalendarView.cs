using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCycleDailyCalendarView : MenuCyclesBasePage
    {
        public MenuCycleDailyCalendarView(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "menucycleName")]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "daysTab")]
        private IWebElement DaysViewButton { get; set; }

        [FindsBy(How = How.Id, Using = "weeksTab")]
        private IWebElement WeeksViewButton { get; set; }

        [FindsBy(How = How.Id, Using = "daily-view-add-week-button")]
        private IWebElement AddWeekButton { get; set; }

        [FindsBy(How = How.Id, Using = "delWeekbtn")]
        private IWebElement DeleteWeekButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-header-container > div")]
        private IList<IWebElement> CalendarHeaderContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-view-screen > div")]
        private IList<IWebElement> CalendarColumnContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "daily-calendar-heading")]
        private IList<IWebElement> DaysLinks { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".Planning-engine")]
        private IList<IWebElement> PlanningLinks { get; set; }

        [FindsBy(How = How.ClassName, Using = "daily-header-container")]
        private IWebElement DaysContainer { get; set; }

        [FindsBy(How = How.Id, Using = "dashboardIcon")]
        private IWebElement HomeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".NewMealPeriod .clickable")]
        private IWebElement NewMealPeriodHeader { get; set; }

        [FindsBy(How = How.Id, Using = "dailyReportBtn")]
        private IWebElement DailyReportButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".mc-subheader__buttons > button:first-of-type")]
        private IWebElement SwitchViewButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".calendar-next-arrow")]
        private IWebElement NextWeekArrow { get; set; }

        [FindsBy(How = How.Id, Using = "dailyReviewBtn")]
        private IWebElement ReviewButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#daily-calendar-week-heading")]
        private IWebElement WeekName { get; set; }



        /// <summary>
        /// For checking if the calendar is in 5 or 7 day view
        /// </summary>
        /// <value>The table holder div.</value>
        [FindsBy(How = How.CssSelector, Using = "#visibleFullView")]
        private IWebElement tableHolderDiv { get; set; }

        public List<WeekDays> CalendarHeaders => this.CalendarHeaderContainer.Select(p => new WeekDays(p)).ToList();

        public IList<DayColumn> CalendarColumns => this.CalendarColumnContainer.Select(p => new DayColumn(p, Driver)).ToList();

        public bool AreAllMealPeriodsExpanded => CalendarColumns.SelectMany(day => day.MealPeriodCards).Where(mp => mp.IsExpandable).All(mp => mp.IsExpanded);

        public bool IsCalendarViewOpen => DaysContainer.Get().ElementPresent;

        public bool IsInFullView => tableHolderDiv.Get().ElementPresent;

        public bool IsNextWeekArrowPresent => NextWeekArrow.Get().ElementPresent;

        public string WeekNameText => WeekName.Text;

        public DayColumn GetDay(string weekDay)
        {
            int dayIndex;

            List<string> dayAbbreviations = new List<string>
            {
                "MON",
                "TUE",
                "WED",
                "THUR",
                "FRI",
                "SAT",
                "SUN",
            };

            weekDay = dayAbbreviations.First(weekDay.ToUpper().Contains);

            switch (weekDay.ToUpper())
            {
                case "MONDAY":
                case "MON":
                    { dayIndex = 0; break; }
                case "TUESDAY":
                case "TUE":
                    { dayIndex = 1; break; }
                case "WEDNESDAY":
                case "WED":
                    { dayIndex = 2; break; }
                case "THURSDAY":
                case "THUR":
                    { dayIndex = 3; break; }
                case "FRIDAY":
                case "FRI":
                    { dayIndex = 4; break; }
                case "SATURDAY":
                case "SAT":
                    { dayIndex = 5; break; }
                case "SUNDAY":
                case "SUN":
                    { dayIndex = 6; break; }
                default:
                    {
                        throw new System.Exception($"Could not match day {weekDay}");
                    }
            }

            return CalendarColumns[dayIndex];
        }

        public DayColumn GetDay(int dayIndex)
        {
            return CalendarColumns[dayIndex];
        }

        public IList<string> GetAllDaysText()
        {
            return DaysLinks.Select(x => x.Text).ToList();
        }

        public void WaitPageLoad()
        {
            Driver.WaitListItemsLoad(CalendarHeaderContainer);
            Driver.WaitIsClickable(DaysViewButton);
            WaitSpinnerToDisappear();
        }

        public void SwitchView()
        {
            SwitchViewButton.Click();
        }

        public void UseNewMealPeriodButton(string day)
        {
            CalendarHeaders.First(c => c.Name.StartsWith(day, System.StringComparison.CurrentCultureIgnoreCase)).UseMealPeriodButton();
        }

        public void OpenDailyPlanningForDay(string weekDay)
        {
            WaitSpinnerToDisappear();
            var dayLink = DaysLinks.First(x => x.Text.Contains(weekDay.ToUpper()));

            dayLink.Click();

            var planningLink = PlanningLinks.First(x => x.Displayed);
            Driver.WaitElementAndClick(planningLink);
        }

        public IList<string> GetMealPeriodColours(string weekDay)
        {
            return GetDay(weekDay).MealPeriodCards.Select(x => x.Colour).ToList();
        }

        public IList<string> GetMealPeriodNames(string weekDay)
        {
            return GetDay(weekDay).MealPeriodCards.Select(x => x.Name).ToList();
        }

        public void OpenMealPeriodDetails(string weekDay, string mealPeriodName)
        {
            GetDay(weekDay).GetMealPeriodCard(mealPeriodName).OpenMealPeriodDetails();
        }

        public void UseHomeButton()
        {
            HomeButton.Click();
        }

        public void ClickNewMealPeriodHeader()
        {
            NewMealPeriodHeader.Click();
        }

        public bool VerifyNewMealPeriodHeaderIsNotClickable()
        {
            try
            {
                NewMealPeriodHeader.Click();
            }
            catch (System.Reflection.TargetInvocationException ex)
            {
                if (ex.InnerException.Message.Contains("not clickable"))
                {
                    return true;
                }
            }

            return false;
        }

        public void UseDailyReportButton()
        {
            DailyReportButton.Click();
            WaitSpinnerToDisappear();
        }

        public void OpenWeeksTab()
        {
            Driver.WaitElementAndClick(WeeksViewButton);
            WaitSpinnerToDisappear();
        }

        public void OpenDaysTab()
        {
            Driver.WaitElementAndClick(DaysViewButton);
        }

        public void AddWeek()
        {
            AddWeekButton.Click();
            //Driver.WaitElementToDisappear(Backdrop);
            WaitSpinnerToDisappear();
        }

        public void NextWeek()
        {
            NextWeekArrow.Click();
        }

        public void ClickReviewTab()
        {
            ReviewButton.Click();
        }

        public void UseDeleteWeekButton()
        {
            DeleteWeekButton.Click();
        }
    }
}