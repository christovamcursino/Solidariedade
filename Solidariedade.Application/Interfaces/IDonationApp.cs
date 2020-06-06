using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces
{
    public interface IDonationApp
    {
        Donation AddDonation(Donation donation);
        Donation AddDonation(Donation donation, IEnumerable<RequestedProduct> requestedProducts);
        IEnumerable<Donation> GetAllDonations();
    }
}
