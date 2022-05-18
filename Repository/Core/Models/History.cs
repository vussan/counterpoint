using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class History
    {
        public int HCode { get; set; }
        public int HType { get; set; }
        public int HattCode { get; set; }
        public string HCallLetters { get; set; } = null!;
        public string HVehicleName { get; set; } = null!;
        public string HUserName { get; set; } = null!;
        public DateTime HPostDay { get; set; }
        public DateTime HDate { get; set; }
        public DateTime HTime { get; set; }
    }
}
