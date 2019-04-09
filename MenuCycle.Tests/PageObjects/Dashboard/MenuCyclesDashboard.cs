using System.Collections.Generic;
using System.Linq;
using Fourth.Automation.Framework.Extension;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycle.Tests.PageObjects
{
    public class MenuCyclesDashboard : MenuCyclesBasePage
    {
        public MenuCyclesDashboard(IWebDriver webDriver) : base(webDriver)
        {
        }

        [FindsBy(How = How.CssSelector, Using = "div[class='borbot clickable']")]
        public IWebElement CreateMenuCycleButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menuCycleTableBody .home-div-row")]
        //[FindsBy(How = How.CssSelector, Using = ".empty-menucycle")]
        public IList<IWebElement> menuCycleRows { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".menuCycleTableBody")]
        public IWebElement searchResultsBody { get; set; }

        [FindsBy(How = How.ClassName, Using = "no-result-text")]
        private IWebElement NoResultsText { get; set; }

        [FindsBy(How = How.ClassName, Using = "search-icon")]
        private IWebElement SearchIcon { get; set; }

        [FindsBy(How = How.ClassName, Using = "menucycle-search-input")]
        private IWebElement SearchInput { get; set; }

        [FindsBy(How = How.ClassName, Using = "home-search-button")]
        private IWebElement SearchButton { get; set; }

        [FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
        IWebElement SpinningWheel { get; set; }

        [FindsBy(How = How.ClassName, Using = "current-location-name")]
        private IWebElement LocationName { get; set; }

        public IList<MenuCycleItem> MenuCycles => this.menuCycleRows.Select(p => new MenuCycleItem(Driver, p)).ToList();

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
            if (!SearchButton.Displayed)
            {
                SearchIcon.Click();
                Driver.WaitIsClickable(SearchButton);
            }

            SearchInput.Do(Driver).ClearWithoutFocusOut();
            SearchInput.SendKeys(text);
            SearchButton.Click();
            Driver.WaitElementToDisappear(SpinningWheel);
        }

        public void WaitPageLoad()
        {
            Driver.WaitElementToDisappear(SpinningWheel);
            Driver.WaitElementToExists(searchResultsBody);
            if (!NoResultsText.Exist())
            {
                Driver.WaitListItemsLoad(menuCycleRows);
            }
        }

        public bool IsCreateMenuCycleButtonPresent()
        {
            return CreateMenuCycleButton.Get().ElementPresent;
        }

        public void UseCreateMenuCycleButton()
        {
            Driver.WaitIsClickable(CreateMenuCycleButton);
            CreateMenuCycleButton.Click();
        }

        public MenuCycleItem GetMenuCycle(string name)
        {
            return MenuCycles.First(x => x.Name == name);
        }

        public void ClickLocationName()
        {
            LocationName.Click();
        }
    }
}