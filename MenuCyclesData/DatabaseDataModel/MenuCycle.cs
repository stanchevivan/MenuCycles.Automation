using System;
using System.Collections.Generic;

namespace MenuCyclesData.DatabaseDataModel
{
    public class MenuCycle
    {
        public int MenuCycleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int IsPublished { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int NonServingDays { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        public int? LocationId { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public int Status { get; set; }
        public int IsModifiedLocally { get; set; }

        public string Group { get; set; }
    }
}
