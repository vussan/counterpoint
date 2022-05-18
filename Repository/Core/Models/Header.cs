using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Header
    {
        public Header()
        {
            StationFileStatuses = new HashSet<StationFileStatus>();
        }

        public string Attcode { get; set; } = null!;
        public string? Networkswprovider { get; set; }
        public string? Websiteprovider { get; set; }
        public string? Stationprovider { get; set; }
        public string? Networkname { get; set; }
        public string? Vehiclename { get; set; }
        public string? Stationname { get; set; }
        public string? Attexporttype { get; set; }
        public string? Attlogtype { get; set; }
        public string? Attposttype { get; set; }
        public string? StartTime { get; set; }
        public string? Attstationemail { get; set; }
        public string? Attstationpw { get; set; }
        public string? Attagreementemail { get; set; }
        public string? Attagreementpw { get; set; }
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
        public string? PledgeByEvent { get; set; }
        public string? AltVehName { get; set; }
        public string? MgsOnWeb { get; set; }
        public string? ReplacementsOnWeb { get; set; }
        public string? WebSiteVersion { get; set; }
        public string? Market { get; set; }
        public int? Rank { get; set; }
        public string? ShowCart { get; set; }

        public virtual ICollection<StationFileStatus> StationFileStatuses { get; set; }
    }
}
