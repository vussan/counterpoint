using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class ReportParm
    {
        public string RecId { get; set; } = null!;
        public string RptfileName { get; set; } = null!;
        public string Parameters { get; set; } = null!;
        public string ReplaceSql { get; set; } = null!;
        public string? Sqlstring { get; set; }
    }
}
