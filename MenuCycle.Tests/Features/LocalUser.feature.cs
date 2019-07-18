// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MenuCycle.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("LocalUser")]
    [NUnit.Framework.CategoryAttribute("QAI")]
    public partial class LocalUserFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LocalUser.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "LocalUser", "    Meal Peridos functionalities and validations", ProgrammingLanguage.CSharp, new string[] {
                        "QAI"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Local user can not delete menu cycle")]
        [NUnit.Framework.CategoryAttribute("TC27777")]
        [NUnit.Framework.CategoryAttribute("Sanity")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "SE001", "Local User Testing", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void LocalUserCanNotDeleteMenuCycle(string environment, string withFA, string location, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC27777",
                    "Sanity"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Local user can not delete menu cycle", null, @__tags);
#line 6
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.When(string.Format("Menu Cycle \"{0}\" is searched", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
        testRunner.And(string.Format("action menu is opened for menu cycle \"{0}\"", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.Then(string.Format("Verify delete button is not present for menu cycle \"{0}\"", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
