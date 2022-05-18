using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class ReplacementReason
    {
        public int Code { get; set; }
        public string Reason { get; set; } = null!;
    }
}
