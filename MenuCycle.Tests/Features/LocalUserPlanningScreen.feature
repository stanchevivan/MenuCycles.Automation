﻿Feature: LocalUserPlanningScreen
    Meal Peridos functionalities and validations

@TC28558 @Smoke
Scenario Outline: Load engine when Planning screen is opened (Local User)
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "WEEK 1" is opened
    When planning for "<day>" is opened
    Then Verify planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day        |
    |QAI        |false |SE001   |Local User Testing|THUR 25 JUL|

@TC30226
Scenario Outline: Verify save button is disabled for passed days
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "WEEK 1" is opened
    When planning for "<day>" is opened
    Then Verify save button is disabled
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day        |
    |QAI        |false |SE001   |Local User Testing|THUR 25 JUL|
    
@TC30227
Scenario Outline: Real date is displayed on the top of the planning screen
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "WEEK 1" is opened
    When planning for "<day>" is opened
    Then location name "<date>" is present on the top of the planning
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day        |date                   |
    |QAI        |false |SE001   |Local User Testing|THUR 25 JUL|THURSDAY - 25 July 2019|
    
@TC30264 @D25299
Scenario Outline: Open Planning Screen, go to Post-Production, go back to Planning screen
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "WEEK 1" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And planning tab is opened
    Then Verify planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day        |
    |QAI        |false |SE001   |Local User Testing|THUR 25 JUL|

@TC30366 @D25410
Scenario Outline: Open Planning Screen, go to Weekly planning
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "WEEK 1" is opened
    When planning for "<day>" is opened
        And Weeks tab is opened
    Then Verify Weekly Planning view is open
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day        |
    |QAI        |false |SE001   |Local User Testing|THUR 25 JUL|

@TC30313 @D25310
Scenario Outline: User should not be redirected to the planning screen after navigating to post-production and back
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "WEEK 1" is opened
    When planning for "<day>" is opened
        And post-production tab is opened
        And planning tab is opened
        And Cross button is clicked and calendar view has loaded
        And Home button is clicked
        And Menu Cycle "<menuCycle>" is selected
    Then Verify calendar view is opened
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day        |
    |QAI        |false |SE001   |Local User Testing|THUR 25 JUL|

@TC27776 @Smoke
Scenario Outline: Create menu cycle button is not present - local user
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
    Then Create menu cycle button is not displayed
    
    @QAI
    Examples:
    |environment|withFA|location|
    |QAI        |false |SE001   |

#TODO: Needs seeded data
# @TC30910 @ForDataSeeding @ignore
# Scenario Outline: Save button is clicked without any changes applied (Local user)
    # Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
    #     And a local user is selected
    #     And location "<location>" is selected
    #     And Menu Cycle "<menuCycle>" is selected
    # When planning for "<day>" is opened
    #     And Save button is clicked
    # Then Verify notification message "Planning figures updated." is displayed
    
    # @QAI
    # Examples:
    # |environment|withFA|location|menuCycle         |day       |
    # |QAI        |false |SE001   |Local User Testing|THUR 2 AUG|
    
@TC38354
Scenario Outline: Current week is opened when opening a non-expired menu cycle
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When Verify calendar view is opened
    Then Verify real world week is opened
        
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |
    |QAI        |false |SE001   |Local User Testing|

@TC38355    
Scenario Outline: Last week is opened when opening a menu cycle in the past
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When Verify calendar view is opened
    Then Verify week name is "WEEK 2"
        
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |
    |QAI        |false |SE001   |Local User Expired|