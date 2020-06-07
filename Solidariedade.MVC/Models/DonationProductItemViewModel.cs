using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidariedade.MVC.Models
{
    public class DonationProductItemViewModel
    {
        public Guid IdDonee { get; set; }
        public RequestedProduct RequestedProduct { get; set; }
    }
}
