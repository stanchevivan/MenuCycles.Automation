using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCyclesData.DatabaseDataModel
{
    public class MenuCycle
    {
        public int MenuCycleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }
        public int IsPublished { get; set; }
        public int IsMaster { get; set; }
        public int IsDeleted { get; set; }
        public DateTime? StartDate{ get; set; }
        public DateTime? EndDate{ get; set; }
        public int NonServingDays { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        
        internal bool IsNew
        {
            get
            {
                return this.MenuCycleId == default(int);
            }
        }

        public int GroupId { get; set; }
    }
}
