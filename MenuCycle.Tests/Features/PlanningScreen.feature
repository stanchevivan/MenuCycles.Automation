# @planningscreen
Feature: PlanningScreen
    Meal Peridos functionalities and validations

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected
#And a nouser user is selected

@TC28526
Scenario: Open Planning Screen, go to Nutritions, go back to Planning screen (Central User)
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
        And daily nutrition tab is opened
        And daily planning tab is opened
    Then planning screen engine is loaded

@TC28555
Scenario: Open Planning Screen, go to Weeks, go back to Planning screen (Central User)
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
        And switching to Weekly Planning view
        And switching to Daily Planning view
    Then planning screen engine is loaded

#TODO Post-Production tab not present yet
@TC28557 @ignore
Scenario: Open Planning Screen, go to Post-Production, go back to Planning screen (Local User)
    Given a Menu Cycle is selected
    When planning for Tuesday is opened
    Then the planning screen for Tuesday is open

@TC29023
Scenario: Save button is clicked without any changes applied
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Save button is clicked
    Then the user stays on the planning page

@TC29022
Scenario: Save all updated figures (fields)
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Number of covers for meal period "LUNCH" is set to random number
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2"
        And Save button is clicked
    Then Notification message "Planning figures updated." is displayed
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to the previous inputted number
    And the user stays on the planning page

@TC29024
Scenario: Saved data is retrieved from the API
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2"
    When Save button is clicked
        And Notification message "Planning figures updated." is displayed
        And Cancel button is clicked
        And planning for Monday is opened
    Then quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to the previous inputted number

@TC29019
Scenario: Successfully Update and Save number of covers
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
    When Number of covers for meal period "LUNCH" is set to random number
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2"
        And Save button is clicked
        And Notification message "Planning figures updated." is displayed
        And Cross button is clicked
        And planning for Monday is opened
    Then number of covers for meal period "LUNCH" is equal to the previous inputted number

@TC29080 @D23144 @D24051 @D24410
Scenario: Open Monday planning screen, then go to Tuesday, back to Monday update total quantity and click Save
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And Cancel button is clicked
        And planning for Tuesday is opened
        And Meal Period "LUNCH" is expanded
        And Verify items for meal period "Lunch" are (check count "yes")
            |MealPeriodName|TYPE  |RecipeTitle               |
            |LUNCH         |RECIPE|724Gourmet Beef Burger 6oz|
            |LUNCH         |RECIPE|724Gourmet Chicken Burger |
        And Cancel button is clicked
    When planning for Monday is opened
        And meal periods for the day are "LUNCH"
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2"
        And Save button is clicked
    Then Notification message "Planning figures updated." is displayed
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to the previous inputted number

@TC29521
Scenario: Modal dialog for unsaved changes is shown on cancel
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And values for recipe "004Baked Beans_3" in meal period "LUNCH" are stored
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And Cancel button is clicked
        And Modal dialog Yes is selected
    When planning for Monday is opened
    Then values for recipe "004Baked Beans_3" in meal period "LUNCH" are equal to the stored ones

@TC29521
Scenario: Modal dialog for unsaved changes is shown on pressing X
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And values for recipe "004Baked Beans_3" in meal period "LUNCH" are stored
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And Cross button is clicked
        And Modal dialog Yes is selected
    When planning for Monday is opened
    Then values for recipe "004Baked Beans_3" in meal period "LUNCH" are equal to the stored ones

@TC29526
Scenario: Modal dialog for unsaved changes is shown when going to nutrition
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And values for recipe "004Baked Beans_3" in meal period "LUNCH" are stored
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And daily nutrition tab is clicked
        And Modal dialog Yes is selected
    When daily planning tab is opened
    Then values for recipe "004Baked Beans_3" in meal period "LUNCH" are equal to the stored ones

@TC29521
Scenario: Modal dialog for unsaved changes is shown when going to weekly planning view
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And values for recipe "004Baked Beans_3" in meal period "LUNCH" are stored
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And weekly Planning view link is clicked
        And Modal dialog Yes is selected
    When switching to Daily Planning view
    Then values for recipe "004Baked Beans_3" in meal period "LUNCH" are equal to the stored ones

@D23865 @TC29558
Scenario: Number of covers is saved after closing the app
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And Number of covers for meal period "LUNCH" is set to random number
        And Save button is clicked
        And Notification message "Planning figures updated." is displayed
        And Menu Cycles app is closed
        And 'Menu Cycles' application is open
        And a central user is selected
        #And a nouser user is selected
        And Menu Cycle "Meda" is selected
    When planning for Monday is opened
    Then number of covers for meal period "LUNCH" is equal to the previous inputted number

@TC29753
Scenario: Calculate Daily Totals
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
        And Open all is clicked
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
        |       102|   198.48| 315.71|     37%|
