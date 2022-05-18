using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class VwTstNewEmail
    {
        public string Email { get; set; } = null!;
        public string? Vehicle { get; set; }
        public string? Station { get; set; }
        public string? Password { get; set; }
        public string? NetworkName { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int WasSent { get; set; }
        public string? SendLogEmail { get; set; }
    }
}
