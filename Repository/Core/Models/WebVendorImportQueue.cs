using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebVendorImportQueue
    {
        public int Code { get; set; }
        public int AstCode { get; set; }
        public DateTime? AiredDate { get; set; }
        public DateTime? AiredTime { get; set; }
        public string Isci { get; set; } = null!;
        public int Missed { get; set; }
        public string? StatusGuid { get; set; }
    }
}
