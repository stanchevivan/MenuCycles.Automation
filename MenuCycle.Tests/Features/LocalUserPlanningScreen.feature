@QAI # @planningscreen
Feature: LocalUserPlanningScreen
    Meal Peridos functionalities and validations

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a local user is selected
#And a nouser user is selected

@TC28558 @Smoke
Scenario: Load engine when Planning screen is opened (Local User)
    Given location "SE001" is selected
        And Menu Cycle "Local User Testing" is selected
    When planning for TUE 10 JUL is opened
    Then planning screen engine is loaded

@TC30226
Scenario: Save button is disabled for passed days
    Given location "SE001" is selected
    And Menu Cycle "Local User Testing" is selected
    When planning for TUE 10 JUL is opened
    Then Save button is disabled

@TC30227
Scenario: Real date is displayed on the top of the planning screen
    Given location "SE001" is selected
    And Menu Cycle "Local User Testing" is selected
    When planning for TUE 10 JUL is opened
    Then location name "TUESDAY - 10 July 2018" is present on the top of the planning

@TC30264 @D25299
Scenario: Open Planning Screen, go to Post-Production, go back to Planning screen
    Given location "SE001" is selected
        And Menu Cycle "Local User Testing" is selected
    When planning for TUE 10 JUL is opened
        And daily post-production tab is opened
        And daily planning tab is opened
    Then planning screen engine is loaded

@TC30366 @D25410
Scenario: Open Planning Screen, go to Weekly planning
    Given location "SE001" is selected
        And Menu Cycle "Local User Testing" is selected
    When planning for WED 11 JUL is opened
        And switching to Weekly Planning view
    Then Verify Weekly Planning view is open

@TC30313 @D25310
Scenario: User should not be redirected to the planning screen after navigating to post-production and back
    Given location "SE001" is selected
        And Menu Cycle "Local User Testing" is selected
    When planning for TUE 10 JUL is opened
        And daily post-production tab is opened
        And daily planning tab is opened
        And Cross button is clicked
        And Home button is clicked
        And Menu Cycle "Local User Testing" is selected
    Then Calendar view is opened

@TC27776 @Smoke
Scenario: Create menu cycle button is not present - local user
    Given location "SE001" is selected
    Then Create menu cycle button is not displayed

#TODO: Needs seeded data
@TC30910 @ForDataSeeding @ignore
Scenario: Save button is clicked without any changes applied (Local user)
    Given location "SE001" is selected
        And Menu Cycle "Menu Cycle for Local user" is selected
    When planning for THUR 2 AUG is opened
        And Save button is clicked
    Then Notification message "Planning figures updated." is displayed