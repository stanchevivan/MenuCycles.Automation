@QAI
Feature: RecipeSearch
    Recipe search functionalities and validations

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

@TC27633 @Smoke
Scenario: Recipe search by keyword in Meal period
    Given Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "MONDAY" are opened
        And Recipe search is opened
        And Recipe "Fried" is searched
        And Verify items present in the search results are
            |Name                     |Type  |Cost   |
            |724Fried Onions          |Recipe|£1.2555|
            |724Fried Egg             |Recipe|£0.7   |
            |724Stir Fried Vegetables |Recipe|£0.18  |
            |724Fried Button Mushrooms|Recipe|£0.581 |
        And Recipe "Boiled" is searched
    Then Verify items present in the search results are
        |Name                |Type  |Cost|
        |004Boiled Rice      |Recipe|£0  |
        |724Boiled Brown Rice|Recipe|£0  |

@TC30803
Scenario: Recipe price should be the same for meal period detailed view and the planning screen
    Given Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "MONDAY" are opened
        And Recipe search is opened
        And Recipe "004Baked Beans_3" is searched
        And Verify items present in the search results are
            |Name            |Type  |Cost  |
            |004Baked Beans_3|Recipe|£1.839|
        And Verify items in meal period detailed view
            |Name            |Type  |Cost  |
            |004Baked Beans_3|Recipe|£1.839|
        And meal period detailed view is closed
        And planning for "Monday" is opened
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |CostPerUnit|
        |LUNCH         |RECIPE|004Baked Beans_3|       1.84|

@TC30233
Scenario: Single cost is present for Recipe and Ingredients in recipe detailed view
    Given Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "Tuesday" are opened
        And detailed view for recipe with name "724Gourmet Chicken Burger" is opened
    Then Verify meal period recipe name is "724Gourmet Chicken Burger"
        And Verify recipe price is "£0.36"
        And Verify ingredients in the detailed view
        |IngredientName                      |IngredientCost|
        |Chicken Breast Diced                |          0.00|
        |004Fresh White Breadcrumbs (frz) 10g|          0.00|
        |ONION FRESH                         |          0.00|
        |Parsley Curley                      |          0.00|
        |Aryzta - Sausage Roll               |          0.00|
        |Lea & Perrins - Worcestershire Sauce|          0.00|
        |EGGS WHOLE PASTEURISED              |          0.36|
        And Verify ingredients total cost is "0.36"