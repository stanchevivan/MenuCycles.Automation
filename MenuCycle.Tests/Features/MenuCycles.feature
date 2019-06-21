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