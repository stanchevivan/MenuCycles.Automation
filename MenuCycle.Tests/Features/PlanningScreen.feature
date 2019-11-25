Feature: PlanningScreen
    Meal Peridos functionalities and validations
    
    
@TC29023
Scenario Outline: Save button is clicked without any changes applied
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Save button is clicked
    Then Verify the user stays on the planning page
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI        |false |Meda     |MONDAY| 

@TC29022
Scenario Outline: Save all updated figures (fields)
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Number of covers for meal period "<mealPeriod>" is set to random number
        And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle |SellPrice|
        |<mealPeriod>  |RECIPE|<recipeName>|     0#99|
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2"
        And Save button is clicked
    Then Verify notification message "Planning figures updated." is displayed
        And Verify quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is equal to the previous inputted number
    And Verify the user stays on the planning page
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|
    
@TC29024
Scenario Outline: Saved data is retrieved from the API
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        #And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
    When data for recipes is set
        |mealPeriodName|recipeTitle |PlannedQuantity|
        |<mealPeriod>  |<recipeName>|1#99   |
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2"
        And Save button is clicked
        And Verify notification message "Planning figures updated." is displayed
        And Cancel button is clicked
        And Wait for Calendar view
        And planning for "<day>" is opened
    Then Verify data for items is
        |mealPeriodName|type  |recipeTitle |PlannedQty  |
        |<mealPeriod>  |RECIPE|<recipeName>|<plannedQty>|
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |plannedQty|
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|      1#99|
    
    
@TC29019
Scenario Outline: Successfully Update and Save number of covers
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When Number of covers for meal period "<mealPeriod>" is set to random number
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2"
        And Save button is clicked
        And Verify notification message "Planning figures updated." is displayed
        And Calendar tab is clicked and calendar view has loaded
        And planning for "<day>" is opened
    Then Verify number of covers for meal period "<mealPeriod>" is equal to the previous inputted number
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|
    
@TC29080 @D23144 @D24051 @D24410
Scenario Outline: Open Monday planning screen, then go to Tuesday, back to Monday update total quantity and click Save
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "Monday" is opened
        And Cancel button is clicked
        And planning for "Tuesday" is opened
        And Meal Period "<mealPeriod>" is expanded
        And Verify items for meal period "<mealPeriod>" are (check count "yes")
            |MealPeriodName|TYPE  |RecipeTitle|
            |<mealPeriod>  |RECIPE|<item1>    |
            |<mealPeriod>  |RECIPE|<item2>    |
        And Cancel button is clicked
    When planning for "Monday" is opened
        And meal periods for the day are "<mealPeriod>"
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2"
        And Save button is clicked
    Then Verify notification message "Planning figures updated." is displayed
        And Verify quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is equal to the previous inputted number
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |item1                     |item2                    |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|724Gourmet Beef Burger 6oz|724Gourmet Chicken Burger|
        
@TC29521
Scenario Outline: Modal dialog for unsaved changes is shown on cancel
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And values for recipe "<recipeName>" in meal period "<mealPeriod>" are stored
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Cancel button is clicked
        And Modal dialog Yes is selected
        And Wait for Calendar view
    When planning for "<day>" is opened
    Then Verify values for recipe "<recipeName>" in meal period "<mealPeriod>" are equal to the stored ones
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|
    
@TC29521
Scenario Outline: Modal dialog for unsaved changes is shown on pressing calendar button
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And values for recipe "<recipeName>" in meal period "<mealPeriod>" are stored
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Calendar tab is clicked
        And Modal dialog Yes is selected
        And Wait for Calendar view
    When planning for "<day>" is opened
    Then Verify values for recipe "<recipeName>" in meal period "<mealPeriod>" are equal to the stored ones
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|
    
@TC29526
Scenario Outline: Modal dialog for unsaved changes is shown when going to nutrition
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And values for recipe "<recipeName>" in meal period "<mealPeriod>" are stored
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And daily nutrition tab is clicked
        And Modal dialog Yes is selected
    When planning tab is opened
    Then Verify values for recipe "<recipeName>" in meal period "<mealPeriod>" are equal to the stored ones
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|
    
@TC29521
Scenario Outline: Modal dialog for unsaved changes is shown when going to weekly planning view
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And values for recipe "<recipeName>" in meal period "<mealPeriod>" are stored
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And weekly Planning view link is clicked
        And Modal dialog Yes is selected
    When Days tab is opened
    Then Verify values for recipe "<recipeName>" in meal period "<mealPeriod>" are equal to the stored ones
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|
    
@TC29558 @D23865
Scenario Outline: Number of covers is saved after closing the app
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And Number of covers for meal period "<mealPeriod>" is set to random number
        And Save button is clicked
        And Verify notification message "Planning figures updated." is displayed
        And Menu Cycles app is closed
        And Menu Cycles app is open on "<environment>" with FourthApp "<withFA>"  
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify number of covers for meal period "<mealPeriod>" is equal to the previous inputted number
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|day   |
    |QAI        |true  |Meda     |LUNCH     |MONDAY|
    
