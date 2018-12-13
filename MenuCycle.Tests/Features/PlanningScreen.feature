Feature: PlanningScreen
    Meal Peridos functionalities and validations

@TC28526
Scenario Outline: Open Planning Screen, go to Nutritions, go back to Planning screen (Central User)
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Tuesday is opened
        And daily nutrition tab is opened
        And daily planning tab is opened
    Then planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |

@TC28555
Scenario Outline: Open Planning Screen, go to Weeks, go back to Planning screen (Central User)
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Tuesday is opened
        And switching to Weekly Planning view
        And switching to Daily Planning view
    Then planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |  

@TC29023
Scenario Outline: Save button is clicked without any changes applied
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Monday is opened
        And Save button is clicked
    Then the user stays on the planning page
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |  

@TC29022
Scenario Outline: Save all updated figures (fields)
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Monday is opened
        And Number of covers for meal period "<mealPeriod>" is set to random number
        And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle |SellPrice|
        |<mealPeriod>  |RECIPE|<recipeName>|     0#99|
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2"
        And Save button is clicked
    Then Notification message "Planning figures updated." is displayed
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is equal to the previous inputted number
    And the user stays on the planning page
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
@TC29024
Scenario Outline: Saved data is retrieved from the API
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2"
    When Save button is clicked
        And Notification message "Planning figures updated." is displayed
        And Cancel button is clicked
        And Wait for Calendar view
        And planning for Monday is opened
    Then quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is equal to the previous inputted number
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
    
@TC29019
Scenario Outline: Successfully Update and Save number of covers
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
    When Number of covers for meal period "<mealPeriod>" is set to random number
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2"
        And Save button is clicked
        And Notification message "Planning figures updated." is displayed
        And Cross button is clicked and calendar view has loaded
        And planning for Monday is opened
    Then number of covers for meal period "<mealPeriod>" is equal to the previous inputted number
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
@TC29080 @D23144 @D24051 @D24410
Scenario Outline: Open Monday planning screen, then go to Tuesday, back to Monday update total quantity and click Save
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
        And Cancel button is clicked
        And planning for Tuesday is opened
        And Meal Period "<mealPeriod>" is expanded
        And Verify items for meal period "<mealPeriod>" are (check count "yes")
            |MealPeriodName|TYPE  |RecipeTitle|
            |<mealPeriod>  |RECIPE|<item1>    |
            |<mealPeriod>  |RECIPE|<item2>    |
        And Cancel button is clicked
    When planning for Monday is opened
        And meal periods for the day are "<mealPeriod>"
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Price model for recipe "<recipeName>" in meal period "<mealPeriod>" is set to "Fixed"
        And SellPrice for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to "2"
        And Save button is clicked
    Then Notification message "Planning figures updated." is displayed
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is equal to the previous inputted number
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |item1                     |item2                    |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|724Gourmet Beef Burger 6oz|724Gourmet Chicken Burger|
        
@TC29521
Scenario Outline: Modal dialog for unsaved changes is shown on cancel
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
        And values for recipe "<recipeName>" in meal period "<mealPeriod>" are stored
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Cancel button is clicked
        And Modal dialog Yes is selected
        And Wait for Calendar view
    When planning for Monday is opened
    Then values for recipe "<recipeName>" in meal period "<mealPeriod>" are equal to the stored ones
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
@TC29521
Scenario Outline: Modal dialog for unsaved changes is shown on pressing X
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
        And values for recipe "<recipeName>" in meal period "<mealPeriod>" are stored
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Cross button is clicked
        And Modal dialog Yes is selected
        And Wait for Calendar view
    When planning for Monday is opened
    Then values for recipe "<recipeName>" in meal period "<mealPeriod>" are equal to the stored ones
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
@TC29526
Scenario Outline: Modal dialog for unsaved changes is shown when going to nutrition
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
        And values for recipe "<recipeName>" in meal period "<mealPeriod>" are stored
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And daily nutrition tab is clicked
        And Modal dialog Yes is selected
    When daily planning tab is opened
    Then values for recipe "<recipeName>" in meal period "<mealPeriod>" are equal to the stored ones
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
@TC29521
Scenario Outline: Modal dialog for unsaved changes is shown when going to weekly planning view
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
        And values for recipe "<recipeName>" in meal period "<mealPeriod>" are stored
        And quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And weekly Planning view link is clicked
        And Modal dialog Yes is selected
    When switching to Daily Planning view
    Then values for recipe "<recipeName>" in meal period "<mealPeriod>" are equal to the stored ones
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
@TC29558 @D23865
Scenario Outline: Number of covers is saved after closing the app
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
        And Number of covers for meal period "<mealPeriod>" is set to random number
        And Save button is clicked
        And Notification message "Planning figures updated." is displayed
        And Menu Cycles app is closed
        And Menu Cycle app is open on "<environment>"  
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Monday is opened
    Then number of covers for meal period "<mealPeriod>" is equal to the previous inputted number
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|
    |QAI        |Meda     |LUNCH     |
    
