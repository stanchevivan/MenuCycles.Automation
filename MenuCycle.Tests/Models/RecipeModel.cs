namespace MenuCycle.Tests.Models
{
    public class RecipeModel
    {
        public string MealPeriodName { get; set; }
        public string Type { get; set; }
        public string RecipeTitle { get; set; }
        public string PlannedQuantity { get; set;}
        public string CostPerUnit { get; set; }
        public string TotalCosts { get; set; }
        /// <summary>
        /// Used for a workaround when mathing tariff type
        /// Should be deleted 
        /// </summary>
        /// <value>The tariff type of the recipe to be modified.</value>
        public string ForTariffType { get; set; }
        public string TariffType { get; set; }
        public string PriceModel { get; set; }
        public string Target { get; set; }
        public string TaxPercentage{ get; set; }
        public string SellPrice{ get; set; }
        public string Revenue{ get; set; }
        public string ActualGP{ get; set; }
    }
}