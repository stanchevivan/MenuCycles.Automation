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
    [NUnit.Framework.DescriptionAttribute("Post Production")]
    public partial class PostProductionFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PostProduction.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Post Production", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Expand all / Collapse all Post-production Days")]
        [NUnit.Framework.CategoryAttribute("TC34327")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void ExpandAllCollapseAllPost_ProductionDays(string environment, string withFA, string location, string menuCycle, string week, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC34327"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Expand all / Collapse all Post-production Days", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
        testRunner.And("Expand all is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.Then("Verify all post production meal periods are expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
    testRunner.When("Collapse all is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
    testRunner.Then("Verify all post production meal periods are collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Expand/Collapse single meal period Post-production days")]
        [NUnit.Framework.CategoryAttribute("TC34693")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", "MARGRET", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void ExpandCollapseSingleMealPeriodPost_ProductionDays(string environment, string withFA, string location, string menuCycle, string week, string day, string mealPeriod, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC34693"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Expand/Collapse single meal period Post-production days", null, @__tags);
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 25
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
        testRunner.And(string.Format("Post-production meal period \"{0}\" is collapsed", mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
    testRunner.Then(string.Format("Verify main data for Meal Period \"{0}\" is collapsed in Post production days", mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
    testRunner.When(string.Format("Post-production meal period \"{0}\" is expanded", mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
    testRunner.Then(string.Format("Verify main data for Meal Period \"{0}\" is expanded in Post production days", mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post production daily total calculations")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", "MARGRET", "004Apple Sauce (tinned)", "TariffOne", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void PostProductionDailyTotalCalculations(string environment, string withFA, string location, string menuCycle, string week, string day, string mealPeriod, string recipeName, string tariff, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post production daily total calculations", null, exampleTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 44
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
    testRunner.Then("Verify planned quantity daily total equals the sum of all meal period totals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "qtyReqd",
                        "qtyProd",
                        "qtySold",
                        "noCharge",
                        "returnToStock"});
            table1.AddRow(new string[] {
                        "7",
                        "10",
                        "3",
                        "1",
                        "2"});
#line 53
    testRunner.When(string.Format("values are entered for recipe \"{0}\" tariff \"{1}\" in meal period \"{2}\"", recipeName, tariff, mealPeriod), ((string)(null)), table1, "When ");
#line 56
    testRunner.Then(string.Format("Verify Wastage is correctly calculated for recipe \"{0}\" tariff \"{1}\" in meal peri" +
                        "od \"{2}\"", recipeName, tariff, mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Post production validations")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", "MARGRET", "004Apple Sauce (tinned)", "TariffOne", "Must be integer", "Must be 0 or greater", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void PostProductionValidations(string environment, string withFA, string location, string menuCycle, string week, string day, string mealPeriod, string recipeName, string tariff, string integerMessage, string negativeMessage, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Post production validations", null, exampleTags);
#line 63
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 64
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
    testRunner.Then("Verify planned quantity daily total equals the sum of all meal period totals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "qtyReqd",
                        "qtyProd",
                        "qtySold",
                        "noCharge",
                        "returnToStock"});
            table2.AddRow(new string[] {
                        "a",
                        "b",
                        "c",
                        "d",
                        "e"});
#line 73
    testRunner.When(string.Format("values are entered for recipe \"{0}\" tariff \"{1}\" in meal period \"{2}\"", recipeName, tariff, mealPeriod), ((string)(null)), table2, "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "qtyReqd",
                        "qtyProd",
                        "qtySold",
                        "noCharge",
                        "returnToStock"});
            table3.AddRow(new string[] {
                        string.Format("{0}", integerMessage),
                        string.Format("{0}", integerMessage),
                        string.Format("{0}", integerMessage),
                        string.Format("{0}", integerMessage),
                        string.Format("{0}", integerMessage)});
#line 76
    testRunner.Then(string.Format("Verify context errors are present for recipe \"{0}\" tariff \"{1}\" in meal period \"{" +
                        "2}\"", recipeName, tariff, mealPeriod), ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "qtyReqd",
                        "qtyProd",
                        "qtySold",
                        "noCharge",
                        "returnToStock"});
            table4.AddRow(new string[] {
                        "-1",
                        "-2",
                        "-10",
                        "-3",
                        "-99"});
#line 79
    testRunner.When(string.Format("values are entered for recipe \"{0}\" tariff \"{1}\" in meal period \"{2}\"", recipeName, tariff, mealPeriod), ((string)(null)), table4, "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "qtyReqd",
                        "qtyProd",
                        "qtySold",
                        "noCharge",
                        "returnToStock"});
            table5.AddRow(new string[] {
                        string.Format("{0}", negativeMessage),
                        string.Format("{0}", negativeMessage),
                        string.Format("{0}", negativeMessage),
                        string.Format("{0}", negativeMessage),
                        string.Format("{0}", negativeMessage)});
#line 82
    testRunner.Then(string.Format("Verify context errors are present for recipe \"{0}\" tariff \"{1}\" in meal period \"{" +
                        "2}\"", recipeName, tariff, mealPeriod), ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Open Post-Production Screen, navigate to Weekly view")]
        [NUnit.Framework.CategoryAttribute("TC35467")]
        [NUnit.Framework.CategoryAttribute("D31395")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void OpenPost_ProductionScreenNavigateToWeeklyView(string environment, string withFA, string location, string menuCycle, string week, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC35467",
                    "D31395"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Open Post-Production Screen, navigate to Weekly view", null, @__tags);
#line 93
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 94
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 95
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 101
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
        testRunner.And("switching to Weekly Post-Production view", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
    testRunner.Then("Verify Weekly Post-production view is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Export Local Sales report")]
        [NUnit.Framework.CategoryAttribute("TC36205")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Local User Testing", "WED 31 JUL", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void ExportLocalSalesReport(string environment, string withFA, string location, string menuCycle, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC36205"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Export Local Sales report", null, @__tags);
#line 127
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 128
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 129
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
        testRunner.And("week \"WEEK 2\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
        testRunner.And("local sales report is exported", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
    testRunner.Then("Verify notification message \"Successfully Exported.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Wastage is an input field and QtySold and No charge fields are not present for bu" +
            "ffet recipes")]
        [NUnit.Framework.CategoryAttribute("TC36009")]
        [NUnit.Framework.CategoryAttribute("TC36010")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", "Maya Buffet", "004Basic Sponge", "MARGRET", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void WastageIsAnInputFieldAndQtySoldAndNoChargeFieldsAreNotPresentForBuffetRecipes(string environment, string withFA, string location, string menuCycle, string week, string day, string buffetName, string recipeName, string mealPeriod, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC36009",
                    "TC36010"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Wastage is an input field and QtySold and No charge fields are not present for bu" +
                    "ffet recipes", null, @__tags);
#line 145
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 146
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 147
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
   testRunner.Then(string.Format("Verify Wastage for buffet \"{0}\" recipe \"{1}\" in meal period \"{2}\" is an editable " +
                        "field", buffetName, recipeName, mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 155
       testRunner.And(string.Format("Verify Qty Sold and No Charge fields for buffet \"{0}\" recipe \"{1}\" in meal period" +
                        " \"{2}\" are not present", buffetName, recipeName, mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Wastage field is disabled for recipes")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", "004Apple Sauce (tinned)", "MARGRET", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void WastageFieldIsDisabledForRecipes(string environment, string withFA, string location, string menuCycle, string week, string day, string recipeName, string mealPeriod, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Wastage field is disabled for recipes", null, exampleTags);
#line 162
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 163
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 164
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 169
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 170
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
   testRunner.Then(string.Format("Verify Wastage for recipe \"{0}\" in meal period \"{1}\" is disabled", recipeName, mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Contextual error message is shown for Wastage for buffet recipes when decimal is " +
            "inputed")]
        [NUnit.Framework.CategoryAttribute("TC36011")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "FRI 26 JUL", "Maya Buffet", "004Basic Sponge", "MARGRET", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void ContextualErrorMessageIsShownForWastageForBuffetRecipesWhenDecimalIsInputed(string environment, string withFA, string location, string menuCycle, string day, string buffetName, string recipeName, string mealPeriod, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC36011"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Contextual error message is shown for Wastage for buffet recipes when decimal is " +
                    "inputed", null, @__tags);
#line 179
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 180
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 181
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 184
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 185
        testRunner.And("week \"WEEK 3\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 186
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 187
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 188
        testRunner.And(string.Format("Wastage value \"9.11\" is inputed for buffet \"{0}\" recipe \"{1}\" in meal period \"{2}" +
                        "\"", buffetName, recipeName, mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 189
    testRunner.Then(string.Format("Verify contextual error message \"Must be integer\" is displayed for Wastage field " +
                        "for buffet \"{0}\" recipe \"{1}\" in meal period \"{2}\"", buffetName, recipeName, mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Buffet tariff type is present at menu level")]
        [NUnit.Framework.CategoryAttribute("TC36211")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", "Maya Buffet", "004Basic Sponge", "MARGRET", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void BuffetTariffTypeIsPresentAtMenuLevel(string environment, string withFA, string location, string menuCycle, string week, string day, string buffetName, string recipeName, string mealPeriod, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC36211"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Buffet tariff type is present at menu level", null, @__tags);
#line 197
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 198
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 199
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 202
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 205
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
    testRunner.Then(string.Format("Buffet tariff type is present for buffet \"{0}\" in meal period \"{1}\"", buffetName, mealPeriod), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify Post-Production weekly totals equals the sum of all meal period totals")]
        [NUnit.Framework.CategoryAttribute("TC38808")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "Automation post-prod", "WEEK 3", "FRI 26 JUL", "301", "50", "77", "9", "4", "261", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void VerifyPost_ProductionWeeklyTotalsEqualsTheSumOfAllMealPeriodTotals(string environment, string withFA, string location, string menuCycle, string week, string day, string qtyReqd, string qtyProd, string qtySold, string noCharge, string returnToStock, string wastage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC38808"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify Post-Production weekly totals equals the sum of all meal period totals", null, @__tags);
#line 214
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 215
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 216
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 217
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 218
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 219
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 220
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 221
    testRunner.When(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 222
        testRunner.And("post-production tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 223
        testRunner.And("Weeks tab is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 224
    testRunner.Then("Verify weekly post-production totals equals the sum of all meal period totals", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "qtyReqd",
                        "qtyProd",
                        "qtySold",
                        "noCharge",
                        "returnToStock",
                        "wastage"});
            table6.AddRow(new string[] {
                        string.Format("{0}", qtyReqd),
                        string.Format("{0}", qtyProd),
                        string.Format("{0}", qtySold),
                        string.Format("{0}", noCharge),
                        string.Format("{0}", returnToStock),
                        string.Format("{0}", wastage)});
#line 225
        testRunner.And("Verify post-production weekly totals are", ((string)(null)), table6, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
