using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using Fourth.Automation.Framework.Reporting;
using MenuCyclesData.DatabaseDataModel;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace MenuCycles.AutomatedTests.PageObjects
{
    public class MenuCycleCalendarView : BasePage
    {
        private readonly IArtefacts Artefacts;

        public MenuCycleCalendarView(IWebDriver webDriver, IArtefacts artefacts) : base(webDriver)
        {
            Artefacts = artefacts;
        }

        [FindsBy(How = How.Id, Using = "menucycleName")]
        public IWebElement MenuCycleName { get; set; }

        [FindsBy(How = How.Id, Using = "daysTab")]
        public IWebElement DaysViewButton { get; set; }

        [FindsBy(How = How.Id, Using = "weeksTab")]
        public IWebElement WeeksViewButton { get; set; }

        [FindsBy(How = How.Id, Using = "daily-view-add-week-button")]
        public IWebElement AddWeekButton { get; set; }

        [FindsBy(How = How.Id, Using = "delWeekbtn")]
        public IWebElement DeleteWeekButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".daily-header-div")]
        public IWebElement CalendarWeek { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
        public IWebElement SpinningWheel { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-header-container > div")]
        public IList<IWebElement> WeekDays { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-view-screen > div")]
        public IList<IWebElement> DayColumns { get; set; }

        public void ValidateWindow(string TitleExpected)
        {
            WaitPageLoad();

            Assert.IsTrue(MenuCycleName.Exist());
            Assert.IsTrue(DaysViewButton.Exist());
            Assert.IsTrue(WeeksViewButton.Exist());
            Assert.IsTrue(AddWeekButton.Exist());
            Assert.IsTrue(DeleteWeekButton.Exist());
            Assert.IsTrue(CalendarWeek.Exist());

            Assert.AreEqual(TitleExpected, MenuCycleName.Text);
            Assert.AreEqual("DAYS", DaysViewButton.Text);
            Assert.AreEqual("WEEKS", WeeksViewButton.Text);

            Artefacts.TakeScreenshot();
        }

        public void WaitPageLoad()
        {
            Driver.WaitElementToExists(CalendarWeek);
            Driver.WaitIsClickable(DaysViewButton);
            Driver.WaitElementToDisappear(SpinningWheel);
        }

        public void AddMealPeriod(string weekDayName)
        {
            WaitPageLoad();
            List<WeekDays> weekDaysList = WeekDays.ToPageObjectList<WeekDays>(Driver);
            weekDaysList.Find(c => c.WeekDayName.Text.StartsWith(weekDayName)).MealPeriodButton.Click();

        }

        public void ValidateMealPeriod(string weekDay, MealPeriod mp, List<Recipe> recipes)
        {
            List<WeekDays> weekDaysList = WeekDays.ToPageObjectList<WeekDays>(Driver);
            int column = weekDaysList.FindIndex(c => c.WeekDayName.Text.StartsWith(weekDay));
            List<MealPeriodCard> mealperiodcard = DayColumns.ToPageObjectList<DayColumn>(Driver)[column].MealPeriodCards.ToPageObjectList<MealPeriodCard>(Driver); ;
            var correcntMealPeriod = mealperiodcard.Find(m => m.MealPeriodName.Text == mp.Name);

            Assert.GreaterOrEqual(correcntMealPeriod.Recipes.Count, recipes.Count);
            foreach (var item in recipes)
            {
                Assert.IsTrue(correcntMealPeriod.Recipes.Any(r => r.Text == item.Name));
                Assert.IsTrue(correcntMealPeriod.Recipes.Any(r => r.Text == "Ronald"));
            }
            


        }
    }
}
