using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonatorPersonSqlRepository : PersonSqlRepository<Guid, DonatorPerson>, IDonatorPersonRepository
    {
        public DonatorPersonSqlRepository(DbContext context) : base(context) { }
    }
}
