using TechTalk.SpecFlow;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
using BoDi;
using OpenQA.Selenium;
using MenuCycle.Data.Services;

namespace MenuCycle.Tests.Support
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver driver;
        private ScenarioContext scenarioContext;
        public Hooks(IObjectContainer container, ScenarioContext scenarioContext)
        {
            this.objectContainer = container;
            this.objectContainer.RegisterTypeAs<Artefacts, IArtefacts>();
            this.scenarioContext = scenarioContext;
            this.objectContainer.RegisterFactoryAs<DefaultValues>(d => 
                d.Resolve<DefaultValuesService>().GetDefaults(36, 1, "SodexoUp"));
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

