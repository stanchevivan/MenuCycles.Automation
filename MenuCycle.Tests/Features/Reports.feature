@QAI
Feature: Reports
    Reports feature

@TC32573 @D28281
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
    
Scenario Outline: Consumer Facing Report - Price options are not disabled for Local user
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "Local User Testing" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
    Then Verify Include sell price is not checked
        And Verify Price type dropdown is disabled
@QAI
Examples:
|environment|withFA|
|QAI        |false |

@TC33979 @TC34204
Scenario Outline: Export Consumer Facing Report as PDF with Sell Price, Kilojoules and Calories
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "AUTOMATIOn - ConsumerFacingReport" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
        And Export CSV and Export PDF buttons are not displayed
        And Report start date "15/10/2019" is selected
        And Export CSV and Export PDF buttons are not displayed
        And Report end date "16/10/2019" is selected
        And Export CSV and Export PDF buttons are displayed
        And Include sell price is checked
        And Calories checkbox is checked
        And Kilojoules checkbox is checked
        And Export PDF button is clicked
    Then Verify notification message "Successfully Exported." is displayed
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |
    
@TC34203
Scenario Outline: Export Consumer Facing Report as CSV with Sell Price, Kilojoules and Calories
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "AUTOMATIOn - ConsumerFacingReport" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
        And Export CSV and Export PDF buttons are not displayed
        And Report start date "15/10/2019" is selected
        And Export CSV and Export PDF buttons are not displayed
        And Report end date "16/10/2019" is selected
        And Export CSV and Export PDF buttons are displayed
        And Include sell price is checked
        And Calories checkbox is checked
        And Kilojoules checkbox is checked
        And Export CSV button is clicked
    Then Verify notification message "Successfully Exported." is displayed
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |

@TC33983
Scenario Outline: Consumer Facing Report - Local > User is able to export Consumer Facing report as PDF without selecting Calories, kilojoules and Sell Price
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "Local User Testing" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
        And Export CSV and Export PDF buttons are not displayed
        And Report start date "29/07/2019" is selected
        And Export CSV and Export PDF buttons are not displayed
        And Report end date "31/07/2019" is selected
        And Export CSV and Export PDF buttons are displayed
        And Export PDF button is clicked
    Then Verify notification message "Successfully Exported." is displayed
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |

@TC34205
Scenario Outline: Consumer Facing Report - Local > User is able to export Consumer Facing report as CSV without selecting Calories, kilojoules and Sell Price
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "Local User Testing" is selected
    When Reports page is opened
        And Report "ConsumerFacing" is opened
        And Export CSV and Export PDF buttons are not displayed
        And Report start date "29/07/2019" is selected
        And Export CSV and Export PDF buttons are not displayed
        And Report end date "31/07/2019" is selected
        And Export CSV and Export PDF buttons are displayed
        And Export CSV button is clicked
    Then Verify notification message "Successfully Exported." is displayed
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |
    
        
    
@TC33988
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
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |
        

    @TC43574
    Scenario Outline: Recipe Card Report - Local > Export Successfully
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "Local User Testing" is selected
    When Reports page is opened
        And Report "RecipeCard" is opened
        And Report start date "31/07/2019" is selected
        And Report end date "30/08/2019" is selected
        And Meal periods are selected
        |MealPeriod         |
        |Lunch              |
        |Dinner             |
        And recipe "<recipe>" is searched
        And Checkbox for Select All is selected
        And Done button is selected
        And Report is exported
    Then Verify notification message "Successfully Exported." is displayed
    
    @QAI
    Examples:
    |environment|withFA|recipe|
    |QAI        |false |apple |
    
@TC33985
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
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43059
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
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43061
Scenario Outline: Menu Cycle Calendar - Local - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "Local User Testing" is selected
    When Reports page is opened
        And Report "MenuCycleCalendar" is opened
        And Export button is not displayed
        And Meal periods are selected
        |MealPeriod|
        |Dinner   |
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43060
Scenario Outline: Location Gap Check - Central - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Reports page is opened
        And Report "LocatioGapCheck" is opened
        And Export button is not displayed
        And Locations are selected
        |MealPeriod|
        |Site EUR1 |
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43058
Scenario Outline: Traffic Light Report - Central - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Reports page is opened
        And Report "TrafficLight" is opened
    Then Verify Export button is displayed
       And Report is exported
       And Verify notification message "Successfully Exported." is displayed
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43057
Scenario Outline: Traffic Light Report - Local - Export Successfully 
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "Site EUR1" is selected
        And Menu Cycle "Consumer Facing Report Export AUTOMATION" is selected
    When Reports page is opened
        And Report "TrafficLight" is opened
    Then Verify Export button is displayed
        And Report is exported
        And Verify notification message "Successfully Exported." is displayed
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC43056
Scenario Outline: Buying Report - Local - Export Successfully 
   Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       And a local user is selected
       And location "Site EUR1" is selected
       And Menu Cycle "Local User Testing" is selected
    When Reports page is opened
       And Report "BuyingReport" is opened
    Then Report is exported
       And Verify notification message "Successfully Exported." is displayed
        
       @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

    @TC43575
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