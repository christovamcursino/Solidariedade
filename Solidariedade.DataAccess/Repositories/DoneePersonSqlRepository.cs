using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class DoneePersonSqlRepository : PersonSqlRepository<Guid, DoneePerson>, IDoneePersonRepository
    {
        public DoneePersonSqlRepository(DbContext context) : base(context) {}
    }
}
