using Solidariedade.Application.DTO;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces.Mappers
{
    public interface IRequestedProductMapper
    {
        //IEnumerable<RequestedProductDTO> DoneeToRequestedProductDTO(DoneePerson doneePerson);

        IEnumerable<RequestedProductDTO> RequestedProductToRequestedProductDTO(IEnumerable<RequestedProduct> requestedProducts);
    }
}
