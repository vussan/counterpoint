using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Makegood
    {
        public int AttCode { get; set; }
        public int OrgAstCode { get; set; }
        public int NewAstCode { get; set; }
        public string? Isci { get; set; }
        public string AirDate { get; set; } = null!;
        public string AirTime { get; set; } = null!;
    }
}
