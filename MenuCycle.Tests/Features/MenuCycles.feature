﻿# Example feature
# @ignore
Feature: MenuCycles
    Menu Cycles functionalities and validations

Background: 
Given 'Menu Cycles' application is open
And a central user is selected

@TC27713 @Smoke
Scenario: Search Menu Cycles by name or description
    When Menu Cycle "FOR AUTOMATION TESTS - DO NOT TOUCH" is searched
        And Verify search results contain the following menu cycles
        |Name|Description                        |
        |Meda|FOR AUTOMATION TESTS - DO NOT TOUCH|
    When Menu Cycle "MC with recipes" is searched
        And Verify search results contain the following menu cycles
        |Name           |Description                                |
        |MC with recipes|Testing the publishing of a MC with recipes|

@TC27706 @TC27653 @TC27658 @Smoke
Scenario: Create Edit Delete menu cycle
    When Menu Cycle is created with following data
    |MenuCycleName                   |Description   |GapDays           |Usergroup|
    |Automatically created menu cycle|no description|Wednesday,Thursday|SodexoUK |
        And Verify GAP days in calendar view are
            |Day      |
            |Wednesday|
            |Thursday |
        And Home button is clicked
        And Verify search results contain the following menu cycles
            |Name                            |Description   |
            |Automatically created menu cycle|no description|
        And Menu Cycle "Automatically created menu cycle" is copied
        And Verify search results contain the following menu cycles
            |Name                            |Description   |
            |Automatically created menu cycle|no description|
            |Automatically created menu cycle|no description|
        And Menu Cycle "Automatically created menu cycle" is edited to
            |MenuCycleName                  |Description    |
            |Automatically edited menu cycle|yes description|
        And Home button is clicked
        And Verify search results contain the following menu cycles
            |Name                            |Description    |
            |Automatically edited menu cycle |yes description|
            |Automatically created menu cycle|no description |
        And Menu Cycle "Automatically created menu cycle" is deleted
        And Menu Cycle "Automatically edited menu cycle" is deleted
        And Menu Cycle "Automatically created menu cycle" is searched
    Then Verify search results contain no menu cycles
        And Menu Cycle "Automatically created menu cycle" is searched
    Then Verify search results contain no menu cycles