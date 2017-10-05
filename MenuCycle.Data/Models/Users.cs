using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Users
    {
        public Users()
        {
            GroupUsers = new HashSet<GroupUsers>();
            UserLocations = new HashSet<UserLocations>();
        }

        public long UserId { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public bool? CanCreateMenuCycle { get; set; }
        public bool? CanDeleteMenuCycle { get; set; }
        public bool? CanEditMenuCycle { get; set; }
        public bool? CanViewMenu { get; set; }
        public bool? CanViewMenuCycle { get; set; }
        public bool? CanViewRecipe { get; set; }
        public bool? CanPublishMenuCycle { get; set; }
        public bool? CanLockMenuCycle { get; set; }

        public Customers Customer { get; set; }
        public ICollection<GroupUsers> GroupUsers { get; set; }
        public ICollection<UserLocations> UserLocations { get; set; }
    }
}
