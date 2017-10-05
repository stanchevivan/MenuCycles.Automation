using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class GroupRecipes
    {
        public long GroupId { get; set; }
        public long RecipeId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public Groups Group { get; set; }
        public Recipes Recipe { get; set; }
    }
}
