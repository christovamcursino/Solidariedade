using Microsoft.EntityFrameworkCore;
using Solidariedade.Domain.Interfaces.UoW;

namespace Solidariedade.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void BeginTransaction()
        {
        }

        public bool Commit()
        {
            if (_context.SaveChanges() > 0)
                return true; //Successful
            return false; //Not successful
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
