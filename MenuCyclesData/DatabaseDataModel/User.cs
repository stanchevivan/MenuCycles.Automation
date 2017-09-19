using System;

namespace MenuCyclesData.DatabaseDataModel
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string ExternalId { get; set; }
        public int IsCentral { get; set; }
        public int CustomerId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }
        

        internal bool IsNew
        {
            get
            {
                return this.UserId == default(int);
            }
        }
    }
}
