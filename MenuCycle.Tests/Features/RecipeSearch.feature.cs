// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("RecipeSearch")]
    [NUnit.Framework.CategoryAttribute("QAI")]
    public partial class RecipeSearchFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RecipeSearch.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RecipeSearch", "    Recipe search functionalities and validations", ProgrammingLanguage.CSharp, new string[] {
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
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line 9
testRunner.And("\'Menu Cycles\' application is open", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Recipe search by keyword in Meal period")]
        [NUnit.Framework.CategoryAttribute("TC27633")]
        [NUnit.Framework.CategoryAttribute("Smoke")]
        public virtual void RecipeSearchByKeywordInMealPeriod()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recipe search by keyword in Meal period", new string[] {
                        "TC27633",
                        "Smoke"});
#line 13
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 14
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
    testRunner.When("Details for meal period \"LUNCH\" in \"MONDAY\" are opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
        testRunner.And("Recipe \"Fried\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Type",
                        "Cost"});
            table1.AddRow(new string[] {
                        "724Fried Onions",
                        "Recipe",
                        "£0"});
            table1.AddRow(new string[] {
                        "724Fried Egg",
                        "Recipe",
                        "£0.45"});
            table1.AddRow(new string[] {
                        "724Stir Fried Vegetables",
                        "Recipe",
                        "£0"});
            table1.AddRow(new string[] {
                        "724Fried Button Mushrooms",
                        "Recipe",
                        "£0.64"});
#line 18
        testRunner.And("Verify items present in the search results are", ((string)(null)), table1, "And ");
#line 24
        testRunner.And("Recipe \"Boiled\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Type",
                        "Cost"});
            table2.AddRow(new string[] {
                        "004Boiled Rice",
                        "Recipe",
                        "£0"});
            table2.AddRow(new string[] {
                        "724Boiled Brown Rice",
                        "Recipe",
                        "£0"});
#line 25
    testRunner.Then("Verify items present in the search results are", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Recipe price should be the same for meal period detailed view and the planning sc" +
            "reen")]
        [NUnit.Framework.CategoryAttribute("TC30803")]
        public virtual void RecipePriceShouldBeTheSameForMealPeriodDetailedViewAndThePlanningScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Recipe price should be the same for meal period detailed view and the planning sc" +
                    "reen", new string[] {
                        "TC30803"});
#line 31
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 32
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
    testRunner.When("Details for meal period \"LUNCH\" in \"MONDAY\" are opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
        testRunner.And("Recipe \"004Baked Beans_3\" is searched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Type",
                        "Cost"});
            table3.AddRow(new string[] {
                        "004Baked Beans_3",
                        "Recipe",
                        "£1.88"});
#line 36
        testRunner.And("Verify items present in the search results are", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Type",
                        "Cost"});
            table4.AddRow(new string[] {
                        "004Baked Beans_3",
                        "Recipe",
                        "£1.88"});
#line 39
        testRunner.And("Verify items in meal period detailed view", ((string)(null)), table4, "And ");
#line 42
        testRunner.And("meal period detailed view is closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
        testRunner.And("planning for Monday is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "CostPerUnit"});
            table5.AddRow(new string[] {
                        "LUNCH",
                        "RECIPE",
                        "004Baked Beans_3",
                        "1.88"});
#line 44
    testRunner.Then("Verify data for items is", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Single cost is present for Recipe and Ingredients in recipe detailed view")]
        [NUnit.Framework.CategoryAttribute("TC30233")]
        public virtual void SingleCostIsPresentForRecipeAndIngredientsInRecipeDetailedView()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Single cost is present for Recipe and Ingredients in recipe detailed view", new string[] {
                        "TC30233"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 5
this.FeatureBackground();
#line 50
    testRunner.Given("Menu Cycle \"Meda\" is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
    testRunner.When("Details for meal period \"LUNCH\" in \"Tuesday\" are opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 52
        testRunner.And("detailed view for recipe with name \"724Gourmet Chicken Burger\" is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
    testRunner.Then("meal period recipe name is \"724Gourmet Chicken Burger\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
        testRunner.And("recipe price is \"£0.41\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "IngredientName",
                        "IngredientCost"});
            table6.AddRow(new string[] {
                        "Chicken Breast Diced",
                        "0.00"});
            table6.AddRow(new string[] {
                        "004Fresh White Breadcrumbs (frz) 10g",
                        "0.00"});
            table6.AddRow(new string[] {
                        "ONION FRESH",
                        "0.00"});
            table6.AddRow(new string[] {
                        "Parsley Curley",
                        "0.00"});
            table6.AddRow(new string[] {
                        "Aryzta - Sausage Roll",
                        "0.00"});
            table6.AddRow(new string[] {
                        "Lea & Perrins - Worcestershire Sauce",
                        "0.00"});
            table6.AddRow(new string[] {
                        "EGGS WHOLE PASTEURISED",
                        "0.00"});
#line 55
        testRunner.And("Verify ingredients in the detailed view", ((string)(null)), table6, "And ");
#line 64
        testRunner.And("Verify ingredients total cost is \"0.00\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
