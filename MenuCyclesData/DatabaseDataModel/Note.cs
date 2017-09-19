using System;

namespace MenuCyclesData.DatabaseDataModel
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int MenuCycleId { get; set; }
        public DateTime DateCreatedUtc { get; set; }
        public string CreatedByExternalId { get; set; }
        public DateTime DateUpdatedUtc { get; set; }
        public string UpdatedByExternalId { get; set; }

        internal bool IsNew
        {
            get
            {
                return this.NoteId == default(int);
            }
        }
    }
}
