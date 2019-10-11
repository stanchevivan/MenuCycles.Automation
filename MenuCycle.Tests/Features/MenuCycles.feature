Feature: MenuCycles
    Menu Cycles functionalities and validations

@TC27713 @Smoke
Scenario Outline: Search Menu Cycles by name or description
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
    When Menu Cycle "<mc1Description>" is searched
        And Verify search results contain the following menu cycles
        |Name                       |Description     |
        |<mc1Name>                  |<mc1Description>|
    When Menu Cycle "<mc2Name>" is searched
    Then Verify search results contain the following menu cycles
        |Name     |Description     |
        |<mc2Name>|<mc2Description>|
        
    @QAI
    Examples:
    |environment|withFA|mc1Name|mc1Description                     |mc2Name        |mc2Description                             |
    |QAI        |false |Meda   |FOR AUTOMATION TESTS - DO NOT TOUCH|MC with recipes|Testing the publishing of a MC with recipes|
    

@TC27706 @TC27653 @TC27658 @Smoke
Scenario Outline: Create Edit Copy Delete menu cycle
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
    When Menu Cycle is created with following data
    |MenuCycleName                   |Description   |GapDays           |Usergroup      |
    |Automatically created menu cycle|no description|Wednesday,Thursday|TestGroupPrice2|
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
        And Menu Cycle "Automatically edited menu cycle" is searched
    Then Verify search results contain no menu cycles
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |
    
@TC40441 @D36216
Scenario Outline: Create menu cycle page is opened after reopening of the application
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
    When Create Menu Cycle page is opened
        And browser is refreshed
        And a central user is selected
        And Create Menu Cycle page is opened
    Then Verify Create Menu Cycle page is open
    
    @QAI
    Examples:
    |environment|withFA|
    |QAI        |false |

@TC41875
Scenario Outline: [MC] Review page is visible after switching Local -> Central user
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
    When Location name is clicked
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And daily review page is opened
    Then Verify review page is open
    
    @QAI
    Examples:
    |environment|withFA|location    |menuCycle|
    |QAI        |false |   Site EUR1|Meda     |


@TC42984 @D40840
Scenario Outline: Verify menu cycle status
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
    When Menu Cycle "<menuCycle>" is searched
        Then Verify search results contains menu cycle with name "<menuCycle>" and status "<status>"
       
  @QAI
    Examples:
    |environment|withFA|menuCycle                  |status   |
    |QAI        |false |Published MC for AUTOMATION|Published|
   
    
