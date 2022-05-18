using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class SystemOption
    {
        public int Code { get; set; }
        public string? Smtpserver { get; set; }
        public string? SmtpuserId { get; set; }
        public string? Smtppassword { get; set; }
        public string? SmtpfromEmailAddress { get; set; }
        public string? Smtpport { get; set; }
        public string? SmtpfromName { get; set; }
        public string? NetWorkName { get; set; }
        public string? WebLink { get; set; }
        public string? SignonTroubleLink { get; set; }
        public int LastWebLcode { get; set; }
        public int ExportIsRunning { get; set; }
    }
}
