using System;

namespace MenuCyclesData.DatabaseDataModel
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        public object ExternalId { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public float CostQuantity { get; set; }
        public string CostUnitOfMeasure { get; set; }
        public int CustomerId { get; set; }
        public decimal MinimumCost { get; set; }
        public decimal MaximumCost { get; set; }
        public int SellPriceModel { get; set; }
        public decimal SellPriceModelValue { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        internal bool IsNew
        {
            get
            {
                return this.RecipeId == default(int);
            }
        }
    }
}
