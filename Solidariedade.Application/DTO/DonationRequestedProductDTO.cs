using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System.Collections.Generic;

namespace Solidariedade.Application.DTO
{
    public class DonationRequestedProductDTO
    {
        public Donation Donation { get; set; }
        public IEnumerable<RequestedProduct> RequestedProducts { get; set; }
    }
}
