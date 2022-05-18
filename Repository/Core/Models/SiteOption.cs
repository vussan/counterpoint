using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class SiteOption
    {
        public int Code { get; set; }
        public string? AdminFirstName { get; set; }
        public string? AdminLastName { get; set; }
        public string? AdminAddress1 { get; set; }
        public string? AdminAddress2 { get; set; }
        public string? AdminCity { get; set; }
        public string? AdminState { get; set; }
        public string? AdminZip { get; set; }
        public string? AdminCountry { get; set; }
        public string? AdminPhone { get; set; }
        public string? AdminFax { get; set; }
        public string? AdminEmail { get; set; }
        public int? DaysRetainPosted { get; set; }
        public int? DaysToDelayExport { get; set; }
        public int? WeeksOverdue { get; set; }
        public int? ChngPswd { get; set; }
        public int? SuppressLogs { get; set; }
        public string? CombineVehicles { get; set; }
        public int? DaysToRetainMissed { get; set; }
        public string? AllowBonusSpots { get; set; }
        public string? EndUserAgreement { get; set; }
        public string? NoDaysViewPost { get; set; }
        public string? SiteWithinMissMonth { get; set; }
        public string? SiteLastWk1stWk { get; set; }
        public string? SiteSkipHiatusWk { get; set; }
        public string? SiteValidDaysOnly { get; set; }
        public string? SiteTimeRange { get; set; }
        public string? SiteIscipolicy { get; set; }
        public string? SiteAllowMgspots { get; set; }
        public string? SiteAllowReplSpots { get; set; }
        public string? SiteNoMissedReason { get; set; }
        public int? SiteMgdays { get; set; }
        public int? SiteCompetSepTime { get; set; }
        public string? SiteAllowAutoPost { get; set; }
        public string? SiteAllowTodayAndFuturePosting { get; set; }
        public string? SiteMissedMgbypass { get; set; }
        public string? SiteSyncMulticast { get; set; }
    }
}
