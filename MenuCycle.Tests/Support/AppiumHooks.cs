namespace MenuCycle.Tests.Support
{
    using Fourth.Automation.Framework.Core;
    using Fourth.Automation.Framework.Mobile;
    using Fourth.Automation.Framework.Mobile.Appium;
    using Fourth.Automation.Framework.Mobile.Resolvers;
    using TechTalk.SpecFlow;

    [Binding]
    public static class AppiumHooks
    {
            private static readonly AppiumDebugServers AppiumServers;

            static AppiumHooks()
            {
                AppiumServers = new AppiumDebugServers(
                    new TerminalCommand[] {
                    new AppiumServer(DriverFactory.DriverInfo),
                    new IOSWebkitDebugProxy(DriverFactory.DriverInfo) });
            }

            [BeforeTestRun]
            public static void BeforeTestRun()
            {
                DriverFactory.Resolvers.Add(new AndroidResolver());
                DriverFactory.Resolvers.Add(new IOSResolver());
                AppiumServers.Start(DriverFactory.DriverInfo);
            }

            [AfterTestRun]
            public static void AfterTestRun()
            {
                AppiumServers.Stop();
            }
    }
}