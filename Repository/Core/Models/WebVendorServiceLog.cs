using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebVendorServiceLog
    {
        public int Code { get; set; }
        public int VendorIdCode { get; set; }
        public string FunctionCalled { get; set; } = null!;
        public int Result { get; set; }
        public string Message { get; set; } = null!;
        public string SentToAff { get; set; } = null!;
        public DateTime TransmissionDate { get; set; }
        public string Service { get; set; } = null!;
        public string ExportOrImport { get; set; } = null!;
    }
}
