using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonationSqlRepository : RepositorySqlBase<Guid, Donation>, IDonationRepository
    {
        public DonationSqlRepository(DbContext context) : base(context) { }
    }
}
