using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Dtslog
    {
        public int LogId { get; set; }
        public string? Dtspackage { get; set; }
        public string? Event { get; set; }
        public int? ReturnType { get; set; }
        public DateTime? LogDate { get; set; }
    }
}
