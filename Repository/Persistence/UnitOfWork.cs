using Repository.Core;
using Repository.Core.IRepositories;
using Repository.Persistence.Repositories;

namespace Repository.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AffWeb_XYZContext _context;
        private readonly IUserActivityRepository? _userActivityRepository;
        private readonly IWebEmtRepository? _webEmtRepository;
        private readonly ISpotRepository? _spotRepository;

        public UnitOfWork(AffWeb_XYZContext context)
        {
            _context = context;
        }
        public IUserActivityRepository UserActivities { get => _userActivityRepository ?? new UserActivityRepository(_context); }
        public IWebEmtRepository WebEmts { get => _webEmtRepository ?? new WebEmtRepository(_context); }
        public ISpotRepository Spots { get => _spotRepository ?? new SpotRepository(_context); }

        public void SaveAsync() => _context.SaveChangesAsync();
        public void Dispose() => _context.Dispose();
    }
}
