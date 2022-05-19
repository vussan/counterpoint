﻿using Repository.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISpotService
    {
        Task<IEnumerable<Spot>> GetAll();
    }
}
