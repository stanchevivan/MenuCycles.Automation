using OpenQA.Selenium;

namespace MenuCycles.Tests
{
    public class MenuCycle
    {
        public IWebElement NameLink;
        public IWebElement MoreButton;

        public string Name => NameLink.Text;
        public string Description;
        public bool Published;
    }
}
