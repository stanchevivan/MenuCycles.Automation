using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class Ingredient
    {
        public Ingredient(IWebElement parent)
        {
            PageFactory.InitElements(parent, this);
        }

        [FindsBy(How = How.ClassName, Using = "overview-desccription-col-ingredients")]
        private IWebElement name { get; set; }

        [FindsBy(How = How.ClassName, Using = "overview-desccription-col-quantity")]
        private IWebElement quantity { get; set; }

        [FindsBy(How = How.ClassName, Using = "overview-desccription-col-cost")]
        private IWebElement cost { get; set; }

        public string Name => name.Text;
        public string Quantity => quantity.Text;
        public string Cost => cost.Text;

    }
}
