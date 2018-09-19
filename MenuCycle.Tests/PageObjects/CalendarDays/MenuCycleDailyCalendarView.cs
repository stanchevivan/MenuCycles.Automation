using System.Collections.Generic;
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

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
        private IWebElement SpinningWheel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-header-container > div")]
        private IList<IWebElement> CalendarHeaderContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-view-screen > div")]
        private IList<IWebElement> CalendarColumnContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "daily-calendar-heading")]
        private IList<IWebElement> DaysLinks { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".Planning-engine")]
        private IList<IWebElement> PlanningLinks { get; set; }

        [FindsBy(How = How.ClassName, Using = "modal-backdrop")]
        private IWebElement Backdrop { get; set; }

        [FindsBy(How = How.ClassName, Using = "daily-header-container")]
        private IWebElement DaysContainer { get; set; }

        [FindsBy(How = How.Id, Using = "dashboard-icon")]
        private IWebElement HomeButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".NewMealPeriod .clickable")]
        private IWebElement NewMealPeriodHeader { get; set; }

        public List<WeekDays> CalendarHeaders => this.CalendarHeaderContainer.Select(p => new WeekDays(p)).ToList();

        public IList<DayColumn> CalendarColumns => this.CalendarColumnContainer.Select(p => new DayColumn(p, CalendarHeaders[CalendarColumnContainer.IndexOf(p)].Name)).ToList();

        public bool AreAllMealPeriodsExpanded => CalendarColumns.SelectMany(day => day.MealPeriodCards).Where(mp => mp.IsExpandable).All(mp => mp.IsExpanded);

        public bool IsCalendarViewOpen => DaysContainer.Get().ElementPresent;

        public DayColumn GetDay(string weekDay)
        {
            int dayIndex;

            switch (weekDay.ToUpper())
            {
                case "MONDAY":
                    { dayIndex = 0; break; }
                case "TUESDAY":
                    { dayIndex = 1; break; }
                case "WEDNESDAY":
                    { dayIndex = 2; break; }
                case "THURSDAY":
                    { dayIndex = 3; break; }
                case "FRIDAY":
                    { dayIndex = 4; break; }
                case "SATURDAY":
                    { dayIndex = 5; break; }
                case "SUNDAY":
                    { dayIndex = 6; break; }
                default:
                    {
                        throw new System.Exception($"Could match day {weekDay}");
                    }
            }

            return CalendarColumns[dayIndex];
        }

        public void WaitPageLoad()
        {
            Driver.WaitListItemsLoad(CalendarHeaderContainer);
            Driver.WaitIsClickable(DaysViewButton);
            Driver.WaitElementToDisappear(SpinningWheel);
        }

        public void UseNewMealPeriodButton(string day)
        {
            CalendarHeaders.First(c => c.Name.StartsWith(day, System.StringComparison.CurrentCultureIgnoreCase)).UseMealPeriodButton();
        }

        public void OpenDailyPlanningForDay(string weekDay)
        {
            Driver.WaitElementToDisappear(Backdrop);
            var dayLink = DaysLinks.First(x => x.Text.Contains(weekDay.ToUpper()));
            var indexOfDay = DaysLinks.IndexOf(dayLink);

            dayLink.Click();

            var planningLink = PlanningLinks[indexOfDay];
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
    }
}
