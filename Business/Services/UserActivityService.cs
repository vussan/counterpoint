using Business.Abstract;
using Repository.Core;
using Repository.Core.Models;
using Utils;

namespace Business.Services
{
    public class UserActivityService : IUserActivityService
    {
        private readonly IUnitOfWork _uow;
        public UserActivityService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<UserActivity> AuthenticateUser(string username, string password)
        {
            return await _uow.UserActivities.Get(x => x.UaCallLetters == username && x.UaPassWord == password);
        }
    }
}
