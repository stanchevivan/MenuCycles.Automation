using System;
using System.Configuration;
using Fourth.Automation.Framework.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MenuCycle.Tests.Support
{
    public static class LocalDriver
    {
        private static IWebDriver instance;

        public static IWebDriver Driver
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChromeDriver(ChromeDriverService.CreateDefaultService(), SetCapabilities(driverInfo), driverInfo.Timeout.DriverCommands);
                }
                return instance;
            }
        }

        private static IDriverInfo driverInfo => (FourthSection)ConfigurationManager.GetSection("fourth");

        /// <summary>
        /// Set capabilities for chrome driver driver
        /// </summary>
        /// <param name="driverInfo">The driver information.</param>
        /// <returns>Object with capabilities set</returns>
        public static dynamic SetCapabilities(IDriverInfo driverInfo)
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments(driverInfo.CapabilitiesList);

            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);

            if (driverInfo.MobileEmulation.DeviceName != string.Empty)
            {
                chromeOptions.EnableMobileEmulation(driverInfo.MobileEmulation.DeviceName);
            }

            return chromeOptions;
        }

        public static void Quit()
        {
            Driver.Quit();
        }
    }
}
