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
    [NUnit.Framework.DescriptionAttribute("Mass Update")]
    public partial class MassUpdateFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "MassUpdate.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Mass Update", "\tMass Update functionalities and validations", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Changes trough mass update screen reflect on planning screen")]
        [NUnit.Framework.CategoryAttribute("TC43103")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "Week 1", "Lunch", "Sunday", "004Baked Beans_0", "TariffOne", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void ChangesTroughMassUpdateScreenReflectOnPlanningScreen(string environment, string withFA, string menuCycle, string week, string mealPeriod, string day, string recipeName, string tariffType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC43103"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Changes trough mass update screen reflect on planning screen", null, @__tags);
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
    testRunner.When("Mass Update page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
        testRunner.And(string.Format("recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
        testRunner.And(string.Format("recipe \"{0}\" is expanded", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
        testRunner.And(string.Format("checkbox for row \"{0}\", \"{1}\", \"{2}\" in  recipe \"{3}\" is selected", week, day, mealPeriod, recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
        testRunner.And("update price is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
        testRunner.And("proceed button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
        testRunner.And(string.Format("sell price for \"{0}\" is set to \"22\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
        testRunner.And("apply button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
        testRunner.And("Verify notification message \"Prices Successfully Updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
        testRunner.And("Calendar tab is clicked and calendar view has loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
        testRunner.And("daily calendar view is switched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
        testRunner.And(string.Format("planning for \"{0}\" is opened", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "MealPeriodName",
                        "TYPE",
                        "RecipeTitle",
                        "SellPrice"});
            table23.AddRow(new string[] {
                        "Lunch",
                        "RECIPE",
                        "004Baked Beans_0",
                        "22.00"});
#line 21
       testRunner.Then("Verify data for items is", ((string)(null)), table23, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validate message no results")]
        [NUnit.Framework.CategoryAttribute("TC43047")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "Marto", "We couldn\'t find any results for \"Marto\"", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void ValidateMessageNoResults(string environment, string withFA, string menuCycle, string recipeName, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC43047"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Validate message no results", null, @__tags);
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
       testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
       testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
    testRunner.When("Mass Update page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
       testRunner.And(string.Format("recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
    testRunner.Then(string.Format("The result message is \"{0}\"", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Tariff types can be added")]
        [NUnit.Framework.CategoryAttribute("TC43415")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "Week 1", "Lunch", "Sunday", "004Baked Beans_0", "TariffTwo", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void TariffTypesCanBeAdded(string environment, string withFA, string menuCycle, string week, string mealPeriod, string day, string recipeName, string tariffType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC43415"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Tariff types can be added", null, @__tags);
#line 47
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 48
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
        testRunner.And("Mass Update page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
        testRunner.And(string.Format("recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
        testRunner.And(string.Format("recipe \"{0}\" is expanded", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
        testRunner.And(string.Format("recipe \"{0}\" is selected", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
        testRunner.And("update price is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
        testRunner.And("proceed button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
    testRunner.When("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
    testRunner.Then(string.Format("tariff type \"{0}\" has been added", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
        testRunner.And("apply button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
        testRunner.And("Verify notification message \"Prices Successfully Updated.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Notification is shown when all available tariff types have been selected")]
        [NUnit.Framework.CategoryAttribute("TC43416")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "Week 1", "Lunch", "Sunday", "004Baked Beans_0", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void NotificationIsShownWhenAllAvailableTariffTypesHaveBeenSelected(string environment, string withFA, string menuCycle, string week, string mealPeriod, string day, string recipeName, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC43416"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Notification is shown when all available tariff types have been selected", null, @__tags);
#line 69
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 70
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
        testRunner.And("Mass Update page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
        testRunner.And(string.Format("recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
        testRunner.And(string.Format("recipe \"{0}\" is expanded", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
        testRunner.And(string.Format("recipe \"{0}\" is selected", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
        testRunner.And("update price is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
        testRunner.And("proceed button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
    testRunner.When("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
        testRunner.And("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
     testRunner.Then("Verify notification message \"There are 14 price types available. You cannot add m" +
                    "ore.\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Notification is shown when trying to update prices with the same price type selec" +
            "ted several times")]
        [NUnit.Framework.CategoryAttribute("TC43174")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "Week 1", "Lunch", "Sunday", "004Baked Beans_0", "TariffTwo", "TariffOne", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void NotificationIsShownWhenTryingToUpdatePricesWithTheSamePriceTypeSelectedSeveralTimes(string environment, string withFA, string menuCycle, string week, string mealPeriod, string day, string recipeName, string tariffType, string newTariffType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC43174"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Notification is shown when trying to update prices with the same price type selec" +
                    "ted several times", null, @__tags);
#line 102
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 103
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 104
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
        testRunner.And("Mass Update page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
        testRunner.And(string.Format("recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
        testRunner.And(string.Format("recipe \"{0}\" is expanded", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
        testRunner.And(string.Format("recipe \"{0}\" is selected", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
        testRunner.And("update price is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
        testRunner.And("proceed button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
    testRunner.When("add types is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 113
        testRunner.And(string.Format("tariff type \"{0}\" is set to \"{1}\"", tariffType, newTariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
        testRunner.And("apply button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
    testRunner.Then("Verify notification message \"Please make sure that you have not selected the same" +
                    " price type several times\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Fixed price model validations")]
        [NUnit.Framework.CategoryAttribute("TC43104")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "004Baked Beans_0", "TariffOne", "Fixed", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void FixedPriceModelValidations(string environment, string withFA, string menuCycle, string recipeName, string tariffType, string priceModel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC43104"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Fixed price model validations", null, @__tags);
#line 124
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 125
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 126
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
        testRunner.And("Mass Update page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
        testRunner.And(string.Format("recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
        testRunner.And(string.Format("recipe \"{0}\" is expanded", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
        testRunner.And(string.Format("recipe \"{0}\" is selected", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
        testRunner.And("update price is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
        testRunner.And("proceed button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
    testRunner.When(string.Format("Price model for tariff type \"{0}\" is set to \"{1}\"", tariffType, priceModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 135
        testRunner.And(string.Format("sell price for \"{0}\" is set to \"\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 137
        testRunner.And(string.Format("Verify red border and contextual error message \"Value is required\" is displayed f" +
                        "or Sell Price field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
        testRunner.And(string.Format("sell price for \"{0}\" is set to \"7a7\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
        testRunner.And(string.Format("Verify red border and contextual error message \"Must be number\" is displayed for " +
                        "Sell Price field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
        testRunner.And(string.Format("sell price for \"{0}\" is set to \"-1\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
        testRunner.And(string.Format("Verify red border and contextual error message \"Must be 0 or greater\" is displaye" +
                        "d for Sell Price field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
        testRunner.And(string.Format("sell price for \"{0}\" is set to \"0\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 145
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 146
        testRunner.And(string.Format("Verify red border is not displayed for Sell Price field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
        testRunner.And(string.Format("sell price for \"{0}\" is set to \"4534\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
    testRunner.Then(string.Format("Verify red border is not displayed for Sell Price field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("GP price model validations")]
        [NUnit.Framework.CategoryAttribute("TC43104")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "004Baked Beans_0", "TariffOne", "GP", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void GPPriceModelValidations(string environment, string withFA, string menuCycle, string recipeName, string tariffType, string priceModel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC43104"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("GP price model validations", null, @__tags);
#line 158
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 159
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 160
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 162
        testRunner.And("Mass Update page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 163
        testRunner.And(string.Format("recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 164
        testRunner.And(string.Format("recipe \"{0}\" is expanded", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 165
        testRunner.And(string.Format("recipe \"{0}\" is selected", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 166
        testRunner.And("update price is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 167
        testRunner.And("proceed button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 168
    testRunner.When(string.Format("Price model for tariff type \"{0}\" is set to \"{1}\"", tariffType, priceModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 169
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 170
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 171
        testRunner.And(string.Format("Verify red border and contextual error message \"Value is required\" is displayed f" +
                        "or targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"7a7\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
        testRunner.And(string.Format("Verify red border and contextual error message \"Must be number\" is displayed for " +
                        "targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"100\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
        testRunner.And(string.Format("Verify red border and contextual error message \"Must be -99.99 to 99.99\" is displ" +
                        "ayed for targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"99.99\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
        testRunner.And(string.Format("Verify red border is not displayed for targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"-99.99\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
    testRunner.Then(string.Format("Verify red border is not displayed for targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Markup price model validations")]
        [NUnit.Framework.CategoryAttribute("TC43104")]
        [NUnit.Framework.TestCaseAttribute("QAI", "false", "Meda", "004Baked Beans_0", "TariffOne", "Markup", new string[] {
                "QAI"}, Category="QAI")]
        public virtual void MarkupPriceModelValidations(string environment, string withFA, string menuCycle, string recipeName, string tariffType, string priceModel, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TC43104"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Markup price model validations", null, @__tags);
#line 192
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 193
    testRunner.Given(string.Format("Menu Cycles app is open on \"{0}\" with FourthApp \"{1}\"", environment, withFA), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 194
        testRunner.And("a central user is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
        testRunner.And(string.Format("Menu Cycle \"{0}\" is selected", menuCycle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
        testRunner.And("Mass Update page is opened", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
        testRunner.And(string.Format("recipe \"{0}\" is searched", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
        testRunner.And(string.Format("recipe \"{0}\" is expanded", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
        testRunner.And(string.Format("recipe \"{0}\" is selected", recipeName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
        testRunner.And("update price is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
        testRunner.And("proceed button is clicked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 202
    testRunner.When(string.Format("Price model for tariff type \"{0}\" is set to \"{1}\"", tariffType, priceModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 203
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 205
        testRunner.And(string.Format("Verify red border and contextual error message \"Value is required\" is displayed f" +
                        "or targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 206
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"7a7\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 207
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 208
        testRunner.And(string.Format("Verify red border and contextual error message \"Must be number\" is displayed for " +
                        "targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 209
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"-1\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 210
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 211
        testRunner.And(string.Format("Verify red border and contextual error message \"Must be 0 or greater\" is displaye" +
                        "d for targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 212
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"0\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 213
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 214
        testRunner.And(string.Format("Verify red border is not displayed for targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 215
        testRunner.And(string.Format("targetGP% for \"{0}\" is set to \"334\"", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 216
        testRunner.And("the user focus out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 217
    testRunner.Then(string.Format("Verify red border is not displayed for targetGP% field for \"{0}\" tariff type", tariffType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
