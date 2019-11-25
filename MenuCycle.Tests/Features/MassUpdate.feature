Feature: Mass Update
	Mass Update functionalities and validations
    
@TC43103
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
        |Lunch            |RECIPE|004Baked Beans_0|   22.00 |
    
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


@TC43415
Scenario Outline: Tariff types can be added
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Mass Update page is opened
        And recipe "<recipeName>" is searched
        And recipe "<recipeName>" is expanded
        And recipe "<recipeName>" is selected
        And update price is selected
        And proceed button is clicked
    When add types is selected
    Then tariff type "<tariffType>" has been added
        And apply button is clicked
        And Verify notification message "Prices Successfully Updated." is displayed

    @QAI
   Examples:
   |environment|withFA|menuCycle|week  |mealPeriod|day   |recipeName      |tariffType|
   |QAI        |false |Meda     |Week 1|Lunch     |Sunday|004Baked Beans_0|TariffTwo|


@TC43416
Scenario Outline: Notification is shown when all available tariff types have been selected
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Mass Update page is opened
        And recipe "<recipeName>" is searched
        And recipe "<recipeName>" is expanded
        And recipe "<recipeName>" is selected
        And update price is selected
        And proceed button is clicked
    When add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
        And add types is selected
     Then Verify notification message "There are 14 price types available. You cannot add more." is displayed

    @QAI
   Examples:
   |environment|withFA|menuCycle|week  |mealPeriod|day   |recipeName      |
   |QAI        |false |Meda     |Week 1|Lunch     |Sunday|004Baked Beans_0|


@TC43174
Scenario Outline: Notification is shown when trying to update prices with the same price type selected several times
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Mass Update page is opened
        And recipe "<recipeName>" is searched
        And recipe "<recipeName>" is expanded
        And recipe "<recipeName>" is selected
        And update price is selected
        And proceed button is clicked
    When add types is selected
        And tariff type "<tariffType>" is set to "<newTariffType>"
        And apply button is clicked
    Then Verify notification message "Please make sure that you have not selected the same price type several times" is displayed

    @QAI
   Examples:
   |environment|withFA|menuCycle|week  |mealPeriod|day   |recipeName      |tariffType|newTariffType|
   |QAI        |false |Meda     |Week 1|Lunch     |Sunday|004Baked Beans_0|TariffTwo |TariffOne|


@TC43104
Scenario Outline: Fixed price model validations
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


@TC43104
Scenario Outline: GP price model validations
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


@TC43104
Scenario Outline: Markup price model validations
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
        And targetGP% for "<tariffType>" is set to "-1"
        And the user focus out
        And Verify red border and contextual error message "Must be 0 or greater" is displayed for targetGP% field for "<tariffType>" tariff type
        And targetGP% for "<tariffType>" is set to "0"
        And the user focus out
        And Verify red border is not displayed for targetGP% field for "<tariffType>" tariff type
        And targetGP% for "<tariffType>" is set to "334"
        And the user focus out
    Then Verify red border is not displayed for targetGP% field for "<tariffType>" tariff type

    @QAI
   Examples:
   |environment|withFA|menuCycle|recipeName      |tariffType|priceModel|
   |QAI        |false |Meda     |004Baked Beans_0|TariffOne |Markup|