using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class SellPrices
    {
        public long MenuCycleItemId { get; set; }
        public int SellPricesModel { get; set; }
        public long? TariffId { get; set; }
        public decimal Value { get; set; }
        public decimal Vat { get; set; }
        public int Quantity { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public long? LocationId { get; set; }
        public long? TaxRateId { get; set; }
        public long SellPriceId { get; set; }

        public Locations Location { get; set; }
        public MenuCycleItems MenuCycleItem { get; set; }
        public Tariffs Tariff { get; set; }
        public TaxRates TaxRate { get; set; }
    }
}
