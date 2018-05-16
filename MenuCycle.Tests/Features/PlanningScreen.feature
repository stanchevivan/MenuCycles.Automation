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
        And Save button is clicked
    Then the user stays on the planning page

@TC29022
Scenario: Save all updated figures (fields)
     Given Menu Cycle "Meda" is selected
     When planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2"
        Then Save button is clicked and the message 'Planning figures updated.' is displayed
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to the previous inputted number
        And the user stays on the planning page

@TC29024
Scenario: Saved data is retrieved from the API
     Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2"
     When Save button is clicked and the message 'Planning figures updated.' is displayed
        And Cancel button is clicked
        And planning for Monday is opened
     Then quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to the previous inputted number

@TC29019
Scenario: Successfully Update and Save number of covers
    Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
    When Number of covers value for meal period "LUNCH" is set to random number
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2"
        And Save button is clicked and the message 'Planning figures updated.' is displayed
        And Cross button is clicked
        And planning for Monday is opened
    Then number of covers for meal period "LUNCH" is equal to the previous inputted number

@TC29080 @D23144
Scenario: Open Monday planning screen, then go to Tuesday, back to Monday update total quantity and click Save
     Given Menu Cycle "Meda" is selected
        And planning for Monday is opened
        And Cancel button is clicked
        And planning for Tuesday is opened
        And Cancel button is clicked
     When planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to random number
        And SellPrice for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "2"
     Then Save button is clicked and the message 'Planning figures updated.' is displayed
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is equal to the previous inputted number

@TC29101
Scenario: Error message is displayed when planned quantity for recipe is set to number <= 0
     Given Menu Cycle "Meda" is selected
     When planning for Monday is opened
        And quantity for recipe named "004Baked Beans_3" in meal period "LUNCH" is set to "0"
     Then Save button is clicked and the message 'Sorry, we could not proceed with your request' is displayed