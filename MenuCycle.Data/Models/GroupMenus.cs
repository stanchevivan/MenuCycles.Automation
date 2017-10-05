using System;
using System.Collections.Generic;

namespace MenuCycle.Data.Models
{
    public partial class GroupMenus
    {
        public long GroupId { get; set; }
        public long MenuId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        public Groups Group { get; set; }
        public Menus Menu { get; set; }
    }
}
