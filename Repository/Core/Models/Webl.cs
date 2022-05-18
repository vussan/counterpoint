using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Webl
    {
        public int WeblCode { get; set; }
        public int WeblType { get; set; }
        public int WeblattCode { get; set; }
        public string? WeblIpaddr { get; set; }
        public string? WeblPcname { get; set; }
        public string? WeblCallLetters { get; set; }
        public string? WeblVehicleName { get; set; }
        public string? WebUserName { get; set; }
        public DateTime WebPostDay { get; set; }
        public DateTime WeblDate { get; set; }
        public DateTime WeblTime { get; set; }
    }
}
