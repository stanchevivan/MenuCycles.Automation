using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class UserLocations
    {
        public long UserId { get; set; }
        public long LocationId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public bool? CanCreateMenuCycle { get; set; }
        public bool? CanDeleteMenuCycle { get; set; }
        public bool? CanEditMenuCycle { get; set; }

        public Locations Location { get; set; }
        public Users User { get; set; }
    }
}
