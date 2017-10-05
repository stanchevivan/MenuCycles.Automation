using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class MenuCycles
    {
        public MenuCycles()
        {
            Covers = new HashSet<Covers>();
            InverseParent = new HashSet<MenuCycles>();
            MenuCycleGroups = new HashSet<MenuCycleGroups>();
            MenuCycleItems = new HashSet<MenuCycleItems>();
            Notes = new HashSet<Notes>();
        }

        public long MenuCycleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? ParentId { get; set; }
        public bool IsPublished { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int NonServingDays { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public long? LocationId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int Status { get; set; }
        public bool? IsModifiedLocally { get; set; }

        public Customers Customer { get; set; }
        public Locations Location { get; set; }
        public MenuCycles Parent { get; set; }
        public ICollection<Covers> Covers { get; set; }
        public ICollection<MenuCycles> InverseParent { get; set; }
        public ICollection<MenuCycleGroups> MenuCycleGroups { get; set; }
        public ICollection<MenuCycleItems> MenuCycleItems { get; set; }
        public ICollection<Notes> Notes { get; set; }
    }
}
