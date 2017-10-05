using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class RecipeLocationPrices
    {
        public long RecipeId { get; set; }
        public long LocationId { get; set; }
        public long? PriceLookupNumber { get; set; }
        public decimal? CostPrice { get; set; }
        public string CurrencyIsoCode { get; set; }
        public bool? HasRecipeGap { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public Customers Customer { get; set; }
        public Locations Location { get; set; }
        public Recipes Recipe { get; set; }
    }
}
