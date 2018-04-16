# @planningscreen
Feature: PlanningScreen
    Meal Peridos functionalities and validations

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected

#TODO (also Local?)
@TC28526
Scenario: Open Planning Screen, go to Nutritions, go back to Planning screen (Central User)
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    And daily nutrition tab is opened
    And daily planning tab is opened
    Then planning screen engine is loaded

#TODO (also Local?)
@TC28555 @ignore
Scenario: Open Planning Screen, go to Weeks, go back to Planning screen (Central User)
    Given Menu Cycle "Meda" is selected
    When planning for Tuesday is opened
    And switching to Weekly Planning view
    And switching to Daily Planning view
    Then planning screen engine is loaded

#TODO
@TC28557 @ignore
Scenario: Open Planning Screen, go to Post-Production, go back to Planning screen (Local User)
    Given a Menu Cycle is selected
    When planning for Tuesday is opened
    Then the planning screen for Tuesday is open