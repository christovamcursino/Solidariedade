using Solidariedade.Application.DTO;
using Solidariedade.Application.Interfaces.Mappers;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Implementations.Mappers
{
    public class RequestedProductMapper : IRequestedProductMapper
    {
        private readonly IPersonMapper _personMapper;

        public RequestedProductMapper(IPersonMapper personMapper)
        {
            _personMapper = personMapper;
        }

        public IEnumerable<RequestedProductDTO> RequestedProductToRequestedProductDTO(IEnumerable<RequestedProduct> requestedProducts)
        {
            List<RequestedProductDTO> result = new List<RequestedProductDTO>();
            foreach(RequestedProduct req in requestedProducts)
            {
                RequestedProductDTO dto = new RequestedProductDTO
                {
                    Donee = _personMapper.PersonToPersonDTO(req.DoneePerson),
                    RequestedProduct = req
                };
                result.Add(dto);
            }
            return result;
        }
    }
}
