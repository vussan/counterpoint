using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebVendor
    {
        public int IdCode { get; set; }
        public string Name { get; set; } = null!;
        public string ApprovalPassword { get; set; } = null!;
        public string VendorUserName { get; set; } = null!;
        public string VendorPassword { get; set; } = null!;
        public int ExportMethod { get; set; }
        public string VendorAddress { get; set; } = null!;
        public string SendUpdatesOnly { get; set; } = null!;
        public string StationUserName { get; set; } = null!;
        public string StationPassword { get; set; } = null!;
        public int ImportMethod { get; set; }
        public string IsOverridable { get; set; } = null!;
        public int Hierarchy { get; set; }
        public string SourceName { get; set; } = null!;
        public DateTime LastImportDate { get; set; }
        public string AllowAutoPost { get; set; } = null!;
        public string VendorUpdateStatus { get; set; } = null!;
        public string VendorType { get; set; } = null!;
        public string AdditionalInfo { get; set; } = null!;
    }
}
