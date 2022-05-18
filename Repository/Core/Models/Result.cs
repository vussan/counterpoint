using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Result
    {
        public int AstCode { get; set; }
        public int AttCode { get; set; }
        public int SpotSeqNum { get; set; }
        public int CpyRotCode { get; set; }
        public string? Advt { get; set; }
        public string? Prod { get; set; }
        public string? TranType { get; set; }
        public DateTime? PledgeStartDate { get; set; }
        public DateTime? PledgeEndDate { get; set; }
        public DateTime? PledgeStartTime { get; set; }
        public DateTime? PledgeEndTime { get; set; }
        public string? StatusCode { get; set; }
        public int? SpotLen { get; set; }
        public string? Cart { get; set; }
        public string? Isci { get; set; }
        public string? CreativeTitle { get; set; }
        public DateTime? ActualAirDate { get; set; }
        public DateTime? ActualAirtime { get; set; }
        public DateTime? ActualDateTime { get; set; }
        public int? DescrepancyCode { get; set; }
        public DateTime? PostDate { get; set; }
        public DateTime? ExportDate { get; set; }
        public int PostedFlag { get; set; }
        public int ExportedFlag { get; set; }
        public string? AvailName { get; set; }
        public DateTime SentDate { get; set; }
    }
}
