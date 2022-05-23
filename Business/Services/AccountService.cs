using Business.Abstract;
using Business.DTOs;
using Repository.Core;
using Repository.Core.Models;
using Utils;

namespace Business.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _uow;
        public AccountService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ReturnDTO<AccountDTO>> AuthenticateUser(string userName, string password)
        {
            var result = new ReturnDTO<AccountDTO>();
            var webEmt = await _uow.WebEmts.Get(x => x.Email == userName);
            if (webEmt == null)
            {
                result.Message = "Invalid Username or Password";
                return result;
            }

            var user = await _uow.UserAccounts.Get(x => x.WebEmtcode == webEmt.Code);
            if (user == null)
            {
                result.Message = "Invalid Username or Password";
                return result;
            }

            if (user.IsActive != true)
            {
                result.Message = "User is not activated";
                return result;
            }

            if (user.LockOutEnabled == true && (user.LockoutEnd == null || user.LockoutEnd > DateUtility.DateTime))
            {
                result.Message = "User is locked out";
                return result;
            }

            var hashedPassword = HashUtility.ComputeHash(password, user.Password);
            if (hashedPassword.ToLower() != user.PasswordHash.ToLower())
            {
                AccessFailedCountIncrement(user);
                result.Message = "Invalid Username or Password";
                return result;
            }

            result.Data = new AccountDTO()
            {
                Id = user.Id,
                WebEmtcode = user.WebEmtcode,
                Email = webEmt.Email,
                PhoneNumber = user.PhoneNumber,
                RoleId = user.RoleId,
                IsActive = user.IsActive,
                TwoFactorEnabled = user.TwoFactorEnabled,
                Otc = user.Otc,
                EmailConfirmed = user.EmailConfirmed,
                PhoneNumberConfirmed = user.PhoneNumberConfirmed,
                LockOutEnabled = user.LockOutEnabled,
                LockoutEnd = user.LockoutEnd,
                AccessFailedCount = user.AccessFailedCount
            };
            result.IsSuccess = true;
            return result;
        }

        public void Add(UserAccount user)
        {
            _uow.UserAccounts.Add(user);
            _uow.SaveAsync();
        }

        private void AccessFailedCountIncrement(UserAccount user)
        {
            if (user.AccessFailedCount == null)
                user.AccessFailedCount = 1;
            else
                user.AccessFailedCount++;

            if (user.AccessFailedCount > 5)
                user.LockOutEnabled = true;
            _uow.SaveAsync();
        }
    }
}
