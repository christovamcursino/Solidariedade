﻿using Solidariedade.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Guid, Product>
    {
    }
}
