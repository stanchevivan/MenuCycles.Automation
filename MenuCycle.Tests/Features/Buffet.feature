Feature: Buffet
    Buffet feature

Background: 
# Given 1 Menu Cycles exists
# And 1 Meal Period exists
# And 3 recipes exists
And 'Menu Cycles' application is open
And a central user is selected
	
@TC27790
Scenario: Calculations for "Total Cost" and "Revenue" should be correct for GP "Price Model"
	Given Menu Cycle "Meda" is selected
    And planning for Tuesday is opened
    And Meal Period "DANGELO" is expanded
    When data for items is set
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
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|Revenue|
        |DANGELO          |BUFFET|Aneliya Buffet|    86.88|  91.45|
    And data for items is set
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

@TC27795
Scenario: Calculations for "Total Cost" and "Revenue" and "Actual GP" should be correct for Fixed "Price Model" (Buffet Menu)
    Given Menu Cycle "Meda" is selected
    And planning for Tuesday is opened
    And Meal Period "DANGELO" is expanded
    When data for items is set
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
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|Revenue|
        |DANGELO          |BUFFET|Aneliya Buffet|     86.88|  95.24|
    And data for items is set
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

@TC27796
Scenario: calculations for "Total Cost" and "Sell Price" and "Revenue" should be correct for Mark Up "Price Model" (Buffet Menu)
    Given Menu Cycle "Meda" is selected
    And planning for Tuesday is opened
    And Meal Period "DANGELO" is expanded
    When data for items is set
        |MealPeriodName   |TYPE  |RecipeTitle   |PlannedQuantity|TariffType|PriceModel|Target|TaxPercentage|
        |DANGELO          |BUFFET|Aneliya Buffet|              1| TariffOne|    Markup|     5|           20|
    And data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is set
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              1|
        |004Fresh Lemon Curd          |              2|
        |004Blueberry Muffin (Wrapped)|              3|
    And Verify data for items is
        |MealPeriodName   |TYPE  |RecipeTitle   |TotalCosts|SellPrice|Revenue|ActualGP|
        |DANGELO          |BUFFET|Aneliya Buffet|     24.21|     30.5|  25.42|      5%|
    And data for items is set
        |MealPeriodName   |TYPE  |RecipeTitle   |PlannedQuantity|
        |DANGELO          |BUFFET|Aneliya Buffet|              2|
    Then Verify data for recipes in buffet "Aneliya Buffet" in meal period "DANGELO" is
        |RecipeTitle                  |PlannedQuantity|
        |004Bechamel Sauce            |              2|
        |004Fresh Lemon Curd          |              4|
        |004Blueberry Muffin (Wrapped)|              6|