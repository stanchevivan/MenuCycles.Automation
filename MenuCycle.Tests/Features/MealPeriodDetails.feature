@QAI
Feature: Meal Period Details

Background:
    Given 'Menu Cycles' application is open
    And a central user is selected	

@TC30229
Scenario: Only one cost is presented for single recipe in the meal period detailed view
    Given Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "TUESDAY" are opened
    Then Verify items in the meal period are
    |Name                      |Type  |Cost |
    |724Gourmet Beef Burger 6oz|Recipe|£0.36|
    |724Gourmet Chicken Burger |Recipe|£0.36|

@TC30230
Scenario: Only one cost is presented for recipes in Buffet in the meal period detailed view
    Given Menu Cycle "Meda" is selected
    When Details for meal period "DANGELO" in "TUESDAY" are opened
        And Buffet "Maya Buffet" is expanded
    Then Verify recipes in meal period details for buffet "Maya Buffet" are
    |Name                                  |Cost |
    |004Basic Sponge                       |£0.58|
    |004Beef Stock (bouillon)              |£0   |
    |004Fish Stock (bouillon)              |£0.48|
    |004Fresh Lemon Curd                   |£3.39|
    |004German Shortcrust Pastry (fresh)007|£4.82|
    |724Custard Sauce (powder, fresh milk) |£0.11|

Scenario: Only single cost is presented for recipes in recipe search
    Given Menu Cycle "Meda" is selected
    When Details for meal period "LUNCH" in "MONDAY" are opened
        And Recipe search is opened
        And Recipe "724Apple Sauce" is searched
    Then Verify items present in the search results are
    |Name          |Type  |Cost|
    |724Apple Sauce|Recipe|£2.1|