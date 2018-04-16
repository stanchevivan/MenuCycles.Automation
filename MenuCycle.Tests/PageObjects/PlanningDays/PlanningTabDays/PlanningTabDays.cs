using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class PlanningTabDays : DailyPlanningView
    {
        public PlanningTabDays(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.ClassName, Using = "mealperiod-wrapper")]
        private IList<IWebElement> MealPeriodWrappers { get; set; }
        [FindsBy(How = How.ClassName, Using = "main")]
        private IWebElement PageContent { get; set; }
        [FindsBy(How = How.ClassName, Using = "mainheader")] //Investigate if more suitable element for the check is needed
        private IWebElement EngineCheck { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[text()='Weeks']")] // Engine
        private IWebElement WeeksButton { get; set; }

        public IList<MealPeriodDays> MealPeriods => this.MealPeriodWrappers.Select(p => new MealPeriodDays(p)).ToList();

        public new void WaitForLoad()
        {
            Driver.WaitElementToExists(PageContent);
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
            MealPeriods.First(x => x.Name == periodName.ToUpper()).Expand();
        }

        public void CollapseMealPeriod(string periodName)
        {
            MealPeriods.First(x => x.Name == periodName.ToUpper()).Collapse();
        }

        public bool IsMealPeriodExpanded(string periodName)
        {
            return MealPeriods.First(x => x.Name == periodName.ToUpper()).IsExpanded();
        }

        public IList<string> GetMealPeriodColours()
        {
            return MealPeriods.Select(x => x.HeaderColour).ToList();
        }
    }
}
