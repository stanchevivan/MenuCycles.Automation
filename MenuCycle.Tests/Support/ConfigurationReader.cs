using System;
using System.IO;
using System.Json;

namespace MenuCycle.Tests.Support
{
    public class ConfigurationReader
    {
        private readonly JsonValue configuration;
        private readonly string environment;

        public ConfigurationReader(string environment)
        {
            string result = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Support/Environment.config"));
            configuration = JsonValue.Parse(result);
            this.environment = environment;
        }

        public string URL => this.configuration[environment]["URL"];
        public string URL_Salesforce => this.configuration[environment]["URL_SF"];
        public string User => this.configuration[environment]["User"];
        public string Password => this.configuration[environment]["Password"];
    }
}