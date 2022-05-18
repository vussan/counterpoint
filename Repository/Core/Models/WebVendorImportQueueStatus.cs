using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebVendorImportQueueStatus
    {
        public string? Id { get; set; }
        public int VendorIdCode { get; set; }
        public DateTime ProcessedDateTime { get; set; }
        public int ReturnStatus { get; set; }
        public int Result { get; set; }
        public string Message { get; set; } = null!;
        public bool Viewed { get; set; }
    }
}
