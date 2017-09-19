using System;

namespace MenuCyclesData.DatabaseDataModel
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        internal bool IsNew
        {
            get
            {
                return this.CustomerId == default(int);
            }
        }
    }
}
