#@menucycle @mealperiod @recipe
Feature: Recipes
    Recipes feature

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

@TC28829
Scenario: Retrieve recipe information from the API
    Given Menu Cycle "Test Reports" is selected
    When planning for Monday is opened
    And Meal Period "BREAKFAST UPDATED" is expanded
    Then verify the following recipes:
    |MealPeriodName   |RecipeTitle       |PlannedQuantity|CostPerUnit|TotalCosts|Type  |PriceModel|TargetGP|TaxPercentage|SellPrice|Revenue|ActualGP|
    |BREAKFAST UPDATED|724Core Fruit Bowl|101            |0          |          |RECIPE|Markup    |0       |20           |         |-      |-       |

@TC28830
Scenario: "Target %" field is not present and "Sell Price" can be edited if "Price model" = "Fixed"
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
    And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "Fixed"
    Then Target % field for recipe "004Baked Beans_3" in meal period "LUNCH" is not present
    And Sell Price for recipe "004Baked Beans_3" in meal period "LUNCH" is an editable field

@TC29033
Scenario: Target GP % has format: float and type: 2 decimals
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
    And Price model for recipe "004Baked Beans_3" in meal period "LUNCH" is set to "GP"
    And TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2.333333"
    And the user focus out
    Then TargetGP% for recipe named "004Baked Beans_3" in meal period "LUNCH" is automatically changed to two decimal number "2.33"