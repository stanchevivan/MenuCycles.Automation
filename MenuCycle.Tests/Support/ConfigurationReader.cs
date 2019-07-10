using System;
using System.IO;
using System.Json;

namespace MenuCycle.Tests.Support
{
    public class ConfigurationReader
    {
        private readonly JsonValue m_Configuration;
        private readonly string m_Environment;

        // TODO: Decide best approach to read configuration
        public ConfigurationReader(string environment)
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "MenuCycle.Tests.Support.EnvironmentConfig.json";

            string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Support/Environment.config"));

            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //using (StreamReader reader = new StreamReader(stream))
            //{
                m_Configuration = JsonValue.Parse(result);
            //}
            m_Environment = environment;
        }

        public string URL => m_Configuration[m_Environment]["URL"];
        public string URL_Salesforce => m_Configuration[m_Environment]["URL_SF"];
        public string User => m_Configuration[m_Environment]["User"];
        public string Password => m_Configuration[m_Environment]["Password"];
    }
}