using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class ExportHeader
    {
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
    }
}
