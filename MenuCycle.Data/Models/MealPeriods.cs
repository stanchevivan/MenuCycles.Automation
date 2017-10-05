using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class MealPeriods
    {
        public MealPeriods()
        {
            Covers = new HashSet<Covers>();
            MenuCycleItems = new HashSet<MenuCycleItems>();
        }

        public long MealPeriodId { get; set; }
        public Guid ExternalId { get; set; }
        public string Name { get; set; }
        public long CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public Customers Customer { get; set; }
        public ICollection<Covers> Covers { get; set; }
        public ICollection<MenuCycleItems> MenuCycleItems { get; set; }
    }
}
