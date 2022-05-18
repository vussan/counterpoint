using Repository.Core.IRepositories;

namespace Repository.Core
{
    public interface IUnitOfWork
    {
        void SaveAsync();
        IUserActivityRepository UserActivities { get; }
    }
}
