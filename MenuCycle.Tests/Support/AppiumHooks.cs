using System;
using Fourth.Automation.Framework.Core;
using Fourth.Automation.Framework.Mobile;
using Fourth.Automation.Framework.Mobile.Appium;
using Fourth.Automation.Framework.Mobile.Resolvers;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MenuCycle.Tests.Support
{
    [Binding]
    public sealed class AppiumHooks
    {
        [Binding]
        public sealed class AppiumServerForTestRun
        {
            private static readonly AppiumDebugServers appiumServers;

            static AppiumServerForTestRun()
            {
                appiumServers = new AppiumDebugServers(
                    new TerminalCommand[] {
                    new AppiumServer(DriverFactory.DriverInfo),
                    new IOSWebkitDebugProxy(DriverFactory.DriverInfo) });
            }

            [BeforeTestRun]
            public static void BeforeTestRun()
            {
                DriverFactory.Resolvers.Add(new AndroidResolver());
                DriverFactory.Resolvers.Add(new IOSResolver());
                appiumServers.Start(DriverFactory.DriverInfo);
            }

            [AfterTestRun]
            public static void AfterTestRun()
            {
                appiumServers.Stop();
            }
        }
    }
}