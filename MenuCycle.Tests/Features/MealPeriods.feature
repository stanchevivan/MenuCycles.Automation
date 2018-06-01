#@menucycle @mealperiod @recipe
Feature: MealPeriods
	Meal Periods functionalities and validations

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

@TC28547
Scenario: Open daily planning with one meal period
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
    Then main data for Meal Period "Lunch" is expanded

@TC27663
Scenario: Open daily planning with multiple meal period
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    Then main data for Meal Period "Dinner" is collapsed

@TC28566
Scenario: Display correct meal period name
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    Then the planning screen for Tuesday is open

@TC28549
Scenario: Collapse single meal period
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
        And Meal Period "Lunch" is collapsed
    Then main data for Meal Period "Lunch" is collapsed

@TC28548
Scenario: Expand single meal period
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
        And Meal Period "Lunch" is expanded
    Then main data for Meal Period "Lunch" is expanded

@TC28546
Scenario: The colour of every meal period in the Planning screen is the same as in the calendar page
    Given Menu Cycle "Meda" is selected
        And Meal Period colours for "Tuesday" are saved
    When planning for Tuesday is opened
    Then Meal Period colours match the calendar view colours

@TC28800
Scenario: Display recipes, added to a meal period in the planning screen
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
        And Meal Period "LUNCH" is expanded
    Then recipe named "724Gourmet Beef Burger 6oz" is present for meal period "LUNCH"
        And recipe colour for "724Gourmet Beef Burger 6oz" match the colour for meal period "LUNCH"

@TC28801
Scenario: Display Buffet menus, added to a meal period in the planning screen
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
        And Meal Period "DANGELO" is expanded
    Then buffet named "Aneliya Buffet" is present for meal period "DANGELO"
        And buffet colour for "Aneliya Buffet" match the colour for meal period "DANGELO"
        And in meal period "DANGELO" all recipe colours inside "Aneliya Buffet" match the buffet colour

@TC28802
Scenario: Display A la carte menus, added to a meal period in the planning screen
    Given Menu Cycle "Meda" is selected
    When planning for Wednesday is opened
    Then a la carte named "Holiday A La Carte" is present for meal period "LANCE"
        And a la carte colour for "Holiday A La Carte" match the colour for meal period "LANCE"
        And in meal period "LANCE" all recipe colours inside "Holiday A La Carte" match the A La Carte colour

@TC28897
Scenario: Retrieve Number of covers for meal period from the API
    Given Menu Cycle "Test Reports" is selected
    When planning for Monday is opened
    Then number of covers for meal period "Dinner" is equal to "10"

@TC27660 @TC27662
Scenario: Open all meal periods in Planning screen
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
        And Open all is clicked
    And all meal periods are expanded
        And Close all is clicked
    Then all meal periods are collapsed

@TC29384 @ignore #Functionality not implemented yet
Scenario: Calculate Meal period "Planned Quantity" and "Total Cost" - recipes only
    Given Menu Cycle "Meda" is selected
    When planning for Thursday is opened
    And data for recipes is set
        |MealPeriodName|TYPE  |RecipeTitle                                 |PlannedQuantity|PriceModel|Target|TaxPercentage|SellPrice|
        |DANGELO       |RECIPE|703Coronation Chicken Sandwich Filling (50g)|             10|        GP|    14|            20|        |
        |DANGELO       |RECIPE|703Reggae Raggae Mayonnaise                 |             10|     Fixed|      |            20|       1|
        |DANGELO       |RECIPE|Cheese                                      |             10|    Markup|    12|            20|        |
    Then Value for fields for meal period "DANGELO" is
        |PlannedQty|TotalCost|Revenue|ActualGP|
        |        30|   218.50| 243.50|     10%|