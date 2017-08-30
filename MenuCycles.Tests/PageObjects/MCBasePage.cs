using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;

namespace MenuCycles.Tests.PageObjects
{
    public class MCBasePage : BasePage
    {
		public MCBasePage(IWebDriver webDriver) : base(webDriver)
        {
			Driver.AsMobile().SwitchToWebViewContext();
		}
    }
}
