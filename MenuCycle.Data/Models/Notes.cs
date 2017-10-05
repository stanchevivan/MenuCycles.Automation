using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class Notes
    {
        public long NoteId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public long MenuCycleId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public MenuCycles MenuCycle { get; set; }
    }
}
