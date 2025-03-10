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
    [NUnit.Framework.DescriptionAttribute("MenuCycles")]
    public partial class MenuCyclesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MenuCycles.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "MenuCycles", "    Menu Cycles functionalities and validations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Search Menu Cycles by name or description")]
        [NUnit.Framework.CategoryAttribute("TC27713")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "FOR AUTOMATION TESTS - DO NOT TOUCH", "MC with recipes", "Testing the publishing of a MC with recipes", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void SearchMenuCyclesByNameOrDescription(string environment, string withFA, string mc1Name, string mc1Description, string mc2Name, string mc2Description, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC27713",
                    "Smoke"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Search Menu Cycles by name or description", null, @__tags);
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
    testRunner.When(string.Format("Menu Cycle \"{0}\" is searched", mc1Description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table48.AddRow(new string[] {
                        string.Format("{0}", mc1Name),
                        string.Format("{0}", mc1Description)});
#line 9
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table48, "And ");
#line 12
    testRunner.When(string.Format("Menu Cycle \"{0}\" is searched", mc2Name), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table49.AddRow(new string[] {
                        string.Format("{0}", mc2Name),
                        string.Format("{0}", mc2Description)});
#line 13
    testRunner.Then("Verify search results contain the following menu cycles", ((string)(null)), table49, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Edit Copy Delete menu cycle")]
        [NUnit.Framework.CategoryAttribute("TC27706")]
        [NUnit.Framework.CategoryAttribute("TC27653")]
        [NUnit.Framework.CategoryAttribute("TC27658")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CreateEditCopyDeleteMenuCycle(string environment, string withFA, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Edit Copy Delete menu cycle", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                        "MenuCycleName",
                        "Description",
                        "GapDays",
                        "Usergroup"});
            table50.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description",
                        "Wednesday,Thursday",
                        "TestGroupPrice2"});
#line 27
    testRunner.When("Menu Cycle is created with following data", ((string)(null)), table50, "When ");
#line hidden
            TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                        "Day"});
            table51.AddRow(new string[] {
                        "Wednesday"});
            table51.AddRow(new string[] {
                        "Thursday"});
#line 30
        testRunner.And("Verify GAP days in calendar view are", ((string)(null)), table51, "And ");
#line 34
        testRunner.And("Home button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table52 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table52.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description"});
#line 36
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table52, "And ");
#line 39
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is copied", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table53 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table53.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description"});
#line 41
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table53, "And ");
#line hidden
            TechTalk.SpecFlow.Table table54 = new TechTalk.SpecFlow.Table(new string[] {
                        "MenuCycleName",
                        "Description"});
            table54.AddRow(new string[] {
                        "Automatically edited menu cycle",
                        "yes description"});
#line 44
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is edited to", ((string)(null)), table54, "And ");
#line 47
        testRunner.And("Home button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
        testRunner.And("Menu Cycle \"Automatically\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table55 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Description"});
            table55.AddRow(new string[] {
                        "Automatically edited menu cycle",
                        "yes description"});
            table55.AddRow(new string[] {
                        "Automatically created menu cycle",
                        "no description"});
#line 49
        testRunner.And("Verify search results contain the following menu cycles", ((string)(null)), table55, "And ");
#line 53
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
        testRunner.And("Menu Cycle \"Automatically edited menu cycle\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
        testRunner.And("Menu Cycle \"Automatically edited menu cycle\" is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
        testRunner.And("Menu Cycle \"Automatically created menu cycle\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
    testRunner.Then("Verify search results contain no menu cycles", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
        testRunner.And("Menu Cycle \"Automatically edited menu cycle\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
    testRunner.Then("Verify search results contain no menu cycles", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create menu cycle page is opened after reopening of the application")]
        [NUnit.Framework.CategoryAttribute("TC40441")]
        [NUnit.Framework.CategoryAttribute("D36216")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CreateMenuCyclePageIsOpenedAfterReopeningOfTheApplication(string environment, string withFA, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC40441",
                    "D36216"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create menu cycle page is opened after reopening of the application", null, @__tags);
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 69
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
    testRunner.When("Create Menu Cycle page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 72
        testRunner.And("browser is refreshed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
        testRunner.And("Create Menu Cycle page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
    testRunner.Then("Verify Create Menu Cycle page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[MC] Review page is visible after switching Local -> Central user")]
        [NUnit.Framework.CategoryAttribute("TC41875")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Meda", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void MCReviewPageIsVisibleAfterSwitchingLocal_CentralUser(string environment, string withFA, string location, string menuCycle, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC41875"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[MC] Review page is visible after switching Local -> Central user", null, @__tags);
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 84
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 85
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
    testRunner.When("Location name is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
        testRunner.And("daily review page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
    testRunner.Then("Verify review page is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify menu cycle status")]
        [NUnit.Framework.CategoryAttribute("TC42984")]
        [NUnit.Framework.CategoryAttribute("D40840")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Published MC for AUTOMATION", "Published", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void VerifyMenuCycleStatus(string environment, string withFA, string menuCycle, string status, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC42984",
                    "D40840"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify menu cycle status", null, @__tags);
#line 100
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 101
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 102
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
    testRunner.When(string.Format("Menu Cycle \"{0}\" is searched", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 104
        testRunner.Then(string.Format("Verify search results contains menu cycle with name \"{0}\" and status \"{1}\"", menuCycle, status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
