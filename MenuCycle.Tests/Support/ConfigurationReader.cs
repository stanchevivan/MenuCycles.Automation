using System;
using System.IO;
using System.Json;
using System.Reflection;

namespace MenuCycle.Tests.Support
{
    public class ConfigurationReader
    {
        private readonly JsonValue m_Configuration;
        private readonly string m_Environment;

        public ConfigurationReader(string environment)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "MenuCycle.Tests.Support.EnvironmentConfig.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                m_Configuration = JsonValue.Parse(json);
            }
            m_Environment = environment;
        }

        public string URL => m_Configuration[m_Environment]["URL"];
        public string URL_Salesforce => m_Configuration[m_Environment]["URL_SF"];
        public string User => m_Configuration[m_Environment]["User"];
        public string Password => m_Configuration[m_Environment]["Password"];
    }
}