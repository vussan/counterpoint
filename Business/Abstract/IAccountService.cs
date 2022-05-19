using Business.DTOs;

namespace Business.Abstract
{
    public interface IAccountService
    {
        Task<AccountDTO> AuthenticateUser(string userName, string password);

    }
}
