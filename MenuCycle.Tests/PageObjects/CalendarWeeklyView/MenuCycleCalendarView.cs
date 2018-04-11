using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using MenuCycle.Data.Models;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCycleCalendarView : BasePage
    {
        private readonly IArtefacts Artefacts;

        public MenuCycleCalendarView(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.Id, Using = "menucycleName")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "daysTab")]
        public IWebElement DaysViewButton { get; set; }

        [FindsBy(How = How.Id, Using = "weeksTab")]
        public IWebElement WeeksViewButton { get; set; }

        [FindsBy(How = How.Id, Using = "daily-view-add-week-button")]
        public IWebElement AddWeekButton { get; set; }

        [FindsBy(How = How.Id, Using = "delWeekbtn")]
        public IWebElement DeleteWeekButton { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
        public IWebElement SpinningWheel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-header-container > div")]
        public IList<IWebElement> CalendarHeaderContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-view-screen > div")]
        public IList<IWebElement> CalendarColumnContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "daily-calendar-heading")]
        public IList<IWebElement> DaysLinks { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".Planning-engine")]
        public IList<IWebElement> PlanningLinks { get; set; }

        public List<WeekDays> CalendarHeaders => this.CalendarHeaderContainer.Select(p => new WeekDays(p)).ToList();

        public IList<DayColumn> CalendarColumns => this.CalendarColumnContainer.Select(p => new DayColumn(p)).ToList();

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
            CalendarHeaders.First(c => c.Name.Text.StartsWith(weekDayName)).MealPeriodButton.Click();
        }

        public void ValidateMealPeriod(string weekDay, MealPeriods expectedMealPeriod, Recipes expectedRecipes)
        {
            //Gets index for column of specified week day
            int columnIndex = CalendarHeaders.FindIndex(c => c.Name.Text.StartsWith(weekDay));

            //Gets the meal period
            MealPeriodCard mealPeriodCard = CalendarColumns[columnIndex].MealPeriodCards.First(m => m.Name.Text == expectedMealPeriod.Name.ToUpper());

            Assert.AreEqual(1, mealPeriodCard.Recipes.Count);
            Assert.AreEqual(expectedRecipes.Name, mealPeriodCard.Recipes[0].Text);
        }

        public void OpenDailyPlanningForDay(string weekDay)
        {
            var dayLink = DaysLinks.First(x => x.Text.Contains(weekDay.ToUpper()));
            dayLink.Click();
            int indexOfDay = DaysLinks.IndexOf(dayLink);

            var planningLink = PlanningLinks[indexOfDay];
            Driver.WaitElementAndClick(planningLink);
        }
    }
}
