﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class Person_EmployeeListFeature : Xunit.IClassFixture<Person_EmployeeListFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Person_Employee List.feature"
#line hidden
        
        public Person_EmployeeListFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Person_Employee List", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void SetFixture(Person_EmployeeListFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC1_Default search query")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Person_EmployeeList_UC1_DefaultSearchQuery()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC1_Default search query", new string[] {
                        "NeedImplementation"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("Actor goes to Employees-List page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table1.AddRow(new string[] {
                        "JOHN HOWARD"});
            table1.AddRow(new string[] {
                        "JOHN DOE"});
#line 8
 testRunner.Then("Following persons are shown", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC2_Custom search query_text type was defined")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Person_EmployeeList_UC2_CustomSearchQuery_TextTypeWasDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC2_Custom search query_text type was defined", new string[] {
                        "NeedImplementation"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table2.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "text:CEO"});
#line 16
 testRunner.Given("Control properties were defined for item", ((string)(null)), table2, "Given ");
#line 19
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("Actor goes to Employees-List page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table3.AddRow(new string[] {
                        "JOHN DOE"});
#line 21
 testRunner.Then("Following persons are shown", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC3_Custom search query_field type was defined")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Person_EmployeeList_UC3_CustomSearchQuery_FieldTypeWasDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC3_Custom search query_field type was defined", new string[] {
                        "NeedImplementation"});
#line 26
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table4.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "template:{467c2144-4454-4518-b1de-e31b4cbbff33}"});
#line 27
 testRunner.Given("Control properties were defined for item", ((string)(null)), table4, "Given ");
#line 30
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table5.AddRow(new string[] {
                        "JOHN HOWARD"});
            table5.AddRow(new string[] {
                        "JOHN DOE"});
            table5.AddRow(new string[] {
                        "$NAME"});
#line 31
 testRunner.Then("Following persons are shown", ((string)(null)), table5, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC4_Custom search query_field and text types were defined")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Person_EmployeeList_UC4_CustomSearchQuery_FieldAndTextTypesWereDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC4_Custom search query_field and text types were defined", new string[] {
                        "NeedImplementation"});
#line 39
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table6.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "text:John;template:{467c2144-4454-4518-b1de-e31b4cbbff33}"});
#line 40
 testRunner.Given("Control properties were defined for item", ((string)(null)), table6, "Given ");
#line 43
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table7.AddRow(new string[] {
                        "JOHN HOWARD"});
            table7.AddRow(new string[] {
                        "JOHN DOE"});
            table7.AddRow(new string[] {
                        "$NAME"});
#line 44
 testRunner.Then("Following persons are shown", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC5_Custom search query_field and text types were defined_In" +
            "clude criteria logic")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Person_EmployeeList_UC5_CustomSearchQuery_FieldAndTextTypesWereDefined_IncludeCriteriaLogic()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC5_Custom search query_field and text types were defined_In" +
                    "clude criteria logic", new string[] {
                        "NeedImplementation"});
#line 52
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table8.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "text:John;+template:{467c2144-4454-4518-b1de-e31b4cbbff33}"});
#line 53
 testRunner.Given("Control properties were defined for item", ((string)(null)), table8, "Given ");
#line 56
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table9.AddRow(new string[] {
                        "JOHN HOWARD"});
            table9.AddRow(new string[] {
                        "JOHN DOE"});
#line 57
 testRunner.Then("Following persons are shown", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC6_Custom search query_Exclude criteria logic")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Person_EmployeeList_UC6_CustomSearchQuery_ExcludeCriteriaLogic()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC6_Custom search query_Exclude criteria logic", new string[] {
                        "NeedImplementation"});
#line 63
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table10.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "text:John;-text:CEO"});
#line 64
 testRunner.Given("Control properties were defined for item", ((string)(null)), table10, "Given ");
#line 67
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table11.AddRow(new string[] {
                        "JOHN HOWARD"});
#line 68
 testRunner.Then("Following persons are shown", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC7_Custom search query_New version of the item is defined")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Person_EmployeeList_UC7_CustomSearchQuery_NewVersionOfTheItemIsDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC7_Custom search query_New version of the item is defined", new string[] {
                        "InDesign"});
#line 74
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table12.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "text:John;template:{467c2144-4454-4518-b1de-e31b4cbbff33}"});
#line 75
 testRunner.Given("Control properties were defined for item", ((string)(null)), table12, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item name"});
            table13.AddRow(new string[] {
                        "John Doe"});
#line 78
 testRunner.And("New item version was added", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table14.AddRow(new string[] {
                        "JOHN HOWARD"});
            table14.AddRow(new string[] {
                        "JOHN DOE"});
#line 81
 testRunner.Then("Following persons are shown", ((string)(null)), table14, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC8_Custom search query_New language of the item is defined")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void Person_EmployeeList_UC8_CustomSearchQuery_NewLanguageOfTheItemIsDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC8_Custom search query_New language of the item is defined", new string[] {
                        "InDesign"});
#line 88
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table15.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "text:John;template:{467c2144-4454-4518-b1de-e31b4cbbff33}"});
#line 89
 testRunner.Given("Control properties were defined for item", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item name"});
            table16.AddRow(new string[] {
                        "John Howard"});
#line 92
 testRunner.And("New item Language version was added", ((string)(null)), table16, "And ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table17.AddRow(new string[] {
                        "JOHN HOWARD"});
            table17.AddRow(new string[] {
                        "JOHN DOE"});
#line 95
 testRunner.Then("Following persons are shown", ((string)(null)), table17, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC9_Default search query with custom Search Result Limit")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Person_EmployeeList_UC9_DefaultSearchQueryWithCustomSearchResultLimit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC9_Default search query with custom Search Result Limit", new string[] {
                        "NeedImplementation"});
#line 102
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table18.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "text:CEO"});
#line 103
 testRunner.Given("Control properties were defined for item", ((string)(null)), table18, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "SearchResultLimit"});
            table19.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "1"});
#line 106
 testRunner.And("Control properties were defined for item", ((string)(null)), table19, "And ");
#line 109
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.When("Actor goes to Employees-List page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table20.AddRow(new string[] {
                        "JOHN DOE"});
#line 111
 testRunner.Then("Following persons are shown", ((string)(null)), table20, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Person_Employee List")]
        [Xunit.TraitAttribute("Description", "Person_Employee List_UC10_Default search query with null Search Result Limit")]
        [Xunit.TraitAttribute("Category", "NeedImplementation")]
        public virtual void Person_EmployeeList_UC10_DefaultSearchQueryWithNullSearchResultLimit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Person_Employee List_UC10_Default search query with null Search Result Limit", new string[] {
                        "NeedImplementation"});
#line 117
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "Data Source"});
            table21.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "text:CEO"});
#line 118
 testRunner.Given("Control properties were defined for item", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control ID",
                        "SearchResultLimit"});
            table22.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/Person/Employees List",
                        "{DC19892A-B345-4EFE-AAA2-6E27A801A733}",
                        "@empty"});
#line 121
 testRunner.And("Control properties were defined for item", ((string)(null)), table22, "And ");
#line 124
 testRunner.And("Habitat website is opened on Main Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.When("Actor goes to Employees-List page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Person"});
            table23.AddRow(new string[] {
                        "JOHN HOWARD"});
            table23.AddRow(new string[] {
                        "JOHN DOE"});
#line 126
 testRunner.Then("Following persons are shown", ((string)(null)), table23, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                Person_EmployeeListFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                Person_EmployeeListFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
