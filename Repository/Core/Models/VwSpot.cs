using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class VwSpot
    {
        public string? Sn { get; set; }
        public string? Vn { get; set; }
        public int AstCode { get; set; }
        public int AttCode { get; set; }
        public int CpyRotCode { get; set; }
        public string? Advt { get; set; }
        public string? Prod { get; set; }
        public string? TranType { get; set; }
        public DateTime Psd { get; set; }
        public DateTime? PledgeEndDate { get; set; }
        public DateTime? Pst { get; set; }
        public DateTime? PledgeEndTime { get; set; }
        public DateTime? FeedDate { get; set; }
        public DateTime? FeedTime { get; set; }
        public DateTime? AiredDt { get; set; }
        public string? StatusCode { get; set; }
        public int? SpotLen { get; set; }
        public string? Isci { get; set; }
        public string? AvailName { get; set; }
        public string? GsfCode { get; set; }
        public string? RecType { get; set; }
        public int Seqn { get; set; }
        public int? SrAstCode { get; set; }
        public int? SrAttCode { get; set; }
        public int? SrCpyRotCode { get; set; }
        public string? SrAdvt { get; set; }
        public string? SrProd { get; set; }
        public string? SrTranType { get; set; }
        public DateTime? Srpsd { get; set; }
        public DateTime? SrPledgeEndDate { get; set; }
        public DateTime? Srpst { get; set; }
        public DateTime? SrPledgeEndTime { get; set; }
        public DateTime? SrFeedDate { get; set; }
        public DateTime? SrFeedTime { get; set; }
        public int? SrSpotLen { get; set; }
        public string? SrIsci { get; set; }
        public string? SrAvailName { get; set; }
        public string? SrRecType { get; set; }
        public int? Code { get; set; }
        public string? Comment { get; set; }
    }
}
