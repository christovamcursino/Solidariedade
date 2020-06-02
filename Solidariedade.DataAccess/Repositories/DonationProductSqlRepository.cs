using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class DonationProductSqlRepository : RepositorySqlBase<Guid, DonationProduct>, IDonationProductProductRepository
    {
        public DonationProductSqlRepository(DbContext context) : base(context) { }

        public IEnumerable<DonationProduct> GetAllDonationProductOfPerson(DonatorPerson donatorPerson)
        {
            return _context.Set<DonationProduct>()
                .Where<DonationProduct>(o => o.DonatorPerson.Id.Equals(donatorPerson.Id));
        }

        public IEnumerable<DonationProduct> GetAllDonationProductOfState(State state)
        {
            return _context.Set<DonationProduct>()
                .Where<DonationProduct>(o => o.DonatorPerson.State.UF.Equals(state.UF));
        }
    }
}