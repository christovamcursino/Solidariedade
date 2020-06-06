using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.DataAccess.Repositories
{
    public class StateRepository : IStateRepository
    {
        protected DbContext _context;
        public StateRepository(DbContext context)
        {
            _context = context;
        }

        public IEnumerable<State> GetAll()
        {
            return _context.Set<State>();
        }

        public State getByUF(string uf)
        {
            return _context.Set<State>().Find(uf);
        }
    }
}
