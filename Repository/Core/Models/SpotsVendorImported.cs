using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class SpotsVendorImported
    {
        public int AstCode { get; set; }
        public string Iscioriginal { get; set; } = null!;
        public string StatusCodeH1 { get; set; } = null!;
        public string Iscih1 { get; set; } = null!;
        public string SourceH1 { get; set; } = null!;
        public DateTime ActualDateTimeH1 { get; set; }
        public DateTime ProcessedDateTimeH1 { get; set; }
        public string StatusCodeH2 { get; set; } = null!;
        public string Iscih2 { get; set; } = null!;
        public string SourceH2 { get; set; } = null!;
        public DateTime ActualDateTimeH2 { get; set; }
        public DateTime ProcessedDateTimeH2 { get; set; }
        public string StatusCodeH3 { get; set; } = null!;
        public string Iscih3 { get; set; } = null!;
        public string SourceH3 { get; set; } = null!;
        public DateTime ActualDateTimeH3 { get; set; }
        public DateTime ProcessedDateTimeH3 { get; set; }
    }
}
