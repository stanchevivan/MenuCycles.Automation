@QAI
Feature: Reports
    Reports feature

@TC32573 @D28281 @Reports
Scenario Outline: Open report page for menu cycle without items
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
	    And Menu Cycle "MC without items" is selected
	When Reports page is opened
    Then Reports page is correctly loaded
@QAI
Examples:
|environment|withFA|
|QAI        |false |
 
@Reports   
Scenario Outline: Consumer Facing Report - Price options are not disabled for Local user
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
    Then Verify Include sell price is not checked
        And Verify Price type dropdown is disabled
@QAI
Examples:
|environment|withFA|
|QAI        |false |

@TC33979 @TC34204 @Reports
Scenario Outline: Export Consumer Facing Report as PDF with Sell Price, Kilojoules and Calories
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
        And Export CSV and Export PDF buttons are not displayed
        And Report start date "28/09/2019" is selected
        And Export CSV and Export PDF buttons are not displayed
        And Report end date "31/01/2020" is selected
        And Export CSV and Export PDF buttons are displayed
        And Include sell price is checked
        And Calories checkbox is checked
        And Kilojoules checkbox is checked
        And Export PDF button is clicked
    Then Verify notification message "Successfully Exported." is displayed 
        And report "ConsumerFacing" with name "ConsumerReportPdfAllParams.pdf" type "pdf" is compared with the expected one
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |
    
@TC34203 @Reports
Scenario Outline: Export Consumer Facing Report as CSV with Sell Price, Kilojoules and Calories
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
        And Export CSV and Export PDF buttons are not displayed
        And Report start date "28/09/2019" is selected
        And Export CSV and Export PDF buttons are not displayed
        And Report end date "31/01/2020" is selected
        And Export CSV and Export PDF buttons are displayed
        And Include sell price is checked
        And Calories checkbox is checked
        And Kilojoules checkbox is checked
        And Export CSV button is clicked
    Then Verify notification message "Successfully Exported." is displayed 
        And report "ConsumerFacing" with name "ConsumerReportCsvAllParams.csv" type "csv" is compared with the expected one
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |

@TC33983 @Reports
Scenario Outline: Consumer Facing Report - Local > User is able to export Consumer Facing report as PDF without selecting Calories, kilojoules and Sell Price
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
        And Export CSV and Export PDF buttons are not displayed
        And Report start date "31/07/2019" is selected
        And Export CSV and Export PDF buttons are not displayed
        And Report end date "30/09/2019" is selected
        And Export CSV and Export PDF buttons are displayed
        And Export PDF button is clicked
    Then Verify notification message "Successfully Exported." is displayed
            And report "ConsumerFacing" with name "ConsumerReportNoParams.pdf" type "pdf" is compared with the expected one

    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |

@TC34205 @Reports
Scenario Outline: Consumer Facing Report - Local > User is able to export Consumer Facing report as CSV without selecting Calories, kilojoules and Sell Price
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
        And Export CSV and Export PDF buttons are not displayed
        And Report start date "31/07/2019" is selected
        And Export CSV and Export PDF buttons are not displayed
        And Report end date "30/09/2019" is selected
        And Export CSV and Export PDF buttons are displayed
        And Export CSV button is clicked
    Then Verify notification message "Successfully Exported." is displayed
        And report "ConsumerFacing" with name "ConsumerReportNoParams.csv" type "csv" is compared with the expected one
   
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |
    
        
    
@TC33988 @Reports
Scenario Outline: Recipe Card Report - Central > Export button is displayed after meal period is specified
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Reports page is opened
        And Report "RecipeCard" is opened
        And Export button is not displayed
        And Meal periods are selected
        |MealPeriod         |
        |Lunch              |
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
    And report "RecipeCard" with name "RecipeCardReportCentral.pdf" type "pdf" is compared with the expected one
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |
        

    @TC43574 @Reports
    Scenario Outline: Recipe Card Report - Local > Export Successfully
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
        And Report "RecipeCard" is opened
        And Report start date "31/07/2019" is selected
        And Report end date "30/08/2019" is selected
        And Meal periods are selected
        |MealPeriod         |
        |Lunch              |
        |Brunch             |
        And recipe "<recipe>" is searched
        And Checkbox for Select All is selected
        And Done button is selected
        And Report is exported
    Then Verify notification message "Successfully Exported." is displayed
        And report "RecipeCard" with name "RecipeCardReportLocal.pdf" type "pdf" is compared with the expected one
    
    @QAI
    Examples:
    |environment|withFA|recipe|
    |QAI        |false |apple |
    
