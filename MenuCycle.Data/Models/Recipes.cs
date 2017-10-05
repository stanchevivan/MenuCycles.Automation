using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Recipes
    {
        public Recipes()
        {
            GroupRecipes = new HashSet<GroupRecipes>();
            MenuCycleItems = new HashSet<MenuCycleItems>();
            MenuRecipes = new HashSet<MenuRecipes>();
            RecipeCategories = new HashSet<RecipeCategories>();
            RecipeLocationPrices = new HashSet<RecipeLocationPrices>();
        }

        public long RecipeId { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public decimal? Cost { get; set; }
        public double? CostQuantity { get; set; }
        public string CostUnitOfMeasure { get; set; }
        public long CustomerId { get; set; }
        public decimal? MinimumCost { get; set; }
        public decimal? MaximumCost { get; set; }
        public int SellPriceModel { get; set; }
        public decimal? SellPriceModelValue { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public Customers Customer { get; set; }
        public RecipeIngredientDetails RecipeIngredientDetails { get; set; }
        public ICollection<GroupRecipes> GroupRecipes { get; set; }
        public ICollection<MenuCycleItems> MenuCycleItems { get; set; }
        public ICollection<MenuRecipes> MenuRecipes { get; set; }
        public ICollection<RecipeCategories> RecipeCategories { get; set; }
        public ICollection<RecipeLocationPrices> RecipeLocationPrices { get; set; }
    }
}
