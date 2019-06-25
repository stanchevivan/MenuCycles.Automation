using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Page;
using OpenQA.Selenium;

namespace MenuCycle.Tests
{
    public static class Do_Extension
    {
        public static Do Do(this IWebElement element, IWebDriver driver)
        {
            return new Do(element, driver);
        }
    }

    public class Do : BasePage
    {
        readonly IWebElement webElement;

        public Do(IWebElement element, IWebDriver webDriver) : base(webDriver)
        {
            webElement = element;
        }

        public void Click()
        {
            webElement.Click();
        }

        public void JavaScriptClick()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].click();", webElement);
        }

        public void HighlightAndClick()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].style.border='3px solid lightgreen'", webElement);
            System.Threading.Thread.Sleep(200);
            webElement.Click();
        }

        public void FocusOut()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].blur();", webElement);
        }

        public void FocusIn()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].focus();", webElement);
        }

        public void ClearAndSendKeys(string text)
        {
            webElement.Clear();
            webElement.SendKeys(text);
            FireChangeEvent();
        }

        public void SendKeys(string text)
        {
            webElement.SendKeys(text);
        }

        public void JavaScriptSendKeys(string text)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript(@"arguments[0].value='" + text + "';", webElement, text);
        }

        public void ClearWithoutFocusOut()
        {
            FocusIn();
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].value='';", webElement);
        }

        public void ScrollIntoView()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView();", webElement);
        }

        public void FireChangeEvent()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("var evt = document.createEvent(\"HTMLEvents\");\n    evt.initEvent(\"change\", true, false);\n    arguments[0].dispatchEvent(evt);", webElement);

        }

        public void InputDate(string text)
        {
            webElement.Click();
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].removeAttribute('readonly')", webElement);
            webElement.Clear();
            webElement.SendKeys(Keys.Enter); // Needed for JavaScriptSendKeys to work
            webElement.Do(Driver).JavaScriptSendKeys(text);
            webElement.SendKeys(Keys.Enter);
        }
    }
}