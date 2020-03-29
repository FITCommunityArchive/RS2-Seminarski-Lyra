﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate> : IBaseService<T, TSearch>
    {
        Task<T> Insert(TInsert request);
        Task<T> Update(int id, TUpdate request);
    }
}
