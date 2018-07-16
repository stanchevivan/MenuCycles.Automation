using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeItem
    {
        public RecipeItem(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".recipe-name-underline")]
        private IWebElement title { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".item-type")]
        public IWebElement type { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".cost-value")]
        public IWebElement cost { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".add-item-button-text")]
        [FindsBy(How = How.CssSelector, Using = ".recipe-bin")]
        public IWebElement ActionButton { get; set; }

        public string Title => title.Text;
        public string Type => type.Text;
        public string Cost => cost.Text.Replace('•', ' ').Trim();

        public void Add()
        {
            ActionButton.Click();
        }
    }
}
