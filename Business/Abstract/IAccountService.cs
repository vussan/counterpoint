using Business.DTOs;
using Repository.Core.Models;

namespace Business.Abstract
{
    public interface IAccountService
    {
        Task<ReturnDTO<AccountDTO>> AuthenticateUser(string userName, string password);
        void Add(UserAccount user);

    }
}
