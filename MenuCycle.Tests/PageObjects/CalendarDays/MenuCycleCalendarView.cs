using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCycleCalendarView : BasePage
    {
        readonly IArtefacts Artefacts;

        public MenuCycleCalendarView(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.Id, Using = "menucycleName")]
        IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "daysTab")]
        IWebElement DaysViewButton { get; set; }

        [FindsBy(How = How.Id, Using = "weeksTab")]
        IWebElement WeeksViewButton { get; set; }

        [FindsBy(How = How.Id, Using = "daily-view-add-week-button")]
        IWebElement AddWeekButton { get; set; }

        [FindsBy(How = How.Id, Using = "delWeekbtn")]
        IWebElement DeleteWeekButton { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
        IWebElement SpinningWheel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-header-container > div")]
        IList<IWebElement> CalendarHeaderContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-view-screen > div")]
        IList<IWebElement> CalendarColumnContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "daily-calendar-heading")]
        IList<IWebElement> DaysLinks { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".Planning-engine")]
        IList<IWebElement> PlanningLinks { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".daily-view-screen > div")]
        IList<IWebElement> DaysColumnContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "modal-backdrop")]
        IWebElement Backdrop { get; set; }

        [FindsBy(How = How.ClassName, Using = "daily-header-container")]
        IWebElement DaysContainer { get; set; }

        [FindsBy(How = How.Id, Using = "dashboard-icon")]
        IWebElement HomeButton { get; set; }

        public List<WeekDays> CalendarHeaders => this.CalendarHeaderContainer.Select(p => new WeekDays(p)).ToList();

        public IList<DayColumn> CalendarColumns => this.CalendarColumnContainer.Select(p => new DayColumn(p)).ToList();

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

        public void ValidateWindow(string ExpectedTitle)
        {
            Assert.IsTrue(Name.Exist());
            Assert.IsTrue(DaysViewButton.Exist());
            Assert.IsTrue(WeeksViewButton.Exist());
            Assert.IsTrue(AddWeekButton.Exist());
            Assert.IsTrue(DeleteWeekButton.Exist());

            Assert.AreEqual(ExpectedTitle, Name.Text);
            Assert.AreEqual("DAYS", DaysViewButton.Text);
            Assert.AreEqual("WEEKS", WeeksViewButton.Text);

            Artefacts.TakeScreenshot();
        }

        public void WaitPageLoad()
        {
            Driver.WaitListItemsLoad(CalendarHeaderContainer);
            Driver.WaitIsClickable(DaysViewButton);
            Driver.WaitElementToDisappear(SpinningWheel);
        }

        public void AddMealPeriod(string weekDayName)
        {
            CalendarHeaders.First(c => c.Name.StartsWith(weekDayName, System.StringComparison.CurrentCultureIgnoreCase)).UseMealPeriodButton();
        }

        public void OpenDailyPlanningForDay(string weekDay)
        {
            Driver.WaitElementToDisappear(Backdrop);
            var dayLink = DaysLinks.First(x => x.Text.Contains(weekDay.ToUpper()));
            dayLink.Click();
            var indexOfDay = DaysLinks.IndexOf(dayLink);

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
    }
}