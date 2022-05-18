using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class UserActivity
    {
        public int UaCode { get; set; }
        public string? UaCallLetters { get; set; }
        public string? UaPassWord { get; set; }
        public string? UaIpaddr { get; set; }
        public string? UaPcname { get; set; }
        public DateTime UaDateTime { get; set; }
        public string? UaBrowserInfo { get; set; }
        public string? HashedPassword { get; set; }
    }
}
