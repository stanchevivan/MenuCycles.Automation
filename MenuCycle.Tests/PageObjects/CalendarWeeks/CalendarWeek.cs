using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class CalendarWeek
    {
        public CalendarWeek(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "week-controller_controller-container_title")]
        private IWebElement WeekName { get; set; }

        [FindsBy(How = How.ClassName, Using = "week-controller_controller-container_copy")]
        private IWebElement CopyButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "week-controller_controller-container_delete")]
        private IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "weekly-day-container")]
        private IList<IWebElement> MealPeriodWeeklyDayContainer { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".weekly-item_expand")]
        private IWebElement ExpandButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".weekly-view-row-item")]
        private IWebElement Row { get; set; }

        public IList<WeeklyDayContainer> DayContainers => this.MealPeriodWeeklyDayContainer.Select(day => new WeeklyDayContainer(day, day.Get().HasClass("non-serving-week"))).ToList();

        public string WeekTitle => WeekName.Text;
        public bool IsExpanded => Row.Get().HasClass("expanded-weekly-view-item");

        public void UseCopyButton()
        {
            CopyButton.Click();
        }

        public void UseDeleteButton()
        {
            DeleteButton.Click();
        }

        public void Expand()
        {
            if (!IsExpanded)
            {
                ExpandButton.Click();
            }
        }

        public void Collapse()
        {
            if (IsExpanded)
            {
                ExpandButton.Click();
            }
        }

        public WeeklyDayContainer GetDay(string weekDay)
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
                        throw new System.Exception($"Could not match day {weekDay}");
                    }
            }
            return DayContainers[dayIndex];
        }
    }
}
