using TechTalk.SpecFlow;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
using BoDi;
using OpenQA.Selenium;
using System.Collections.Generic;
using MenuCycles.AutomatedTests.Model;
using System.Linq;
using MenuCyclesData;

namespace MenuCycles.AutomatedTests.Hooks
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
            DataSeeding data = new DataSeeding();
            data.DeleteScenarioData(scenarioContext.Get<List<MenuCycle>>().Select(c => c.Name).ToList());
            driver.Quit();
        }
    }
}

