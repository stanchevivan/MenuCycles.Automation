using System.Linq;
using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycles.Tests.PageObjects
{
    public class FourthHomePage : BasePage
    {
		#region Constructor
        public FourthHomePage(IWebDriver webDriver) : base(webDriver){}
		#endregion

		#region PageObjects
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Menu Cycles']")]
        private IWebElement LNK_MenuCycles { get; set; }
        [FindsBy(How = How.ClassName, Using = "icon-interface-sidebar-hamburger")]
		private IWebElement ICN_Hamburger { get; set; }
		[FindsBy(How = How.ClassName, Using = "menu-minimised")]
        private IWebElement MinimizedMenu { get; set; }
		#endregion

		#region Methods
        private void SwitchToTab()
		{
			Driver.AsMobile().SwitchToWebViewContext();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
		}

        public LoginPage OpenMenuCycles()
        {
            Driver.WaitElementToExists(LNK_MenuCycles);
            LNK_MenuCycles.Click();
			SwitchToTab();

            return new LoginPage(Driver);
        }
        #endregion
    }
}
