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
        public IList<IWebElement> CalendarHeaders { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#dailyCalendarTableHolder .daily-view-screen > div")]
        public IList<IWebElement> CalendarColumns { get; set; }

        public void ValidateWindow(string ExpectedTitle)
        {
            WaitPageLoad();

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
            Driver.WaitListItemsLoad(CalendarHeaders);
            Driver.WaitIsClickable(DaysViewButton);
            Driver.WaitElementToDisappear(SpinningWheel);
        }

        public void AddMealPeriod(string weekDayName)
        {
            WaitPageLoad();
            CalendarHeaders.ToPageObjectList<WeekDays>(Driver).Find(c => c.Name.Text.StartsWith(weekDayName)).MealPeriodButton.Click();
        }

        public void ValidateMealPeriod(string weekDay, MealPeriod expectedMealPeriod, List<Recipe> expectedRecipes)
        {
            int columnIndex = CalendarHeaders.ToPageObjectList<WeekDays>(Driver)
                                .FindIndex(c => c.Name.Text.StartsWith(weekDay));

            var test = CalendarColumns.ToPageObjectList<DayColumn>(Driver)[columnIndex];

            MealPeriodCard mealPeriodCard = test
                                    .MealPeriodCards.ToPageObjectList<MealPeriodCard>(Driver)
                                    .First(m => m.Name.Text == expectedMealPeriod.Name);

            Assert.GreaterOrEqual(mealPeriodCard.Recipes.Count, expectedRecipes.Count);

            foreach (var item in expectedRecipes)
            {
                Assert.IsTrue(mealPeriodCard.Recipes.Any(r => r.Text == item.Name));
            }
        }
    }
}
