using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;

namespace Solidariedade.Domain.Interfaces.Repositories
{
    public interface IDonatorPersonRepository
    {
        DonatorPerson Insert(DonatorPerson DonatorPerson);

        IEnumerable<DonatorPerson> SelectAll();

        DonatorPerson Select(Guid id);

        DonatorPerson SelectByEmail(String email);

        void Update(DonatorPerson DonatorPerson);

        void Delete(Guid id);

        void SaveChanges();
    }
}
