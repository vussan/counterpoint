using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class DeletedSpot
    {
        public int AstCode { get; set; }
        public int AttCode { get; set; }
        public int CpyRotCode { get; set; }
        public string? Advt { get; set; }
        public string? Prod { get; set; }
        public string? TranType { get; set; }
        public DateTime? PledgeStartDate { get; set; }
        public DateTime? PledgeEndDate { get; set; }
        public DateTime? PledgeStartTime { get; set; }
        public DateTime? PledgeEndTime { get; set; }
        public DateTime? FeedDate { get; set; }
        public DateTime? FeedTime { get; set; }
        public int? SpotLen { get; set; }
        public string? Cart { get; set; }
        public string? Isci { get; set; }
        public string? CreativeTitle { get; set; }
    }
}
