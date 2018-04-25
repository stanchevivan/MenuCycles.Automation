using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningTabDays : PlanningView
    {
        public PlanningTabDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = ".main > div")]
        IList<IWebElement> MealPeriodWrappers { get; set; }
        [FindsBy(How = How.ClassName, Using = "main")]
        IWebElement PageContent { get; set; }
        [FindsBy(How = How.ClassName, Using = "mainheader")] //Investigate if more suitable element for the check is needed
        IWebElement EngineCheck { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()='Weeks']")] // Engine
        IWebElement WeeksButton { get; set; }

        public IList<DailyMealPeriod> MealPeriods => this.MealPeriodWrappers.Select(p => new DailyMealPeriod(p)).ToList();

        public override void WaitForLoad()
        {
            Driver.WaitElementToExists(PageContent);
            base.WaitForLoader();
        }

        public void SwitchToWeeklyView()
        {
            WeeksButton.Click();
        }

        public bool IsEngineLoaded()
        {
            return EngineCheck.Exist();
        }

        public void ExpandMealPeriod(string periodName)
        {
            GetMealPeriod(periodName).Expand();
        }

        public void CollapseMealPeriod(string periodName)
        {
            GetMealPeriod(periodName).Collapse();
        }

        public bool IsMealPeriodExpanded(string periodName)
        {
            return GetMealPeriod(periodName).IsExpanded;
        }

        public DailyMealPeriod GetMealPeriod(string name)
        {
            return MealPeriods.First(x => x.Name == name.ToUpper());
        }

        public IList<string> GetMealPeriodColours()
        {
            return MealPeriods.Select(x => x.Colour).ToList();
        }
    }
}
