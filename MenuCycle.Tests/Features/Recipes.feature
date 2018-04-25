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