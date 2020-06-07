using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solidariedade.DataAccess.Repositories
{
    public class RequestedProductSqlRepository : RepositorySqlBase<Guid, RequestedProduct>, IRequestedProductRepository
    {
        public RequestedProductSqlRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<RequestedProduct> GetAllRequestedProductOfPerson(DoneePerson doneePerson)
        {
            return _context.Set<RequestedProduct>()
                .Where<RequestedProduct>(o => o.DoneePerson.Id.Equals(doneePerson.Id));
        }

        public IEnumerable<RequestedProduct> GetAllRequestedProductOfState(State state)
        {
            return _context.Set<RequestedProduct>()
                .Include(o=>o.DoneePerson)
                .Include(o=>o.Product)
                .Where<RequestedProduct>(o => o.DoneePerson.State.UF.Equals(state.UF)
                                               && o.Amount > 0);
        }

        public override RequestedProduct GetByID(Guid id)
        {
            return _context.Set<RequestedProduct>()
                .Include(o=>o.Product)
                .Include(o=>o.DoneePerson)
                .SingleOrDefault(o=>o.Id == id);
        }
        public override IEnumerable<RequestedProduct> GetAll()
        {
            return _context.Set<RequestedProduct>()
                .Include(o => o.Product)
                .Include(o => o.DoneePerson);
        }
    }
}
