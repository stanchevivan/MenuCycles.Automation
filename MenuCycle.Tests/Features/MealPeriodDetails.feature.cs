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
    [NUnit.Framework.DescriptionAttribute("Meal Period Details")]
    public partial class MealPeriodDetailsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MealPeriodDetails.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Meal Period Details", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Only one cost is presented for single recipe in the meal period detailed view")]
        [NUnit.Framework.CategoryAttribute("TC30229")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "false", "Meda", "LUNCH", "TUESDAY", "724Gourmet Beef Burger 6oz", "£0.375", "724Gourmet Chicken Burger", "£0.375", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void OnlyOneCostIsPresentedForSingleRecipeInTheMealPeriodDetailedView(string environment, string withFA, string menuCycle, string mealPeriod, string day, string recipe1, string cost1, string recipe2, string cost2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30229"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only one cost is presented for single recipe in the meal period detailed view", null, @__tags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Type",
                        "Cost"});
            table24.AddRow(new string[] {
                        string.Format("{0}", recipe1),
                        "Recipe",
                        string.Format("{0}", cost1)});
            table24.AddRow(new string[] {
                        string.Format("{0}", recipe2),
                        "Recipe",
                        string.Format("{0}", cost2)});
#line 9
    testRunner.Then("Verify items in the meal period are", ((string)(null)), table24, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Only one cost is presented for recipes in Buffet in the meal period detailed view" +
            "")]
        [NUnit.Framework.CategoryAttribute("TC30230")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "false", "Meda", "DANGELO", "TUESDAY", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void OnlyOneCostIsPresentedForRecipesInBuffetInTheMealPeriodDetailedView(string environment, string withFA, string menuCycle, string mealPeriod, string day, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC30230"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only one cost is presented for recipes in Buffet in the meal period detailed view" +
                    "", null, @__tags);
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
        testRunner.And("Buffet \"Maya Buffet\" is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Cost"});
            table25.AddRow(new string[] {
                        "004Basic Sponge",
                        "£0.04"});
            table25.AddRow(new string[] {
                        "004Fresh Lemon Curd",
                        "£6.63"});
            table25.AddRow(new string[] {
                        "004Fish Stock (bouillon)",
                        "£0.5"});
            table25.AddRow(new string[] {
                        "004Beef Stock (bouillon)",
                        "£0"});
#line 26
    testRunner.Then("Verify recipes in meal period details for buffet \"Maya Buffet\" are", ((string)(null)), table25, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Only single cost is presented for recipes in recipe search")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "false", "Meda", "LUNCH", "MONDAY", "724Apple Sauce", "£2.1886", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void OnlySingleCostIsPresentedForRecipesInRecipeSearch(string environment, string withFA, string menuCycle, string mealPeriod, string day, string recipe, string cost, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Only single cost is presented for recipes in recipe search", null, exampleTags);
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 39
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
        testRunner.And(string.Format("Recipe \"{0}\" is searched", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Type",
                        "Cost"});
            table26.AddRow(new string[] {
                        string.Format("{0}", recipe),
                        "Recipe",
                        string.Format("{0}", cost)});
