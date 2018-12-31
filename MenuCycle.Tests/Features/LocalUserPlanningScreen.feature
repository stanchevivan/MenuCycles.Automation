Feature: LocalUserPlanningScreen
    Meal Peridos functionalities and validations

@TC28558 @Smoke
Scenario Outline: Load engine when Planning screen is opened (Local User)
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |
    |QAI        |SE001   |Local User Testing|TUE 10 JUL|

@TC30226
Scenario Outline: Verify save button is disabled for passed days
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then Verify save button is disabled
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |
    |QAI        |SE001   |Local User Testing|TUE 10 JUL|
    
@TC30227
Scenario Outline: Real date is displayed on the top of the planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
    Then location name "<date>" is present on the top of the planning
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |date                  |
    |QAI        |SE001   |Local User Testing|TUE 10 JUL|TUESDAY - 10 July 2018|
    
@TC30264 @D25299
Scenario Outline: Open Planning Screen, go to Post-Production, go back to Planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily post-production tab is opened
        And daily planning tab is opened
    Then Verify planning screen engine is loaded
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |
    |QAI        |SE001   |Local User Testing|TUE 10 JUL|

@TC30366 @D25410
Scenario Outline: Open Planning Screen, go to Weekly planning
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And switching to Weekly Planning view
    Then Verify Weekly Planning view is open
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |
    |QAI        |SE001   |Local User Testing|WED 11 JUL|

@TC30313 @D25310
Scenario Outline: User should not be redirected to the planning screen after navigating to post-production and back
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
        And Menu Cycle "<menuCycle>" is selected
    When planning for "<day>" is opened
        And daily post-production tab is opened
        And daily planning tab is opened
        And Cross button is clicked and calendar view has loaded
        And Home button is clicked
        And Menu Cycle "<menuCycle>" is selected
    Then Calendar view is opened
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |
    |QAI        |SE001   |Local User Testing|TUE 10 JUL|

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
    When planning for "<day>" is opened
        And Save button is clicked
    Then Notification message "Planning figures updated." is displayed
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day       |
    |QAI        |SE001   |Local User Testing|THUR 2 AUG|