Feature: Daily Calendar
	Daily Calendar Feature
	
@TC34368 @TC34367
Scenario Outline: Daily Calendar view is switched for central user
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When daily calendar view is switched
        And Verify day "<day>" is visible
        And daily calendar view is switched
    Then Verify day "<day>" is not visible
    
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI        |Meda     |Sunday|
    
@TC34370 @TC34369
Scenario Outline: Daily Calendar view is switched for local user
    Given Menu Cycle app is open on "<environment>" 
        And a local user is selected
        And location "<location>" is selected
    When Menu Cycle "<menuCycle>" is selected
        And daily calendar view is switched
        And Verify day "<day>" is visible
        And daily calendar view is switched
    Then Verify day "<day>" is not visible
    
    @QAI
    Examples:
    |environment|location|menuCycle         |day      |
    |QAI        |SE001   |Local User Testing|SUN 5 AUG|
    
@TC37976
Scenario Outline: Review page is opened
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When daily review page is opened
    Then Verify review page is open
    
    @QAI
    Examples:
    |environment|menuCycle|
    |QAI        |Meda     |
    
@TC37976
Scenario Outline: Navigate to meal period details from internal search
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When search in Menu Cycle for " "
        And view recipe "<recipeName>" in week "<weekName>"
    Then Verify meal period details for "<weekName> <day>" is open
    @QAI
    Examples:
    |environment|menuCycle|recipeName    |weekName|day   |
    |QAI        |Meda     |004Baked Beans|Week 1  |Sunday|
    
@TC38603
Scenario Outline: User is redirected to the week from which he opened the Planning screen
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<weekName>" is opened
        And planning for "<day>" is opened
    When Cancel button is clicked and calendar view has loaded
    Then Verify week name is "<weekName>"
    @QAI
    Examples:
    |environment|menuCycle                  |weekName|day   |
    |QAI        |Automation - Multiple weeks|WEEK 2  |Monday|
    
@TC38604
Scenario Outline: User is redirected to the week from which he opened the Review page
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<weekName>" is opened
        And daily review page is opened
    When Cancel button is clicked and calendar view has loaded
    Then Verify week name is "<weekName>"
    @QAI
    Examples:
    |environment|menuCycle                  |weekName|
    |QAI        |Automation - Multiple weeks|WEEK 2  |
    
@TC38605
Scenario Outline: User is redirected to the week from which he opened the Reports page
    Given Menu Cycle app is open on "<environment>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<weekName>" is opened
        And Reports page is opened
    When Cross button is clicked and calendar view has loaded
    Then Verify week name is "<weekName>"
    @QAI
    Examples:
    |environment|menuCycle                  |weekName|
    |QAI        |Automation - Multiple weeks|WEEK 2  |