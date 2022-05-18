using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class UpdatedSpot
    {
        public int AstCode { get; set; }
        public int AttCode { get; set; }
        public string? Isci { get; set; }
        public DateTime? ActualDate { get; set; }
        public DateTime? ActualTime { get; set; }
        public string? MissedReason { get; set; }
        public string? Source { get; set; }
        public string? Status { get; set; }
    }
}
