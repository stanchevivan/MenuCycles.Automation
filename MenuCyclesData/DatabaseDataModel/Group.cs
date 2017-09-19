using System;

namespace MenuCyclesData.DatabaseDataModel
{
    public class Group
    {
        public int GroupId { get; set; }
        public object ExternalId { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        internal bool IsNew
        {
            get
            {
                return this.GroupId == default(int);
            }
        }
    }
}
