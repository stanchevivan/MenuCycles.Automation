using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCycleItem
    {
        public MenuCycleItem(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".name_title a")]
        private IWebElement name { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".name_sub")]
        private IWebElement description { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".home-button-expand")]
        private IWebElement actionButton { get; set; }

        public string Name => name.Text;
        public string Description => description.Text;

        public void Select()
        {
            name.Click();
        }
    }
}
