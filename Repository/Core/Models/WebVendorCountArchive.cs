using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebVendorCountArchive
    {
        public int Code { get; set; }
        public int AttCode { get; set; }
        public int VendorIdCode { get; set; }
        public DateTime SpotsDate { get; set; }
        public int SpotsCount { get; set; }
        public DateTime ProcessedDateTime { get; set; }
        public string ExportOrImport { get; set; } = null!;
        public string Service { get; set; } = null!;
    }
}