@TC29753 @D26939
Scenario Outline: Calculate Daily Totals
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Tuesday is opened
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
    Then Daily Totals are equal to
        |PlannedQty|TotalCost|Revenue|ActualGP|
        |       109|   221.04| 315.71|     30%|
        
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |
        
@TC29844
Scenario Outline: No planning data available message
Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Tuesday is opened
    Then "No planning data available. Please add a meal period." message is displayed
        And Save button is disabled
        
    @QAI
    Examples:
    |environment|menuCycle                   |
    |QAI        |Testing Copying Meal Periods|
        
@TC29845
Scenario Outline: Error message is displayed when changes are made and Update Price button is clicked
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Friday is opened
    When quantity for recipe named "<recipeName>" in meal period "<mealPeriod>" is set to random number
        And Update prices button is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
    Then Notification message "You have some unsaved changes. Please save them before continuing." is displayed
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |DANGELO   |004Baked Beans_3|
    
@TC29885 @D24506
Scenario Outline: No modal dialog is shown if there are no changes and Cancel button is clicked
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
    When Cancel button is clicked
        And Wait for Calendar view
    Then Calendar view is opened
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |

@TC29874
Scenario Outline: Notification is shown when user is trying to save planning with the same price type selected several times
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
    When Add type is clicked for recipe "<recipeName>" in meal period "<mealPeriod>"
        And TariffType is set to "TariffOne" for recipe "<recipeName>" with current TariffType "TariffTwo" in meal period "<mealPeriod>"
        And Save button is clicked
    Then Notification message "Please make sure that you have not selected the same price type several times for the same item" is displayed
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
@TC29875
Scenario Outline: Notification is shown when user has selected all available price types
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
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
    Then Notification message "There are 10 price types available. You cannot add more." is displayed
    
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName      |
    |QAI        |Meda     |LUNCH     |004Baked Beans_3|
    
@TC30010 @D24750
Scenario Outline: Modal dialog is closed on cancel when only PriceModel is changed for an unsaved recipe
        Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
            And planning for Friday is opened
        When data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle |PriceModel|
        |<mealPeriod>  |RECIPE|<recipeName>|        GP|
        When Cancel button is clicked
            And Modal dialog Yes is selected
            And Wait for Calendar view
        Then Calendar view is opened
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|recipeName       |
    |QAI        |Meda     |DANGELO   |004Bechamel Sauce|
        
@TC30592 @D25310
Scenario Outline: User should not be redirected to the planning screen after navigating to Nutrition view and back
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
            And planning for Monday is opened
    When daily nutrition tab is opened
        And daily planning tab is opened
        And Cross button is clicked and calendar view has loaded
        And Home button is clicked
        And Menu Cycle "<menuCycle>" is selected
    Then Calendar view is opened
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |
    
@TC28500 @Smoke
Scenario Outline: Load engine when Planning screen is opened (Central User)
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Tuesday is opened
        And daily nutrition tab is opened
        And daily planning tab is opened
    Then planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |
    
@TC27677 @Smoke
Scenario Outline: Close planning screen with "X" button without any changes
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for Monday is opened
    When Cross button is clicked and calendar view has loaded
    Then Calendar view is opened
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |
    
@TC31037
Scenario Outline: Save button is disabled if menu cycle is published
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Thursday is opened
    Then Save button is disabled
    
    @QAI
    Examples:
    |environment|menuCycle                |
    |QAI        |Menu Cycle for Local user|
    
@TC31887 @D26963
Scenario Outline: Planning screen is loaded after searching for recipe which is not found
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for Monday is opened
        And Cross button is clicked and calendar view has loaded
        And Meal period "<mealPeriod>" is created for "Monday"
        And Recipe search is opened
        And Recipe "<recipeName>" is searched
        And "Sorry, we could not find any match for your search." message is displayed
        And meal period detailed view is closed
        And planning for Monday is opened
    Then planning screen engine is loaded
       
   @QAI
    Examples:
    |environment|menuCycle         |mealPeriod|recipeName|
    |QAI        |Automation Testing|LUNCH     |Madanoz   |