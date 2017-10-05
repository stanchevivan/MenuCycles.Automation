using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Locations
    {
        public Locations()
        {
            GroupLocations = new HashSet<GroupLocations>();
            MenuCycles = new HashSet<MenuCycles>();
            PostProductions = new HashSet<PostProductions>();
            RecipeLocationPrices = new HashSet<RecipeLocationPrices>();
            SellPrices = new HashSet<SellPrices>();
            UserLocations = new HashSet<UserLocations>();
        }

        public long LocationId { get; set; }
        public string ExternalId { get; set; }
        public string Name { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }

        public Customers Customer { get; set; }
        public ICollection<GroupLocations> GroupLocations { get; set; }
        public ICollection<MenuCycles> MenuCycles { get; set; }
        public ICollection<PostProductions> PostProductions { get; set; }
        public ICollection<RecipeLocationPrices> RecipeLocationPrices { get; set; }
        public ICollection<SellPrices> SellPrices { get; set; }
        public ICollection<UserLocations> UserLocations { get; set; }
    }
}
