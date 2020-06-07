using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.DTO
{
    public class DonatorDTO
    {
        public IEnumerable<DonationDTO> Donations { get; set; }
        public IEnumerable<RequestedProductDTO> RequestedProducts { get; set; }
    }
}
