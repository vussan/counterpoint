using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebVendorExportFact
    {
        public int ExportFactId { get; set; }
        public int VendorIdCode { get; set; }
        public int AttCode { get; set; }
        public int AstCode { get; set; }
        public DateTime FeedDate { get; set; }
        public DateTime FeedTime { get; set; }
        public string Advt { get; set; } = null!;
        public int SpotLen { get; set; }
        public string Isci { get; set; } = null!;
        public DateTime TransmissionDate { get; set; }
    }
}
