using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDoneePersonRepository
    {
        DoneePerson Insert(DoneePerson DoneePerson);

        IEnumerable<DoneePerson> SelectAll();

        DoneePerson Select(Guid id);
        DoneePerson SelectByEmail(String email);

        void Update(DoneePerson DoneePerson);

        void Delete(Guid id);

        void SaveChanges();
    }
}
