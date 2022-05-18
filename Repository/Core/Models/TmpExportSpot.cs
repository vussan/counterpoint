using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class TmpExportSpot
    {
        public int AttCode { get; set; }
        public string? Advt { get; set; }
        public string? Prod { get; set; }
        public string? PledgeStartDate1 { get; set; }
        public string? PledgeEndDate { get; set; }
        public string? PledgeStartTime { get; set; }
        public string? PledgeEndTime { get; set; }
        public string? FeedDate { get; set; }
        public string? FeedTime { get; set; }
        public int? SpotLen { get; set; }
        public string? Cart { get; set; }
        public string? Isci { get; set; }
        public string? CreativeTitle { get; set; }
        public string? AvailName { get; set; }
        public int AstCode { get; set; }
        public string? ActualAirDate1 { get; set; }
        public string? ActualAirTime1 { get; set; }
        public string? StatusCode { get; set; }
    }
}
