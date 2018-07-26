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
            |Name                     |Type  |Cost |
            |724Fried Onions          |Recipe|£0   |
            |724Fried Egg             |Recipe|£0.45|
            |724Stir Fried Vegetables |Recipe|£0   |
            |724Fried Button Mushrooms|Recipe|£0.64|
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
            |Name            |Type  |Cost |
            |004Baked Beans_3|Recipe|£1.88|
        And Verify items in meal period detailed view
            |Name            |Type  |Cost |
            |004Baked Beans_3|Recipe|£1.88|
        And meal period detailed view is closed
        And planning for Monday is opened
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |CostPerUnit|
        |LUNCH         |RECIPE|004Baked Beans_3|       1.88|