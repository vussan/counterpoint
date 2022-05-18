using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class VendorServiceController
    {
        public string Mode { get; set; } = null!;
        public DateTime HaltUntil { get; set; }
        public string GenerateDebug { get; set; } = null!;
        public string GenerateFile { get; set; } = null!;
        public int ExportRetries { get; set; }
        public int ExportSpotMax { get; set; }
        public DateTime? ExportFrom { get; set; }
        public DateTime ImportLast { get; set; }
        public DateTime ImportSpan { get; set; }
        public string ImportFiles { get; set; } = null!;
        public string InternalTesting { get; set; } = null!;
        public string IsRunning { get; set; } = null!;
    }
}
