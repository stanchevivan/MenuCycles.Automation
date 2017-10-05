using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Tariffs
    {
        public Tariffs()
        {
            PostProductions = new HashSet<PostProductions>();
            SellPrices = new HashSet<SellPrices>();
        }

        public long TariffId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public long CustomerCustomerId { get; set; }

        public Customers CustomerCustomer { get; set; }
        public ICollection<PostProductions> PostProductions { get; set; }
        public ICollection<SellPrices> SellPrices { get; set; }
    }
}
