using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class StationFileStatus
    {
        public DateTime EndDate { get; set; }
        public string AttCode { get; set; } = null!;
        public int NextRevision { get; set; }
        public DateTime RevisionDate { get; set; }

        public virtual Header AttCodeNavigation { get; set; } = null!;
    }
}
