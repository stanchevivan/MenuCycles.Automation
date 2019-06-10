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
    [NUnit.Framework.DescriptionAttribute("Meal Period Details")]
    public partial class MealPeriodDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MealPeriodDetails.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Meal Period Details", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Only one cost is presented for single recipe in the meal period detailed view")]
        [NUnit.Framework.CategoryAttribute("TC30229")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Meda", "LUNCH", "TUESDAY", "724Gourmet Beef Burger 6oz", "£0.36", "724Gourmet Chicken Burger", "£0.36", null, Category="QAI")]
        public virtual void OnlyOneCostIsPresentedForSingleRecipeInTheMealPeriodDetailedView(string environment, string menuCycle, string mealPeriod, string day, string recipe1, string cost1, string recipe2, string cost2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30229"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only one cost is presented for single recipe in the meal period detailed view", @__tags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Type",
                        "Cost"});
            table1.AddRow(new string[] {
                        string.Format("{0}", recipe1),
                        "Recipe",
                        string.Format("{0}", cost1)});
            table1.AddRow(new string[] {
                        string.Format("{0}", recipe2),
                        "Recipe",
                        string.Format("{0}", cost2)});
#line 9
    testRunner.Then("Verify items in the meal period are", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Only one cost is presented for recipes in Buffet in the meal period detailed view" +
            "")]
        [NUnit.Framework.CategoryAttribute("TC30230")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Meda", "DANGELO", "TUESDAY", null, Category="QAI")]
        public virtual void OnlyOneCostIsPresentedForRecipesInBuffetInTheMealPeriodDetailedView(string environment, string menuCycle, string mealPeriod, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30230"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only one cost is presented for recipes in Buffet in the meal period detailed view" +
                    "", @__tags);
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
        testRunner.And("Buffet \"Maya Buffet\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Cost"});
            table2.AddRow(new string[] {
                        "004Basic Sponge",
                        "£0.585"});
            table2.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "£6.3697"});
            table2.AddRow(new string[] {
                        "004Fish Stock (bouillon)",
                        "£0.4875"});
            table2.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "£0"});
#line 26
    testRunner.Then("Verify recipes in meal period details for buffet \"Maya Buffet\" are", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Only single cost is presented for recipes in recipe search")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Meda", "LUNCH", "MONDAY", "724Apple Sauce", "£2.1011", null, Category="QAI")]
        public virtual void OnlySingleCostIsPresentedForRecipesInRecipeSearch(string environment, string menuCycle, string mealPeriod, string day, string recipe, string cost, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only single cost is presented for recipes in recipe search", exampleTags);
#line 41
this.ScenarioSetup(scenarioInfo);
#line 42
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
        testRunner.And(string.Format("Recipe \"{0}\" is searched", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Type",
                        "Cost"});
            table3.AddRow(new string[] {
                        string.Format("{0}", recipe),
                        "Recipe",
                        string.Format("{0}", cost)});
#line 48
    testRunner.Then("Verify items present in the search results are", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Copy and Delete buttons are disabled when new recipe is added")]
        [NUnit.Framework.CategoryAttribute("TC39628")]
        [NUnit.Framework.TestCaseAttribute("QAI", "Meda", "LUNCH", "MONDAY", "724Apple Sauce", null, Category="QAI")]
        public virtual void CopyAndDeleteButtonsAreDisabledWhenNewRecipeIsAdded(string environment, string menuCycle, string mealPeriod, string day, string recipe, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC39628"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Copy and Delete buttons are disabled when new recipe is added", @__tags);
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
    testRunner.Given(string.Format("Menu Cycle app is open on \"{0}\"", environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
        testRunner.And(string.Format("Recipe \"{0}\" is searched", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
        testRunner.And(string.Format("Recipe \"{0}\" is added", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
    testRunner.Then("Verify meal period copy button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
        testRunner.And("Verify meal period delete button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
