using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class RecipeCategories
    {
        public long RecipeId { get; set; }
        public string CategoryExternalId { get; set; }
        public string CategoryName { get; set; }

        public Recipes Recipe { get; set; }
    }
}
