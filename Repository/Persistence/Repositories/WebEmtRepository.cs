using Repository.Core.IRepositories;
using Repository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Persistence.Repositories
{
    public class WebEmtRepository: Repository<WebEmt>, IWebEmtRepository
    {
        protected readonly AffWeb_XYZContext _context;
        public WebEmtRepository(AffWeb_XYZContext context) : base(context)
        {
            _context = context;
        }

        public int RecordCount()
        {
            return _context.WebEmts.Count();
        }
    }
}
