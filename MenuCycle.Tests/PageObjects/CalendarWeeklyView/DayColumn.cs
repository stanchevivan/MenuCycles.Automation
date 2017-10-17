using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Linq;

namespace MenuCycle.Tests.PageObjects
{
    public class DayColumn
    {
        public DayColumn(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-container-div")]
        public IList<IWebElement> MealPeriodCardContainer { get; set; }

        public IList<MealPeriodCard> MealPeriodCards => this.MealPeriodCardContainer.Select(p => new MealPeriodCard(p)).ToList();
    }
}
