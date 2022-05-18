using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class VwWeekDate
    {
        public DateTime? MonDate { get; set; }
        public DateTime? SunDate { get; set; }
        public string? StationName { get; set; }
        public string? VehicleName { get; set; }
    }
}
