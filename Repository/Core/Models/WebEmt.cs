using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Repository.Core.Models
{
    public partial class WebEmt
    {
        [Key]
        public int Code { get; set; }
        public string CallLetters { get; set; } = null!;
        public int ShttCode { get; set; }
        public int AttCode { get; set; }
        public int SeqNo { get; set; }
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime DateModified { get; set; }
    }
}
