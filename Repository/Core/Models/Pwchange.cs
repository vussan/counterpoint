using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Pwchange
    {
        public string AttCode { get; set; } = null!;
        public string StationName { get; set; } = null!;
        public string OldStationPw { get; set; } = null!;
        public string NewStationPw { get; set; } = null!;
        public string OldAgreementPw { get; set; } = null!;
        public string NewAgreementPw { get; set; } = null!;
    }
}
