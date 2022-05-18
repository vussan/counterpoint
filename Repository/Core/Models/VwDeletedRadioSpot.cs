using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class VwDeletedRadioSpot
    {
        public int AstCode { get; set; }
        public string AttCode { get; set; } = null!;
        public string? StationName { get; set; }
        public string? VehicleName { get; set; }
        public string? Password { get; set; }
        public string? Advt { get; set; }
        public string? Prod { get; set; }
        public DateTime? PledgeStartDate { get; set; }
        public DateTime? PledgeEndDate { get; set; }
        public DateTime? PledgeStartTime { get; set; }
        public DateTime? PledgeEndTime { get; set; }
        public int? SpotLen { get; set; }
        public string? Cart { get; set; }
        public string? CreativeTitle { get; set; }
        public string? Isci { get; set; }
    }
}
