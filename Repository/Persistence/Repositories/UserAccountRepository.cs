using Repository.Core.IRepositories;
using Repository.Core.Models;

namespace Repository.Persistence.Repositories
{
    public class UserAccountRepository : Repository<UserAccount>, IUserAccountRepository
    {
        protected readonly AffWeb_XYZContext _context;
        public UserAccountRepository(AffWeb_XYZContext context) : base(context)
        {
            _context = context;
        }
    }
}
