namespace Business.DTOs
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public int WebEmtcode { get; set; }
        public byte RoleId { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public bool? IsActive { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public string? Otc { get; set; }
        public bool? EmailConfirmed { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? LockOutEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public byte? AccessFailedCount { get; set; }
        

    }
}
