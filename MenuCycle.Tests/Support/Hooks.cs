using TechTalk.SpecFlow;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
using BoDi;
using OpenQA.Selenium;
using MenuCycle.Data.Services;
using Fourth.Automation.Framework.Mobile.Resolvers;

namespace MenuCycle.Tests.Support
{
    [Binding]
    public sealed class Hooks
    {
        readonly IObjectContainer objectContainer;
        IWebDriver driver;
        ScenarioContext scenarioContext;
        public Hooks(IObjectContainer container, ScenarioContext scenarioContext)
        {
            this.objectContainer = container;
            this.objectContainer.RegisterTypeAs<Artefacts, IArtefacts>();
            this.scenarioContext = scenarioContext;
            this.objectContainer.RegisterFactoryAs<DefaultValues>(d => 
                d.Resolve<DefaultValuesService>().GetDefaults(36, 1, "SodexoUp"));
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
            driver = DriverFactory.Create();
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}

