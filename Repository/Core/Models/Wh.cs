using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Wh
    {
        public string? AttCode { get; set; }
        public string? NetworkSwprovider { get; set; }
        public string? WebsiteProvider { get; set; }
        public string? StationProvider { get; set; }
        public string? NetworkName { get; set; }
        public string? VehicleName { get; set; }
        public string? StationName { get; set; }
        public string? LogType { get; set; }
        public string? PostType { get; set; }
        public string? StartTime { get; set; }
        public string? StationEmail { get; set; }
        public string? StationPw { get; set; }
        public string? AggreementEmail { get; set; }
        public string? AggreementPw { get; set; }
        public string? SendLogEmail { get; set; }
        public string? VehicleFtpsite { get; set; }
        public string? TimeZone { get; set; }
        public string? ShowAvailNames { get; set; }
        public string? MultiCast { get; set; }
        public string? WebLogSummary { get; set; }
        public string? WebLogFeedTime { get; set; }
        public string? Mode { get; set; }
        public string? LogStartDate { get; set; }
        public string? LogEndDate { get; set; }
        public string? MonthlyPosting { get; set; }
        public string? InterfaceType { get; set; }
        public string? UseActual { get; set; }
        public string? SuppressLog { get; set; }
        public string? AltVehName { get; set; }
        public string? PledgeByEvent { get; set; }
        public string? MgsOnWeb { get; set; }
        public string? ReplacementsOnWeb { get; set; }
        public string? WebSiteVersion { get; set; }
        public string? Market { get; set; }
        public int? Rank { get; set; }
        public string? ShowCart { get; set; }
    }
}