@TC29753 @D26939
Scenario Outline: Calculate Daily Totals
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Expand all is clicked
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle                     |PlannedQuantity|PriceModel|TaxPercentage|SellPrice|
        |LUNCH         |RECIPE|724Gourmet Beef Burger 6oz      |              3|     Fixed|            0|        3|
        |LUNCH         |RECIPE|724Gourmet Chicken Burger       |              7|     Fixed|            0|        8|
        |DINNER        |RECIPE|703Houmus Sandwich Filling (50g)|              5|     Fixed|            0|        8|
    And data for buffets is set
        |MealPeriodName|TYPE  |RecipeTitle   |PlannedQuantity|PriceModel|TaxPercentage|SellPrice|
        |DANGELO       |BUFFET|Maya Buffet   |             10|     Fixed|           20|       23|
        |DANGELO       |BUFFET|Aneliya Buffet|              1|     Fixed|            5|       20|
    And data for recipes in buffet "Maya Buffet" in meal period "DANGELO" is set
        |RecipeTitle              |PlannedQuantity|
        |004Fish Stock (bouillon) |             10|
        |004Basic Sponge          |             20|
        |004Fresh Lemon Curd      |             30|
        |004Beef Stock (bouillon) |              7|
    And data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is set
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              2|
        |004Beef Stock (bouillon)     |              3|
        |004Tartare Sauce (bulk)      |              4|
        |004Fresh Lemon Curd          |              5|
        |004Blueberry Muffin (Wrapped)|              6|
        |004Baked Beans_1             |              7|
    Then Verify Daily Totals are equal to
        |PlannedQty|TotalCost|Revenue|ActualGP|
        |       109|   323.19| 315.71|     -2%|
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|day    |
    |QAI        |false |Meda     |TUESDAY|
        
@TC29844
Scenario Outline: No planning data available message
Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify "No planning data available. Please add a meal period." message is displayed
        And Verify save button is disabled
        
    @QAI
    Examples:
    |environment|withFA|menuCycle                   |day    |
    |QAI        |false |Testing Copying Meal Periods|TUESDAY|
        
@TC29845
Scenario Outline: Error message is displayed when changes are made and Update Price button is clicked
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Update prices button is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
    Then Verify notification message "You have some unsaved changes. Please save them before continuing." is displayed
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |DANGELO   |004Baked Beans_3|FRIDAY|
    
@TC29885 @D24506
Scenario Outline: No modal dialog is shown if there are no changes and Cancel button is clicked
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When Cancel button is clicked
        And Wait for Calendar view
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI        |false |Meda     |MONDAY|

@TC29874
Scenario Outline: Notification is shown when user is trying to save planning with the same price type selected several times
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And TariffType is set to "TariffOne" for recipe "<recipeName>" with current TariffType "TariffTwo" in meal period "<mealPeriod>"
        And Save button is clicked
    Then Verify notification message "Please make sure that you have not selected the same price type several times for the same item" is displayed
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|
    
@TC29875
Scenario Outline: Notification is shown when user has selected all available price types
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
    Then Verify notification message "There are 14 price types available. You cannot add more." is displayed
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName      |day   |
    |QAI        |false |Meda     |LUNCH     |004Baked Beans_3|MONDAY|
    
@TC30010 @D24750
Scenario Outline: Modal dialog is closed on cancel when only PriceModel is changed for an unsaved recipe
        Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
            And planning for "<day>" is opened
        When data for recipes is set
        |MealPeriodName|RecipeTitle |PriceModel|
        |<mealPeriod>  |<recipeName>|        GP|
        When Cancel button is clicked
            And Modal dialog Yes is selected
            And Wait for Calendar view
        Then Verify calendar view is opened
        
    @QAI
    Examples:
    |environment|withFA|menuCycle|mealPeriod|recipeName       |day   |
    |QAI        |false |Meda     |DANGELO   |004Bechamel Sauce|FRIDAY|
        
@TC30592 @D25310
Scenario Outline: User should not be redirected to the planning screen after navigating to Nutrition view and back
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
            And planning for "<day>" is opened
    When nutrition tab is opened
        And planning tab is opened
        And Calendar tab is clicked and calendar view has loaded
        And Home button is clicked
        And Menu Cycle "<menuCycle>" is selected
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI        |false |Meda     |MONDAY|
    
    
@TC27677 @Smoke
Scenario Outline: Select calendar button on planning screen without any changes
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When Calendar tab is clicked and calendar view has loaded
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI        |false |Meda     |MONDAY|
    
@TC31037
Scenario Outline: Verify save button is disabled if menu cycle is published
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify save button is disabled
    
    @QAI
    Examples:
    |environment|withFA|menuCycle         |day      |
    |QAI        |false |Local User Testing|WEDNESDAY|
       
@TC37810    
Scenario Outline: Save button is disabled for locked menu cycle
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify save button is disabled
        
    @QAI
    Examples:
    |environment|withFA|menuCycle        |day    |
    |QAI_2      |false |LOCKED MENU CYCLE|TUESDAY|
    
@TC38806    
Scenario Outline: Verify planning weekly totals equals the sum of all meal period totals
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Weeks tab is opened
    Then Verify weekly planning totals equals the sum of all meal period totals
    
        
    @QAI
    Examples:
    |environment|withFA|menuCycle                               |day   |
    |QAI_2      |false |AUTOMATION - API Integration Weekly View|MONDAY|
    
@TC39250
Scenario Outline: Default values are '0' for unplanned meal period
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Expand all is clicked
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |TariffType|SellPrice|PlannedQty|
        |<mealPeriod>  |RECIPE|<recipeName>|TariffOne |     0.00|0         |
        And Verify number of covers for meal period "<mealPeriod>" is equal to "0"
        
    @QAI
    Examples:
    |environment|withFA|menuCycle         |day   |mealPeriod|recipeName     |
    |QAI_2      |false |Automation Testing|MONDAY|DINNER    |004Basic Sponge|
    
@TC39251
Scenario Outline: Default values are '0' when adding new recipe tariff type
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And Expand all is clicked
    When Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle |TariffType|SellPrice|PlannedQty|
        |<mealPeriod>  |RECIPE|<recipeName>|TariffTwo |     0.00|0         |
        
    @QAI
    Examples:
    |environment|withFA|menuCycle         |day   |mealPeriod|recipeName     |
    |QAI_2      |false |Automation Testing|MONDAY|DINNER    |004Basic Sponge|