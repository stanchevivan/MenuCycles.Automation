using System;
using System.Linq;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Mobile.Resolvers;
using MenuCycle.Tests.PageObjects;
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
            if (driver.IsMobile())
            {
                driver.Quit();
            }
            else
            {
                //driver.Quit();
                // TODO: Driver.Close when driver instance can be reused

                if (scenarioContext.ContainsKey("UserWithOneLocation") && scenarioContext.Get<bool>("UserWithOneLocation"))
                {
                    AfterFeature();
                }
                else
                {
                    LocalDriver.Driver.Close();
                    LocalDriver.Driver.SwitchTo().Window(driver.WindowHandles.Last());
                }
            }
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            LocalDriver.Driver.Close();
            LocalDriver.Driver.SwitchTo().Window(LocalDriver.Driver.WindowHandles.Last());
            FourthAppLocalPage.SignOut();
            FourthAppLocalPage.WaitMainPageToLoad();
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            //DisposeDriverService.DisposeAllDrivers();
            LocalDriver.Quit();
        }
    }
}