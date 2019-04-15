// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("MenuCycles")]
    public partial class MenuCyclesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MenuCycles.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MenuCycles", "    Menu Cycles functionalities and validations", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Search Menu Cycles by name or description")]
        [NUnit.Framework.CategoryAttribute("TC27713")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Meda", "FOR AUTOMATION TESTS - DO NOT TOUCH", "MC with recipes", "Testing the publishing of a MC with recipes", null, Category="QAI")]
        public virtual void SearchMenuCyclesByNameOrDescription(string environment, string mc1Name, string mc1Description, string mc2Name, string mc2Description, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC27713",
                    "Smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Menu Cycles by name or description", @__tags);
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
    testRunner.When(string.Format("Menu Cycle \"{0}\" is searched", mc1Description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table1.AddRow(new string[] {
                        string.Format("{0}", mc1Name),
                        string.Format("{0}", mc1Description)});
#line 9
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table1, "And ");
#line 12
    testRunner.When(string.Format("Menu Cycle \"{0}\" is searched", mc2Name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table2.AddRow(new string[] {
                        string.Format("{0}", mc2Name),
                        string.Format("{0}", mc2Description)});
#line 13
    testRunner.Then("Verify search results contain the following menu cycles", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Edit Copy Delete menu cycle")]
        [NUnit.Framework.CategoryAttribute("TC27706")]
        [NUnit.Framework.CategoryAttribute("TC27653")]
        [NUnit.Framework.CategoryAttribute("TC27658")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.TestCaseAttribute("QAI", null, Category="QAI")]
        public virtual void CreateEditCopyDeleteMenuCycle(string environment, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC27706",
                    "TC27653",
                    "TC27658",
                    "Smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Edit Copy Delete menu cycle", @__tags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "MenuCycleName",
                        "Description",
                        "GapDays",
                        "Usergroup"});
            table3.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description",
                        "Wednesday,Thursday",
                        "TestGroupPrice2"});
#line 27
    testRunner.When("Menu Cycle is created with following data", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Day"});
            table4.AddRow(new string[] {
                        "Wednesday"});
            table4.AddRow(new string[] {
                        "Thursday"});
#line 30
        testRunner.And("Verify GAP days in calendar view are", ((string)(null)), table4, "And ");
#line 34
        testRunner.And("Home button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table5.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description"});
#line 35
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table5, "And ");
#line 38
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is copied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table6.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description"});
            table6.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description"});
#line 39
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "MenuCycleName",
                        "Description"});
            table7.AddRow(new string[] {
                        "Automatically edited menu cycle",
                        "yes description"});
#line 43
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is edited to", ((string)(null)), table7, "And ");
#line 46
        testRunner.And("Home button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table8.AddRow(new string[] {
                        "Automatically edited menu cycle",
                        "yes description"});
            table8.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description"});
#line 47
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table8, "And ");
#line 51
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
        testRunner.And("Menu Cycle \"Automatically edited menu cycle\" is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
    testRunner.Then("Verify search results contain no menu cycles", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
        testRunner.And("Menu Cycle \"Automatically edited menu cycle\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
    testRunner.Then("Verify search results contain no menu cycles", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
