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
            var hash=HashingUtility.ComputeHash("TGWA", "6E7D8C63-55E0-43B9-BCB2-6F750B8B0B95");
            return await _uow.UserActivities.Get(x => x.UaCallLetters == username && x.UaPassWord == password);
        }
    }
}
