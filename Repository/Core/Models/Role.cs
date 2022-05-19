using System;
using System.Collections.Generic;

namespace Repository.Core.Models
{
    public partial class Role
    {
        public Role()
        {
            UserAccounts = new HashSet<UserAccount>();
        }

        public byte Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<UserAccount> UserAccounts { get; set; }
    }
}
