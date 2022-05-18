using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebExportArchive
    {
        public int Code { get; set; }
        public int AttCode { get; set; }
        public int VendorIdCode { get; set; }
        public DateTime ExportMondayDate { get; set; }
        public int HasBeenSent { get; set; }
        public DateTime EnteredDateTime { get; set; }
        public int DaysChanged { get; set; }
        public DateTime ProcessedDateTime { get; set; }
        public string ErrorMessage { get; set; } = null!;
    }
}
