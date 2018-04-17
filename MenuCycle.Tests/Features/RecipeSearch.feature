@menucycle @recipe @ignore
Feature: RecipeSearch
    Recipe search functionalities and validations

Background: 
Given 1 Menu Cycles exists
And 1 Meal Period exists
And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

Scenario: Add Recipe Searching By Name
    Given a Menu Cycle is selected
    And a Meal Period for MONDAY is added
    When the first recipe is searched by name 
    And recipe is added to a meal period
    Then the message 'Meal Period Saved successfully' is displayed
    And recipe is displayed under MONDAY column inside the correct Meal Period 