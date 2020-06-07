using Solidariedade.Application.DTO;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces.Mappers
{
    public interface IDoneeMapper
    {
        DoneeDTO DoneeToDoneeDTO(DoneePerson doneePerson);
    }
}
