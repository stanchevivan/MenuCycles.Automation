using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Mobile.Resolvers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Support
{
    [Binding]
    public sealed class Hooks
    {
        IWebDriver driver;
        ScenarioContext scenarioContext;
        public Hooks(IWebDriver driver, ScenarioContext scenarioContext)
        {
            this.driver = driver;

            this.scenarioContext = scenarioContext;
            // this.objectContainer.RegisterFactoryAs(d => 
            //    d.Resolve<DefaultValuesService>().GetDefaults(36, 1, "SodexoUp"));
        }


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
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
            driver.Quit();
        }
    }
}

