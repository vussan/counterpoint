using Business.Abstract;
using Repository.Core;
using Repository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class SpotService : ISpotService
    {
        private readonly IUnitOfWork _uow;

        public SpotService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IEnumerable<Spot>> GetAll()
        {
            return await _uow.Spots.GetAll();
        }
    }
}
