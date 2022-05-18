using Microsoft.EntityFrameworkCore;
using Repository.Core.IRepositories;
using Repository.Core.Models;

namespace Repository.Persistence.Repositories
{
    public class UserActivityRepository : Repository<UserActivity>, IUserActivityRepository
    {
        protected readonly AffWeb_XYZContext _context;
        public UserActivityRepository(AffWeb_XYZContext context) : base(context)
        {
            _context= context;
        }
    }
}
