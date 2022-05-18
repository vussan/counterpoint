using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebVendorsHeader
    {
        public int VendorId { get; set; }
        public int AttCode { get; set; }
        public string MulticastDontSend { get; set; } = null!;
        public string VendorSpecificInfo { get; set; } = null!;
        public string VendorSpecificInfo2 { get; set; } = null!;
        public string VendorSpecificInfo3 { get; set; } = null!;
        public string VendorSpecificInfo4 { get; set; } = null!;
        public string VendorSpecificInfo5 { get; set; } = null!;
        public string VendorSpecificInfo6 { get; set; } = null!;
    }
}
