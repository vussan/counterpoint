using Repository.Core.IRepositories;
using Repository.Core.Models;

namespace Repository.Persistence.Repositories
{
    public class SpotRepository : Repository<Spot>, ISpotRepository
    {
        public SpotRepository(AffWeb_XYZContext context) : base(context)
        {
        }
    }
}
