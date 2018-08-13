using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class RecipeDetailsView : MenuCyclesBasePage
    {
        public RecipeDetailsView(IWebDriver webDriver) : base(webDriver)
        {
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "recipe-popup-overview-tab")]
        private IWebElement OverviewButton { get; set; }

        [FindsBy(How = How.Id, Using = "recipe-popup-method-tab")]
        private IWebElement MethodButton { get; set; }

        [FindsBy(How = How.Id, Using = "recipe-popup-nutrition-tab")]
        private IWebElement NutritionButton { get; set; }

        [FindsBy(How = How.Id, Using = "recipe-popup-intolerance-tab")]
        private IWebElement IntoleranceButton { get; set; }

        [FindsBy(How = How.ClassName, Using = "recipe-popup-close-image")]
        private IWebElement CrossButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".recipe-popup-title-big:nth-of-type(1)")]
        private IWebElement Title { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".recipe-popup-title-big:nth-of-type(2)")]
        private IWebElement Price { get; set; }

        public string GetRecipeTitleText => Title.Text;
        public string GetRecipePriceText => Price.Text;

        public void UseOverviewButton()
        {
            OverviewButton.Click();
        }

        public void UseMethodButton()
        {
            MethodButton.Click();
        }

        public void UseNutritionButton()
        {
            NutritionButton.Click();
        }

        public void UseIntoleranceButton()
        {
            IntoleranceButton.Click();
        }

        public void UseCrossButton()
        {
            CrossButton.Click();
        }
    }
}
