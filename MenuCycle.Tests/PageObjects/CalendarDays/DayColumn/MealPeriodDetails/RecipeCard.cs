using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeCard
    {
        public RecipeCard(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".item-name")]
        private IWebElement name { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".item-type")]
        private IWebElement type { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".cost-value")]
        private IWebElement cost { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".recipe-bin")]
        private IWebElement deleteButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".up-arrow")]
        private IWebElement upArrow { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".down-arrow")]
        private IWebElement downArrow { get; set; }

        public string Name => this.name.Text;
        public string Type => this.type.Text;
        public string Cost => this.cost.Text;

        public void Delete()
        {
            deleteButton.Click();
        }

        public void MoveUp()
        {
            upArrow.Click();
        }

        public void MoveDown()
        {
            downArrow.Click();
        }
    }
}
