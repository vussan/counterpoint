using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebVendorOrphanedSpot
    {
        public int Code { get; set; }
        public int AstCode { get; set; }
        public int AttCode { get; set; }
        public int VendorIdCode { get; set; }
        public string SentDateTime { get; set; } = null!;
        public DateTime ProcessedDateTime { get; set; }
        public string Isci { get; set; } = null!;
        public string Missed { get; set; } = null!;
        public string Issue { get; set; } = null!;
        public int? HandleUnMatched { get; set; }
    }
}
