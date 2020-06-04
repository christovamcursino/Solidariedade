using Solidariedade.Domain.Entities;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces
{
    public interface IDoneePersonApp
    {
        Person AddDoneePerson(DoneePerson doneePerson);
        DoneePerson GetDoneePersonByEmail(String email);
        IEnumerable<DoneePerson> GetAllDonee();
    }
}
