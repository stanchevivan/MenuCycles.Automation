# @planningscreen
Feature: PlanningScreen
    Meal Peridos functionalities and validations

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

@TC28526
Scenario: Open Planning Screen, go to Nutritions, go back to Planning screen (Central User)
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    And daily nutrition tab is opened
    And daily planning tab is opened
    Then planning screen engine is loaded

@TC28555
Scenario: Open Planning Screen, go to Weeks, go back to Planning screen (Central User)
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    And switching to Weekly Planning view
    And switching to Daily Planning view
    Then planning screen engine is loaded

#TODO Post-Production tab not present yet
@TC28557 @ignore
Scenario: Open Planning Screen, go to Post-Production, go back to Planning screen (Local User)
    Given a Menu Cycle is selected
    When planning for Tuesday is opened
    Then the planning screen for Tuesday is open

@TC29023
Scenario: Save button is clicked without any changes applied
    Given Menu Cycle "Meda" is selected
    When planning for Monday is opened
    When Save button is clicked
    Then the user stays on the planning page