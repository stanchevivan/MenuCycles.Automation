using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class MenuRecipes
    {
        public long MenuId { get; set; }
        public long RecipeId { get; set; }
        public string Course { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public int DisplayOrder { get; set; }
        public double? Cover { get; set; }
        public long Id { get; set; }

        public Menus Menu { get; set; }
        public Recipes Recipe { get; set; }
    }
}
