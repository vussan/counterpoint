using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class GameInfo
    {
        public string Code { get; set; } = null!;
        public string? GameDate { get; set; }
        public string? GameStartTime { get; set; }
        public string? VisitTeamName { get; set; }
        public string? VisitTeamAbbr { get; set; }
        public string? HomeTeamName { get; set; }
        public string? HomeTeamAbbr { get; set; }
        public string? LanguageCode { get; set; }
        public string? FeedSource { get; set; }
        public string? EventCarried { get; set; }
        public int? AttCode { get; set; }
    }
}
