using Solidariedade.Domain.Entities.Donee;

namespace Solidariedade.Application.DTO
{
    public class RequestedProductDTO
    {
        public PersonDTO Donee { get; set; }
        public RequestedProduct RequestedProduct { get; set; }
    }
}