@TC33985 @Reports
Scenario Outline: Menu Extract Report - Central > Export button is displayed and clicked after meal period is specified
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Reports page is opened
        And Report "MenuExtract" is opened
        And Export button is not displayed
        And Meal periods are selected
        |MealPeriod|
        |Lunch     |
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
        And report "MenuExtract" with name "MenuExtractReport.csv" type "csv" is compared with the expected one
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43059 @Reports
Scenario Outline: Menu Cycle Calendar - Central - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Reports page is opened
        And Report "MenuCycleCalendar" is opened
        And Export button is not displayed
        And Meal periods are selected
        |MealPeriod|
        |Dangelo   |
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
        And report "MenuCycleCalendar" with name "CentralMenuCycleCalendar.csv" type "csv" is compared with the expected one
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43061 @Reports
Scenario Outline: Menu Cycle Calendar - Local - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
        And Report "MenuCycleCalendar" is opened
        And Export button is not displayed
        And Meal periods are selected
        |MealPeriod|
        |Brunch   |
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
        And report "MenuCycleCalendar" with name "LocalMenuCycleCalendar.csv" type "csv" is compared with the expected one
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43060 @Reports
Scenario Outline: Location Gap Check - Central - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Reports page is opened
        And Report "LocationGapCheck" is opened
        And Export button is not displayed
        And Locations are selected
        |MealPeriod|
        |Site EUR1 |
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
        And report "LocationGapCheck" with name "LocationGapCheckReport.csv" type "csv" is compared with the expected one
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43058 @Reports
Scenario Outline: Traffic Light Report - Central - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Reports page is opened
        And Report "TrafficLight" is opened
    Then Verify Export button is displayed
       And Report is exported
       And Verify notification message "Successfully Exported." is displayed
       And report "TrafficLight" with name "TrafficLightReportCentral.pdf" type "pdf" is compared with the expected one
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43057 @Reports
Scenario Outline: Traffic Light Report - Local - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
        And Report "TrafficLight" is opened
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
        And report "TrafficLight" with name "TrafficLightReportLocal.pdf" type "pdf" is compared with the expected one
        
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43056 @Reports
Scenario Outline: Buying Report - Local - Export Successfully 
   Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       And a local user is selected
       And location "Site EUR1" is selected
       And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
       And Report "BuyingReport" is opened
    Then Report is exported
       And Verify notification message "Successfully Exported." is displayed
       And report "BuyingReport" with name "BuyingReport.csv" type "csv" is compared with the expected one
        
        
       @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

    @TC43575 @Reports
    Scenario Outline: Destinations to publish - Location Gap Check - Export Successfully
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When daily review page is opened
        And Select & Verify Destinations button is clicked
        And All destinations are selected
        And Run button is clicked
        Then Verify notification message "Successfully Exported" is displayed
        And Verify Gap Check report are displayed
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|
    |QAI        |false |Meda     |

@TC44242 @Reports
Scenario Outline: Allergen Report - Local - Export Successfully 
   Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       And a local user is selected
       And location "Site EUR1" is selected
       And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
       And Report "AllergenReport" is opened
       And Report start date "16/12/2019" is selected
       And Report end date "20/12/2019" is selected
       And Meal periods are selected
        |MealPeriod         |
        |Lunch              |
        |Brunch             |
    Then Report is exported
       And Verify notification message "Successfully Exported." is displayed
       And report "AllergenReport" with name "AllergenAndIntoleranceReport.pdf" type "pdf" is compared with the expected one
        
       @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |
        
@Reports
Scenario Outline: Local Production Requirements - Export Successfully 
   Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       And a local user is selected
       And location "Site EUR1" is selected
       And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
       And Report "LocalProductionRequirements" is opened
       And Report start date "01/10/2019" is selected
       And Report end date "31/01/2020" is selected
       And Meal periods are selected
        |MealPeriod         |
        |Lunch              |
        |Brunch             |
    Then Report is exported
       And Verify notification message "Successfully Exported." is displayed
       And report "LocalProductionRequirements" with name "LocalProductionRequirementsReport.csv" type "csv" is compared with the expected one
        
       @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@Reports
Scenario Outline: Local Sales History - Export Successfully 
   Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       And a local user is selected
       And location "Site EUR1" is selected
       And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
       And Report "LocalSalesHistory" is opened
       And Report start date "01/10/2019" is selected
       And Report end date "31/01/2020" is selected
       And Meal periods are selected
        |MealPeriod         |
        |Lunch              |
        |Brunch             |
    Then Report is exported
       And Verify notification message "Successfully Exported." is displayed
       And report "LocalSalesHistory" with name "LocalSalesHistoryReport.csv" type "csv" is compared with the expected one
        
       @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |


@Reports
Scenario Outline: Performance Report - Local - Export Successfully 
   Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       And a local user is selected
       And location "Site EUR1" is selected
       And Menu Cycle "FOR Local User AUTOMATION" is selected
    When Reports page is opened
       And Report "PerformanceReport" is opened
       And Report start date "01/10/2019" is selected
       And Report end date "31/01/2020" is selected
       And Meal periods are selected
        |MealPeriod         |
        |Lunch              |
        |Brunch             |
    Then Report is exported
       And Verify notification message "Successfully Exported." is displayed
      # this will not work due to today date on every row of the report
      # And report "PerformanceReport" with name "PerformanceReport.csv" type "csv" is compared with the expected one
        
       @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |
