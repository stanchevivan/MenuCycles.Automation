@QAI
Feature: RecipeSearch
    Recipe search functionalities and validations

@TC27633 @Smoke
Scenario Outline: Recipe search by keyword in Meal period
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "MONDAY" are opened
        And Recipe search is opened
        And Recipe "Fried" is searched
        And Verify items present in the search results are
            |Name                     |Type  |Cost   |
            |724Fried Button Mushrooms|Recipe|£1.3078|
            |724Fried Eggs            |Recipe|£0.7291|
            |724Fried Onions          |Recipe|£0.1875|
            |724Stir Fried Vegetables |Recipe|£0.6052|
        And Recipe "Boiled" is searched
    Then Verify items present in the search results are
        |Name                |Type  |Cost|
        |004Boiled Rice      |Recipe|£0  |
        |724Boiled Brown Rice|Recipe|£0  |
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC30803
Scenario Outline: Recipe price should be the same for meal period detailed view and the planning screen
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "MONDAY" are opened
        And Recipe search is opened
        And Recipe "004Baked Beans_3" is searched
        And Verify items present in the search results are
            |Name            |Type  |Cost   |
            |004Baked Beans_3|Recipe|£1.9157|
        And Verify items in meal period detailed view
            |Name            |Type  |Cost   |
            |004Baked Beans_3|Recipe|£1.9157|
        And meal period detailed view is closed
        And planning for "Monday" is opened
    Then Verify data for items is
        |MealPeriodName|TYPE  |RecipeTitle     |CostPerUnit|
        |LUNCH         |RECIPE|004Baked Beans_3|       1.92|
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |

@TC30233
Scenario Outline: Single cost is present for Recipe and Ingredients in recipe detailed view
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "Tuesday" are opened
        And detailed view for recipe with name "724Gourmet Chicken Burger" is opened
    Then Verify meal period recipe name is "724Gourmet Chicken Burger"
        And Verify recipe price is "£0.375"
        And Verify ingredients in the detailed view
        |IngredientName                      |IngredientCost|
        |Chicken Breast Diced                |          0.00|
        |004Fresh White Breadcrumbs (frz) 10g|          0.00|
        |ONION FRESH                         |          0.00|
        |Parsley Curley                      |          0.00|
        |Aryzta - Sausage Roll               |          0.00|
        |Lea & Perrins - Worcestershire Sauce|          0.00|
        |EGGS WHOLE PASTEURISED              |          0.38|
        And Verify ingredients total cost is "0.38"
        
        @QAI
        Examples:
        |environment|withFA|
        |QAI        |false |