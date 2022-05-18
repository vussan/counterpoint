using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class EmailNewSpot
    {
        public int Code { get; set; }
        public string? Email { get; set; }
        public string? Vehicle { get; set; }
        public string? Station { get; set; }
        public string? Password { get; set; }
        public string? NetworkName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? WasSent { get; set; }
        public string? SendLogEmail { get; set; }
    }
}
