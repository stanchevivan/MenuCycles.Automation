using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCyclesDashboard : BasePage
    {
        public MenuCyclesDashboard(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='borbot clickable']")]
        public IWebElement CreateMenuCycleButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menuCycleTableBody .home-div-row")]
        public IList<IWebElement> MenuCyclesContainer { get; set; }

        [FindsBy(How = How.ClassName, Using = "search-icon")]
        private IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.ClassName, Using = "menucycle-search-input")]
        private IWebElement SearchInput { get; set; }

        [FindsBy(How = How.ClassName, Using = "home-search-button")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
        IWebElement SpinningWheel { get; set; }

        public IList<MenuCycleItem> MenuCycles => this.MenuCyclesContainer.Select(p => new MenuCycleItem(p)).ToList();

        public void CreateMenuCycleClick()
        {
            Driver.WaitElementAndClick(CreateMenuCycleButton);
        }

        public void SelectMenuCycleByName(string menuCycleName)
        {
            MenuCycles.First(v => v.Name == menuCycleName).Select();
        }

        public void SearchMenuCycle(string text)
        {
            if (SearchIcon.Displayed)
            {
                SearchIcon.Click();
            }

            SearchInput.ClearAndSendKeys(text);
            SearchButton.Click();
            Driver.WaitElementToDisappear(SpinningWheel);
        }

        public void WaitPageLoad()
        {
            Driver.WaitListItemsLoad(MenuCyclesContainer);
        }
    }
}
