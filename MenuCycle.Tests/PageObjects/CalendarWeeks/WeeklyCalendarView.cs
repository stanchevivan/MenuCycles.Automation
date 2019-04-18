using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;using OpenQA.Selenium;using OpenQA.Selenium.Support.PageObjects;namespace MenuCycle.Tests.PageObjects{    public class WeeklyCalendarView : MenuCyclesBasePage    {        public WeeklyCalendarView(IWebDriver webDriver) : base(webDriver)        {        }        [FindsBy(How = How.Id, Using = "weeklyReportBtn")]        private IWebElement ReportsTab { get; set; }        [FindsBy(How = How.Id, Using = "weeklyReviewBtn")]        private IWebElement ReviewTab { get; set; }
        [FindsBy(How = How.ClassName, Using = "weekly-view-item")]
        private IList<IWebElement> CalendarWeek { get; set; }

        [FindsBy(How = How.ClassName, Using = "weekly-view-list")]
        private IWebElement WeeklyViewList { get; set; }

        [FindsBy(How = How.ClassName, Using = "weekly-day-container")]
        private IList<IWebElement> dayContainers { get; set; }
        public IList<CalendarWeek> CalendarWeeks => this.CalendarWeek.Select(p => new CalendarWeek(p)).ToList();
        public void OpenReportsTab()        {            ReportsTab.Click();        }        public void ClickReviewTab()        {            ReviewTab.Click();        }

        public void WaitForLoad()
        {
            Driver.WaitElementToExists(WeeklyViewList);
        }

        public CalendarWeek GetWeek(string weekName)
        {
            if (!CalendarWeeks.Any(x => x.WeekTitle == weekName.ToUpper()))
            {
                throw new System.Exception($"Week {weekName} not found !");
            }
            return CalendarWeeks.First(x => x.WeekTitle == weekName.ToUpper());
        }    }}