Feature: LocalUserPlanningScreen
    Meal Peridos functionalities and validations

@TC28558 @Smoke
Scenario Outline: Load engine when Planning screen is opened (Local User)
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for TUE 10 JUL is opened
    Then planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|location|menuCycle         |
    |QAI        |SE001   |Local User Testing|

@TC30226
Scenario Outline: Save button is disabled for passed days
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    And Menu Cycle "<menuCycle>" is selected
    When planning for TUE 10 JUL is opened
    Then Save button is disabled
    
    @QAI
    Examples:
    |environment|location|menuCycle         |
    |QAI        |SE001   |Local User Testing|
    
@TC30227
Scenario Outline: Real date is displayed on the top of the planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    And Menu Cycle "<menuCycle>" is selected
    When planning for TUE 10 JUL is opened
    Then location name "TUESDAY - 10 July 2018" is present on the top of the planning
    
    @QAI
    Examples:
    |environment|location|menuCycle         |
    |QAI        |SE001   |Local User Testing|
    
@TC30264 @D25299
Scenario Outline: Open Planning Screen, go to Post-Production, go back to Planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for TUE 10 JUL is opened
        And daily post-production tab is opened
        And daily planning tab is opened
    Then planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|location|menuCycle         |
    |QAI        |SE001   |Local User Testing|

@TC30366 @D25410
Scenario Outline: Open Planning Screen, go to Weekly planning
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for WED 11 JUL is opened
        And switching to Weekly Planning view
    Then Verify Weekly Planning view is open
    
    @QAI
    Examples:
    |environment|location|menuCycle         |
    |QAI        |SE001   |Local User Testing|

@TC30313 @D25310
Scenario Outline: User should not be redirected to the planning screen after navigating to post-production and back
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for TUE 10 JUL is opened
        And daily post-production tab is opened
        And daily planning tab is opened
        And Cross button is clicked and calendar view has loaded
        And Home button is clicked
        And Menu Cycle "<menuCycle>" is selected
    Then Calendar view is opened
    
    @QAI
    Examples:
    |environment|location|menuCycle         |
    |QAI        |SE001   |Local User Testing|

@TC27776 @Smoke
Scenario Outline: Create menu cycle button is not present - local user
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    Then Create menu cycle button is not displayed
    
    @QAI
    Examples:
    |environment|location|
    |QAI        |SE001   |

#TODO: Needs seeded data
@TC30910 @ForDataSeeding @ignore
Scenario Outline: Save button is clicked without any changes applied (Local user)
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for THUR 2 AUG is opened
        And Save button is clicked
    Then Notification message "Planning figures updated." is displayed
    
    @QAI
    Examples:
    |environment|location|menuCycle         |
    |QAI        |SE001   |Local User Testing|