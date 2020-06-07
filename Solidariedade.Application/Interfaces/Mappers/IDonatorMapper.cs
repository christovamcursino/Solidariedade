using Solidariedade.Application.DTO;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces.Mappers
{
    public interface IDonatorMapper
    {
        DonatorDTO DonatorToDonatorDTO(DonatorPerson donatorPerson, IEnumerable<RequestedProduct> requestedProducts);
    }
}
