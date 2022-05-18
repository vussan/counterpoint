using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class WebSession
    {
        public string Ukey { get; set; } = null!;
        public string Dtstamp { get; set; } = null!;
        public string Pcname { get; set; } = null!;
    }
}
