Feature: Meal Period Details

Background:
    Given 'Menu Cycles' application is open
    And a central user is selected	

Scenario: Add Recipes
    Given Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "MONDAY" are opened
        And Recipe search is opened
        And Recipe "Apple Sauce" is searched
        And Recipe "724Apple Sauce" is added