using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class BuffetItem
    {
        public BuffetItem(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "tooltipstered")]
        private IWebElement title { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".item-type")]
        private IWebElement type { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".add-item-button-text")]
        [FindsBy(How = How.CssSelector, Using = ".recipe-bin")]
        private IWebElement ActionButton { get; set; }

        public string Title => title.Text;
        public string Type => type.Text;

        public void Add()
        {
            ActionButton.Click();
        }
    }
}
