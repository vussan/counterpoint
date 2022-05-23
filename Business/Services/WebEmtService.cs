using Business.Abstract;
using Repository.Core;
using Repository.Core.Models;

namespace Business.Services
{
    public class WebEmtService : IWebEmtService
    {
        private readonly IUnitOfWork _uow;

        public WebEmtService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        
        public async Task<IEnumerable<WebEmt>> GetAll()
        {
            return await _uow.WebEmts.GetAll();
        }

        public async Task<WebEmt> GetById(int id)
        {
            return await _uow.WebEmts.Get(x => x.Code == id);
        }

        public async Task<WebEmt> GetByEmail(string email)
        {
            return await _uow.WebEmts.Get(x => x.Email == email);
        }

        public void Add(WebEmt webEmt)
        {
            webEmt.Status = "";
            webEmt.Code = _uow.WebEmts.MaxValue() + 1;
            _uow.WebEmts.Add(webEmt);
            _uow.SaveAsync();
        }

        public void Update(WebEmt webEmt)
        {
            _uow.WebEmts.Update(webEmt);
            _uow.SaveAsync();
        }

        public void Remove(WebEmt webEmt)
        {
            _uow.WebEmts.Remove(webEmt);
            _uow.SaveAsync();
        }

        
    }
}
