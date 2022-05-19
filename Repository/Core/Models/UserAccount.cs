using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class UserAccount
    {
        public int Id { get; set; }
        public byte RoleId { get; set; }
        public int WebEmtcode { get; set; }
        public string Password { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? Otc { get; set; }
        public DateTime? OtcexpiresOn { get; set; }
        public bool? EmailConfirmed { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? LockOutEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public byte? AccessFailedCount { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
