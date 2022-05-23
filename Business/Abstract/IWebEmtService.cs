using Repository.Core.Models;

namespace Business.Abstract
{
    public interface IWebEmtService
    {
        Task<IEnumerable<WebEmt>> GetAll();
        Task<WebEmt> GetById(int id);
        Task<WebEmt> GetByEmail(string email);

        void Add(WebEmt webEmt);
        void Update(WebEmt webEmt);

        void Remove(WebEmt webEmt);

    }
}
