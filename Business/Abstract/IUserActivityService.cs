using Repository.Core.Models;

namespace Business.Abstract
{
    public interface IUserActivityService
    {
        Task<UserActivity> AuthenticateUser(string userName, string password);
    }
}
