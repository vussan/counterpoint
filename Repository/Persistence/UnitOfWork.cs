using Repository.Core;
using Repository.Core.IRepositories;
using Repository.Persistence.Repositories;

namespace Repository.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AffWeb_XYZContext _context;
        private readonly IUserActivityRepository? _userActivityRepository;

        public UnitOfWork(AffWeb_XYZContext context)
        {
            _context = context;
        }
        public IUserActivityRepository UserActivities { get => _userActivityRepository ?? new UserActivityRepository(_context); }
        public void SaveAsync() => _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}
