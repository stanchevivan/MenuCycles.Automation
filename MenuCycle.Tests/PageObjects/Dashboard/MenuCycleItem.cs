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

        [FindsBy(How = How.CssSelector, Using = ".item-settings")]
        private IWebElement editButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".item-copy")]
        private IWebElement copyButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".item-delete")]
        private IWebElement deleteButton { get; set; }

        public string Name => name.Text;
        public string Description => description.Text;
        public bool IsDeleteButtonPresent => deleteButton.Get().ElementPresent;

        public void Select()
        {
            name.Click();
        }

        public void UseActionButton()
        {
            actionButton.Click();
        }
    }
}
