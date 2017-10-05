using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Covers
    {
        public long CoverId { get; set; }
        public long MenuCycleId { get; set; }
        public long MealPeriodId { get; set; }
        public long Day { get; set; }
        public int? PlannedQuantity { get; set; }
        public int? ActualQuantity { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public MealPeriods MealPeriod { get; set; }
        public MenuCycles MenuCycle { get; set; }
    }
}
