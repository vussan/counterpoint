using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WorkStatus
    {
        public string FileName { get; set; } = null!;
        public int Status { get; set; }
        public string? Msg1 { get; set; }
        public string? Msg2 { get; set; }
        public string? Dtstamp { get; set; }
    }
}
