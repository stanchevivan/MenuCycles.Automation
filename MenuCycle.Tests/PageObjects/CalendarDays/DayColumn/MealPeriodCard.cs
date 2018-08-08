using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    // TODO: public IWebElements => private
    public class MealPeriodCard
    {
        IWebElement parent;

        public MealPeriodCard(IWebElement parent)
        {
            this.parent = parent;
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-title")]
        private IWebElement name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".daily-item-item-contain > div > div")]
        public IList<IWebElement> Recipes { get; set; }

        [FindsBy(How = How.ClassName, Using = "mp-has-arrow")]
        private IWebElement ExpandCollapseArrow { get; set; }

        [FindsBy(How = How.ClassName, Using = "mp-open")]
        private IWebElement Expanded { get; set; }


        public string Colour => parent.GetCssValue("background-color");
        public string Name => name.Text;
        public bool IsExpanded => Expanded.Get().ElementPresent;
        public bool IsExpandable => ExpandCollapseArrow.Get().ElementPresent;

        public void OpenMealPeriodDetails()
        {
            name.Click();
        }

        public void Expand()
        {
            if (!IsExpanded)
            {
                ExpandCollapseArrow.Click();
            }
        }

        public void Collapse()
        {
            if (IsExpanded)
            {
                ExpandCollapseArrow.Click();
            }
        }
    }
}
