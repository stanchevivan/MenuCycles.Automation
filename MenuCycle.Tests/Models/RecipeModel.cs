using MenuCycle.Tests.PageObjects.Planning.PlanningTabDays;

namespace MenuCycle.Tests.Models
{
    public class RecipeModel
    {
        public RecipeModel()
        {
        }

        public RecipeModel(Recipe recipe)
        {
            MealPeriodName = recipe.MealPeriodName;
            RecipeTitle = recipe.Title;
            PlannedQuantity = recipe.PlannedQuantity;
            CostPerUnit = recipe.CostPerUnit;
            TotalCosts = recipe.TotalCosts;
            Type = recipe.Type;
            PriceModel = recipe.PriceModel;
            TargetGP = recipe.TargetGP;
            TaxPercentage = recipe.TaxPercentage;
            SellPrice = recipe.SellPrice;
            Revenue = recipe.Revenue;
            ActualGP = recipe.ActualGP;
        }

        public string MealPeriodName { get; set; }
        public string RecipeTitle { get; set; }
        public string PlannedQuantity { get; set;}
        public string CostPerUnit { get; set; }
        public string TotalCosts { get; set; }
        public string Type { get; set; }
        public string PriceModel { get; set; }
        public string TargetGP { get; set; }
        public string TaxPercentage{ get; set; }
        public string SellPrice{ get; set; }
        public string Revenue{ get; set; }
        public string ActualGP{ get; set; }
    }
}