#line 45
    testRunner.Then("Verify items present in the search results are", ((string)(null)), table26, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Copy and Delete buttons are disabled when new recipe is added")]
        [NUnit.Framework.CategoryAttribute("TC39628")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "false", "Meda", "LUNCH", "MONDAY", "724Apple Sauce", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CopyAndDeleteButtonsAreDisabledWhenNewRecipeIsAdded(string environment, string withFA, string menuCycle, string mealPeriod, string day, string recipe, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC39628"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Copy and Delete buttons are disabled when new recipe is added", null, @__tags);
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 56
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
        testRunner.And(string.Format("Recipe \"{0}\" is searched", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
        testRunner.And(string.Format("Recipe \"{0}\" is added", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
    testRunner.Then("Verify meal period copy button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
        testRunner.And("Verify meal period delete button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Copy/Delete buttons are enabled when you delete and add the same recipe to its or" +
            "iginal order")]
        [NUnit.Framework.CategoryAttribute("TC39851")]
        [NUnit.Framework.CategoryAttribute("TC39630")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "false", "Meda", "LANCE", "WEDNESDAY", "004Baked Beans_0", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CopyDeleteButtonsAreEnabledWhenYouDeleteAndAddTheSameRecipeToItsOriginalOrder(string environment, string withFA, string menuCycle, string mealPeriod, string day, string recipe, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC39851",
                    "TC39630"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Copy/Delete buttons are enabled when you delete and add the same recipe to its or" +
                    "iginal order", null, @__tags);
#line 72
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 73
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
        testRunner.And(string.Format("Recipe \"{0}\" is deleted", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
        testRunner.And("Verify meal period copy button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
        testRunner.And("Verify meal period delete button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
        testRunner.And(string.Format("Recipe \"{0}\" is searched", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
        testRunner.And(string.Format("Recipe \"{0}\" is added", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
        testRunner.And(string.Format("Recipe \"{0}\" order is set to \"1\"", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
    testRunner.Then("Verify meal period copy button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
        testRunner.And("Verify meal period delete button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
        testRunner.And(string.Format("Verify order for item \"{0}\" is \"1\"", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Copy and Delete buttons are disabled when recipe order is changed")]
        [NUnit.Framework.CategoryAttribute("TC39631")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "false", "Meda", "LANCE", "WEDNESDAY", "004Baked Beans_0", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CopyAndDeleteButtonsAreDisabledWhenRecipeOrderIsChanged(string environment, string withFA, string menuCycle, string mealPeriod, string day, string recipe, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC39631"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Copy and Delete buttons are disabled when recipe order is changed", null, @__tags);
#line 94
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 95
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 96
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
        testRunner.And(string.Format("Recipe \"{0}\" order is set to \"2\"", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
    testRunner.Then("Verify meal period copy button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
        testRunner.And("Verify meal period delete button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
        testRunner.And(string.Format("Verify order for item \"{0}\" is \"2\"", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
        testRunner.And(string.Format("Recipe \"{0}\" order is set to \"1\"", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
        testRunner.And("Verify meal period copy button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
        testRunner.And("Verify meal period delete button is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
        testRunner.And(string.Format("Verify order for item \"{0}\" is \"1\"", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Copy/Delete buttons are disabled when you have unsaved new recipes")]
        [NUnit.Framework.CategoryAttribute("TC39629")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "false", "Meda", "LANCE", "WEDNESDAY", "004Baked Beans_1", "004Baked Beans_2", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CopyDeleteButtonsAreDisabledWhenYouHaveUnsavedNewRecipes(string environment, string withFA, string menuCycle, string mealPeriod, string day, string recipe1, string recipe2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC39629"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Copy/Delete buttons are disabled when you have unsaved new recipes", null, @__tags);
#line 114
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 115
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 116
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
        testRunner.And("Recipe search is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
        testRunner.And(string.Format("Recipe \"{0}\" is searched", recipe1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
        testRunner.And(string.Format("Recipe \"{0}\" is added", recipe1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
            testRunner.And(string.Format("Recipe \"{0}\" is searched", recipe2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
            testRunner.And(string.Format("Recipe \"{0}\" is added", recipe2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
            testRunner.And(string.Format("Recipe \"{0}\" is deleted", recipe2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
    testRunner.Then("Verify meal period copy button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 126
        testRunner.And("Verify meal period delete button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Copy/Delete buttons are disabled when last recipe is deleted")]
        [NUnit.Framework.TestCaseAttribute("QAI_2", "false", "Meda", "LANCE", "WEDNESDAY", "004Beef Stock (bouillon)", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void CopyDeleteButtonsAreDisabledWhenLastRecipeIsDeleted(string environment, string withFA, string menuCycle, string mealPeriod, string day, string recipe, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Copy/Delete buttons are disabled when last recipe is deleted", null, exampleTags);
#line 133
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 134
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 135
        testRunner.And("a nouser user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
    testRunner.When(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 138
        testRunner.And(string.Format("Recipe \"{0}\" is deleted", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
    testRunner.Then("Verify meal period copy button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 140
        testRunner.And("Verify meal period delete button is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Local user open recipe details")]
        [NUnit.Framework.CategoryAttribute("TC40894")]
        [NUnit.Framework.CategoryAttribute("D38047")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Site EUR1", "FOR Local User AUTOMATION", "WED 31 JUL", "WEEK 1", "LUNCH", "004Baked Beans_2", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void LocalUserOpenRecipeDetails(string environment, string withFA, string location, string menuCycle, string day, string week, string mealPeriod, string recipe, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC40894",
                    "D38047"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Local user open recipe details", null, @__tags);
#line 148
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 149
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 150
        testRunner.And("a local user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
        testRunner.And(string.Format("location \"{0}\" is selected", location), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
    testRunner.When(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 153
        testRunner.And("Weekly Calendar is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
        testRunner.And(string.Format("week \"{0}\" is opened", week), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
        testRunner.And(string.Format("Details for meal period \"{0}\" in \"{1}\" are opened", mealPeriod, day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
        testRunner.And(string.Format("detailed view for recipe with name \"{0}\" is opened", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
    testRunner.Then(string.Format("Verify meal period recipe name is \"{0}\"", recipe), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
