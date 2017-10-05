using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class ImportGroupLocations
    {
        public long Id { get; set; }
        public string OfferCode { get; set; }
        public string LocationCode { get; set; }
        public bool Processed { get; set; }
        public string Remark { get; set; }
        public long ImportLogId { get; set; }

        public ImportLogs ImportLog { get; set; }
    }
}
