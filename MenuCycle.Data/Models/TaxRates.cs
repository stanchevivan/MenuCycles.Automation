using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class TaxRates
    {
        public TaxRates()
        {
            SellPrices = new HashSet<SellPrices>();
        }

        public long TaxRateId { get; set; }
        public string Name { get; set; }
        public double Rate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public ICollection<SellPrices> SellPrices { get; set; }
    }
}
