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
            |724Fried Egg             |Recipe|£0.4 |
            |724Stir Fried Vegetables |Recipe|£0   |
            |724Fried Button Mushrooms|Recipe|£0.59|
        And Recipe "Boiled" is searched
    Then Verify items present in the search results are
        |Name                |Type  |Cost|
        |004Boiled Rice      |Recipe|£0  |
        |724Boiled Brown Rice|Recipe|£0  |