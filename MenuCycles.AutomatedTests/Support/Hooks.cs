﻿using TechTalk.SpecFlow;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Reporting;
using BoDi;
using OpenQA.Selenium;

namespace MenuCycles.AutomatedTests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer objectContainer;
        private IWebDriver driver;

        public Hooks(IObjectContainer container)
        {
            this.objectContainer = container;
            this.objectContainer.RegisterTypeAs<Artefacts, IArtefacts>();
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

