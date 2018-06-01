using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class DayColumn
    {
        public DayColumn(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-container-div")]
        private IList<IWebElement> MealPeriodCardContainer { get; set; }

        public IList<MealPeriodCard> MealPeriodCards => this.MealPeriodCardContainer.Select(p => new MealPeriodCard(p)).ToList();
    }
}
