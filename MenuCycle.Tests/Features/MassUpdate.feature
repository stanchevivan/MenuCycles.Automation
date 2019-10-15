Feature: Mass Update
	Mass Update functionalities and validations
    
    #still waiting for functionality implementation

#Scenario Outline: sdsaasdsa
    #Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       # And a central user is selected
       # And Menu Cycle "<menuCycle>" is selected
   # When Mass Update page is opened
      #  And recipe "<recipeName>" is searched
      #  And recipe "<recipeName>" is expanded
      #  And checkbox for row "<week>", "<day>", "<mealPeriod>" in  recipe "<recipeName>" is selected
       # And recipe "<recipeName>" is selected
    
   # @QAI
  # Examples:
 #  |environment|withFA|menuCycle|week  |mealPeriod|day   |recipeName      |
 #  |QAI        |false |Meda     |Week 1|LUNCH     |Sunday|004Baked Beans_0|
    

    @TC43047
    Scenario Outline: Validate message no results
    Given Menu Cycles app is open on "<environment>" with FourthApp "<withFA>" 
       And a central user is selected
       And Menu Cycle "<menuCycle>" is selected
    When Mass Update page is opened
       And recipe "<recipeName>" is searched
    Then The result message is "<message>"

    @QAI
    Examples:
   |environment|withFA|menuCycle|recipeName|message                                 |
   |QAI        |false |Meda     |Marto     |We couldn't find any results for "Marto"|