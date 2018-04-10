@menucycle @recipe @mealperiod
Feature: RecipeSearch
    In order to guarantee Recipe Search works
    As a QA
    I want to validate all permutations and functionalities

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

Scenario: Open daily planning with one meal period
    Given a Menu Cycle is selected
    #When daily planning with one meal period is visited
    #Then the meal period is opened by default