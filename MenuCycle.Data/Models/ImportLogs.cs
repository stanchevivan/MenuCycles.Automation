using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class ImportLogs
    {
        public ImportLogs()
        {
            ImportGroupLocations = new HashSet<ImportGroupLocations>();
        }

        public long ImportLogId { get; set; }
        public string ImportType { get; set; }
        public DateTime ImportDate { get; set; }
        public long CustomerId { get; set; }
        public int ImportStatus { get; set; }

        public ICollection<ImportGroupLocations> ImportGroupLocations { get; set; }
    }
}
