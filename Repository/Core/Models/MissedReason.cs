using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class MissedReason
    {
        public int Code { get; set; }
        public string Reason { get; set; } = null!;
        public string? IsDefault { get; set; }
    }
}
