using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class PostProductions
    {
        public long MenuCycleItemId { get; set; }
        public long? TariffId { get; set; }
        public long? LocationId { get; set; }
        public int ProducedQuantity { get; set; }
        public int SoldQuantity { get; set; }
        public int Wastage { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public int RequiredQuantity { get; set; }
        public int NoChargeApplied { get; set; }
        public int ReturnToStock { get; set; }
        public long PostProductionId { get; set; }

        public Locations Location { get; set; }
        public MenuCycleItems MenuCycleItem { get; set; }
        public Tariffs Tariff { get; set; }
    }
}
