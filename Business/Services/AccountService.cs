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

        public async Task<AccountDTO> AuthenticateUser(string userName, string password)
        {
            var webEmt = await _uow.WebEmts.Get(x => x.Email == userName);
            if (webEmt == null)
                return null;

            var user = await _uow.UserAccounts.Get(x => x.WebEmtcode == webEmt.Code);
            if (user == null)
                return null;

            var hashedPassword = HashUtility.ComputeHash(password, user.Password);
            if (hashedPassword.ToLower() == user.PasswordHash.ToLower())
                return new AccountDTO()
                {
                    Id = user.Id,
                    WebEmtcode = user.WebEmtcode,
                    Email = webEmt.Email,
                    RoleId = user.RoleId
                };

            return null;
        }
    }
}
