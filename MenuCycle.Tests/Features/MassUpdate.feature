Feature: Mass Update
	Mass Update functionalities and validations
    
    #still waiting for functionality implementation

Scenario Outline: Changes trough mass update screen reflect on planning screen
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When Mass Update page is opened
        And recipe "<recipeName>" is searched
        And recipe "<recipeName>" is expanded
        And checkbox for row "<week>", "<day>", "<mealPeriod>" in  recipe "<recipeName>" is selected
        And update price is selected
        And proceed button is clicked
        And sell price for "<tariffType>" is set to "22"
        And apply button is clicked
        And Verify notification message "Prices Successfully Updated." is displayed
        And Calendar tab is clicked and calendar view has loaded
        And daily calendar view is switched
        And planning for "<day>" is opened
       Then Verify data for items is
        |MealPeriodName   |TYPE  |RecipeTitle     |SellPrice|
        |Lunch            |RECIPE|004Baked Beans_0|      22.00 |
    
    @QAI
   Examples:
   |environment|withFA|menuCycle|week  |mealPeriod|day   |recipeName      |tariffType|
   |QAI        |false |Meda     |Week 1|Lunch     |Sunday|004Baked Beans_0|TariffOne|
    

    @TC43047
    Scenario Outline: Validate message no results
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       And a central user is selected
       And Menu Cycle "<menuCycle>" is selected
    When Mass Update page is opened
       And recipe "<recipeName>" is searched
    Then The result message is "<message>"

    @QAI
    Examples:
   |environment|withFA|menuCycle|recipeName|message                                 |
   |QAI        |false |Meda     |Marto     |We couldn't find any results for "Marto"|

   
   Scenario Outline: Sell price field validations
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Mass Update page is opened
        And recipe "<recipeName>" is searched
        And recipe "<recipeName>" is expanded
        And recipe "<recipeName>" is selected
        And update price is selected
        And proceed button is clicked
    When Price model for tariff type "<tariffType>" is set to "<priceModel>"
        And sell price for "<tariffType>" is set to ""
        And the user focus out
        And Verify red border and contextual error message "Value is required" is displayed for Sell Price field for "<tariffType>" tariff type
        And sell price for "<tariffType>" is set to "7a7"
        And the user focus out
        And Verify red border and contextual error message "Must be number" is displayed for Sell Price field for "<tariffType>" tariff type
        And sell price for "<tariffType>" is set to "-1"
        And the user focus out
        And Verify red border and contextual error message "Must be 0 or greater" is displayed for Sell Price field for "<tariffType>" tariff type
        And sell price for "<tariffType>" is set to "0"
        And the user focus out
        And Verify red border is not displayed for Sell Price field for "<tariffType>" tariff type
        And sell price for "<tariffType>" is set to "4534"
        And the user focus out
    Then Verify red border is not displayed for Sell Price field for "<tariffType>" tariff type

    @QAI
   Examples:
   |environment|withFA|menuCycle|recipeName      |tariffType|priceModel|
   |QAI        |false |Meda     |004Baked Beans_0|TariffOne |Fixed|

   Scenario Outline: Target GP% field validations
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Mass Update page is opened
        And recipe "<recipeName>" is searched
        And recipe "<recipeName>" is expanded
        And recipe "<recipeName>" is selected
        And update price is selected
        And proceed button is clicked
    When Price model for tariff type "<tariffType>" is set to "<priceModel>"
        And targetGP% for "<tariffType>" is set to ""
        And the user focus out
        And Verify red border and contextual error message "Value is required" is displayed for targetGP% field for "<tariffType>" tariff type
        And targetGP% for "<tariffType>" is set to "7a7"
        And the user focus out
        And Verify red border and contextual error message "Must be number" is displayed for targetGP% field for "<tariffType>" tariff type
        And targetGP% for "<tariffType>" is set to "100"
        And the user focus out
        And Verify red border and contextual error message "Must be -99.99 to 99.99" is displayed for targetGP% field for "<tariffType>" tariff type
        And targetGP% for "<tariffType>" is set to "99.99"
        And the user focus out
        And Verify red border is not displayed for targetGP% field for "<tariffType>" tariff type
        And targetGP% for "<tariffType>" is set to "-99.99"
        And the user focus out
    Then Verify red border is not displayed for targetGP% field for "<tariffType>" tariff type

    @QAI
   Examples:
   |environment|withFA|menuCycle|recipeName      |tariffType|priceModel|
   |QAI        |false |Meda     |004Baked Beans_0|TariffOne |GP|