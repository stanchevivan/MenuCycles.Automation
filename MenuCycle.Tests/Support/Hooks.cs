using System;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Mobile.Resolvers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Support
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver driver;
        private ScenarioContext scenarioContext;

        public Hooks(IWebDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;
            this.scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            DisposeDriverService.TestRunStartTime = DateTime.Now;
            DriverFactory.Resolvers.Add(new AndroidResolver());
            DriverFactory.Resolvers.Add(new IOSResolver());
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (this.driver.IsMobile())
            {
                this.driver.Quit();
            }
            else
            {
                // TODO: Driver.Close when driver instance can be reused
                this.driver.Quit();
            }
        }

        [AfterFeature]
        public static void AfterTestRun()
        {
            // DisposeDriverService.DisposeAllDrivers();
        }
    }
}