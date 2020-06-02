using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        public void BeginTransaction();
        public bool Commit();
    }
}
