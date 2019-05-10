Feature: Buffet
    Buffet feature

@TC27790
Scenario Outline: Calculations for "Total Cost" and "Revenue" should be correct for GP "Price Model"
	Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And Meal Period "<mealPeriod>" is expanded
    When data for buffets is set
        |MealPeriodName   |TYPE  |RecipeTitle   |PlannedQuantity|TariffType|PriceModel|Target|TaxPercentage|
        |DANGELO          |BUFFET|Aneliya Buffet|              1| TariffOne|        GP|     5|           20|
    And data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is set
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              2|
        |004Beef Stock (bouillon)     |              3|
        |004Tartare Sauce (bulk)      |              4|
        |004Fresh Lemon Curd          |              5|
        |004Blueberry Muffin (Wrapped)|              6|
        |004Baked Beans_1             |              7|
    And Verify data for items is
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|SellPrice|Revenue|ActualGP|
        |DANGELO          |BUFFET|Aneliya Buffet|    109.79|   138.69| 115.57|      5%|
    And data for buffets is set
        |MealPeriodName   |TYPE  |RecipeTitle   |PlannedQuantity|
        |DANGELO          |BUFFET|Aneliya Buffet|              2|
    Then Verify data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              4|
        |004Beef Stock (bouillon)     |              6|
        |004Tartare Sauce (bulk)      |              8|
        |004Fresh Lemon Curd          |             10|
        |004Blueberry Muffin (Wrapped)|             12|
        |004Baked Beans_1             |             14|
    And Verify data for items is
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|SellPrice|Revenue|ActualGP|
        |DANGELO          |BUFFET|Aneliya Buffet|    219.59|   138.69| 231.15|      5%|
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI_2      |Meda     |DANGELO   |TUESDAY|
        
@TC27795
Scenario Outline: Calculations for "Total Cost" and "Revenue" and "Actual GP" should be correct for Fixed "Price Model" (Buffet Menu)
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And Meal Period "<mealPeriod>" is expanded
    When data for buffets is set
        |MealPeriodName   |TYPE  |RecipeTitle   |PlannedQuantity|TariffType|PriceModel   |TaxPercentage|SellPrice|
        |DANGELO          |BUFFET|Aneliya Buffet|              1| TariffOne|        Fixed|            5|      100|
    And data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is set
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              2|
        |004Beef Stock (bouillon)     |              3|
        |004Tartare Sauce (bulk)      |              4|
        |004Fresh Lemon Curd          |              5|
        |004Blueberry Muffin (Wrapped)|              6|
        |004Baked Beans_1             |              7|
    And Verify data for items is
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|Revenue|ActualGP|
        |DANGELO          |BUFFET|Aneliya Buffet|    109.79|  95.24|    -15%|
    And data for buffets is set
        |MealPeriodName   |TYPE  |RecipeTitle   |PlannedQuantity|
        |DANGELO          |BUFFET|Aneliya Buffet|              2|
    Then Verify data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              4|
        |004Beef Stock (bouillon)     |              6|
        |004Tartare Sauce (bulk)      |              8|
        |004Fresh Lemon Curd          |             10|
        |004Blueberry Muffin (Wrapped)|             12|
        |004Baked Beans_1             |             14|
    And Verify data for items is
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|Revenue|ActualGP|
        |DANGELO          |BUFFET|Aneliya Buffet|    219.59| 190.48|    -15%|
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI_2      |Meda     |DANGELO   |TUESDAY|
        
@TC27796
Scenario Outline: Calculations for "Total Cost" and "Sell Price" and "Revenue" should be correct for Mark Up "Price Model" (Buffet Menu)
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
        And Meal Period "<mealPeriod>" is expanded
    When data for buffets is set
        |MealPeriodName   |TYPE  |RecipeTitle   |PlannedQuantity|TariffType|PriceModel|Target|TaxPercentage|
        |DANGELO          |BUFFET|Aneliya Buffet|              1| TariffOne|    Markup|     5|           20|
    And data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is set
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              2|
        |004Beef Stock (bouillon)     |              3|
        |004Tartare Sauce (bulk)      |              4|
        |004Fresh Lemon Curd          |              5|
        |004Blueberry Muffin (Wrapped)|              6|
        |004Baked Beans_1             |              7|
    And Verify data for items is
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|SellPrice|Revenue|ActualGP|
        |DANGELO          |BUFFET|Aneliya Buffet|    109.79|   138.34| 115.28|      5%|
    And data for buffets is set
        |MealPeriodName   |TYPE  |RecipeTitle   |PlannedQuantity|Target|
        |DANGELO          |BUFFET|Aneliya Buffet|              2|    43|
    Then Verify data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              4|
        |004Beef Stock (bouillon)     |              6|
        |004Tartare Sauce (bulk)      |              8|
        |004Fresh Lemon Curd          |             10|
        |004Blueberry Muffin (Wrapped)|             12|
        |004Baked Beans_1             |             14|
    And Verify data for items is
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|SellPrice|Revenue|ActualGP|
        |DANGELO          |BUFFET|Aneliya Buffet|    219.59|   188.41| 314.01|     30%|
        
    @QAI
    Examples:
    |environment|menuCycle|mealPeriod|day    |
    |QAI_2      |Meda     |DANGELO   |TUESDAY|
        
@TC30088
Scenario Outline: Planned Quantity Values are rounded after scaling
    Given Menu Cycle app is open on "<environment>" 
        And a nouser user is selected
        And Menu Cycle "<menuCycle>" is selected
        And planning for "<day>" is opened
    When data for buffets is set
        |MealPeriodName   |TYPE  |RecipeTitle|PlannedQuantity|
        |DANGELO          |BUFFET|Maya Buffet|              5|
    And data for recipes in buffet "Maya Buffet" in meal period "DANGELO" is set
        |RecipeTitle                  |PlannedQuantity|
        |004Basic Sponge              |              6|
        |004Fresh Lemon Curd          |              7|
   And data for buffets is set
        |MealPeriodName   |TYPE  |RecipeTitle|PlannedQuantity|
        |DANGELO          |BUFFET|Maya Buffet|              6|
    Then Verify data for recipes in buffet "Maya Buffet" in meal period "DANGELO" is
        |RecipeTitle                  |PlannedQuantity|
        |004Fresh Lemon Curd          |              8|
        |004Basic Sponge              |              7|
        
    @QAI
    Examples:
    |environment|menuCycle|day   |
    |QAI_2      |Meda     |FRIDAY|