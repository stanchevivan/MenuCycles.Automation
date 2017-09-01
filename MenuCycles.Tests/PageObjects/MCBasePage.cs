using Fourth.Automation.Framework.Extension;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace MenuCycles.Tests.PageObjects
{
    public class MCBasePage : BasePage
    {
		public MCBasePage(IWebDriver webDriver) : base(webDriver)
        {
			Driver.AsMobile().SwitchToWebViewContext();
            WaitForLoading();
		}

		[FindsBy(How = How.Id, Using = "BlueLoaderShowHide")]
		private IWebElement Loader { get; set; }

        protected void WaitForLoading()
        {
            Driver.WaitElementToDisappear(Loader);
        }
    }
}
