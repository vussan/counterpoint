using Repository.Core.Models;

namespace Repository.Core.IRepositories
{
    public interface IWebEmtRepository : IRepository<WebEmt>
    {
        int MaxValue();
    }
}
