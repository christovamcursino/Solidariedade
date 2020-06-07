using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.DTO
{
    public class DoneeDTO
    {
        public IEnumerable<DonationDTO> donations { get; set; }
        public IEnumerable<RequestedProduct> requestedProducts { get; set; }

    }
}
