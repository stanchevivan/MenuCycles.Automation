﻿# @planningscreen
Feature: LocalUserPlanningScreen
    Meal Peridos functionalities and validations

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a local user is selected
#And a nouser user is selected

@TC30228
Scenario: Engine is loaded when planning screen for local user is opened
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