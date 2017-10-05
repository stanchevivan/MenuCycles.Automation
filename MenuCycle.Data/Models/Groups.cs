using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Groups
    {
        public Groups()
        {
            GroupLocations = new HashSet<GroupLocations>();
            GroupMenus = new HashSet<GroupMenus>();
            GroupRecipes = new HashSet<GroupRecipes>();
            GroupUsers = new HashSet<GroupUsers>();
            MenuCycleGroups = new HashSet<MenuCycleGroups>();
        }

        public long GroupId { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public string GroupCode { get; set; }

        public Customers Customer { get; set; }
        public ICollection<GroupLocations> GroupLocations { get; set; }
        public ICollection<GroupMenus> GroupMenus { get; set; }
        public ICollection<GroupRecipes> GroupRecipes { get; set; }
        public ICollection<GroupUsers> GroupUsers { get; set; }
        public ICollection<MenuCycleGroups> MenuCycleGroups { get; set; }
    }
}
