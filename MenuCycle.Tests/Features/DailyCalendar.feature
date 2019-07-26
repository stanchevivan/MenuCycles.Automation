Feature: Daily Calendar
	Daily Calendar Feature
	
@TC34368 @TC34367
Scenario Outline: Daily Calendar view is switched for central user
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When daily calendar view is switched
        And Verify day "<day>" is visible
        And daily calendar view is switched
    Then Verify day "<day>" is not visible
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|day   |
    |QAI        |false |Meda     |Sunday|
    
@TC34370 @TC34369
Scenario Outline: Daily Calendar view is switched for local user
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a local user is selected
        And location "<location>" is selected
    When Menu Cycle "<menuCycle>" is selected
        And daily calendar view is switched
        And Verify day "<day>" is visible
        And daily calendar view is switched
    Then Verify day "<day>" is not visible
    
    @QAI
    Examples:
    |environment|withFA|location|menuCycle         |day       |
    |QAI        |false |SE001   |Local User Testing|SUN 28 JUL|
    
@TC37976
Scenario Outline: Review page is opened
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When daily review page is opened
    Then Verify review page is open
    
    @QAI
    Examples:
    |environment|withFA|menuCycle|
    |QAI        |false |Meda     |
    
@TC37976
Scenario Outline: Navigate to meal period details from internal search
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
    When search in Menu Cycle for " "
        And view recipe "<recipeName>" in week "<weekName>"
    Then Verify meal period details for "<weekName> <day>" is open
    @QAI
    Examples:
    |environment|withFA|menuCycle|recipeName     |weekName|day   |
    |QAI        |false |Meda     |004Baked Beanss|Week 1  |Sunday|
    
@TC38603
Scenario Outline: User is redirected to the week from which he opened the Planning screen
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<weekName>" is opened
        And planning for "<day>" is opened
    When Cancel button is clicked and calendar view has loaded
    Then Verify week name is "<weekName>"
    @QAI
    Examples:
    |environment|withFA|menuCycle                  |weekName|day   |
    |QAI        |false |Automation - Multiple weeks|WEEK 2  |Monday|
    
@TC38604
Scenario Outline: User is redirected to the week from which he opened the Review page
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<weekName>" is opened
        And daily review page is opened
    When Cancel button is clicked and calendar view has loaded
    Then Verify week name is "<weekName>"
    @QAI
    Examples:
    |environment|withFA|menuCycle                  |weekName|
    |QAI        |false |Automation - Multiple weeks|WEEK 2  |
    
@TC38605
Scenario Outline: User is redirected to the week from which he opened the Reports page
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<weekName>" is opened
        And Reports page is opened
    When Cross button is clicked and calendar view has loaded
    Then Verify week name is "<weekName>"
    @QAI
    Examples:
    |environment|withFA|menuCycle                  |weekName|
    |QAI        |false |Automation - Multiple weeks|WEEK 2  |
    
@TC40604
Scenario Outline: Delete last empty week in big menu cycle
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
        And a central user is selected
        And Menu Cycle "<menuCycle>" is selected
        And Weekly Calendar is opened
        And week "<weekName>" is opened
    When new week is added
        And Daily calendar delete week button is clicked
        And Calendar Modal dialog Yes is selected
    Then Verify next week arrow is not present
        And Verify week name is "<weekName>"
    
    @QAI
    Examples:
    |environment|withFA|menuCycle              |weekName|
    |QAI        |false |4000 items - Do not use|WEEK 2  |