using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Dbversion
    {
        public string Version { get; set; } = null!;
        public DateTime VersionDate { get; set; }
        public string? Notes { get; set; }
    }
}
