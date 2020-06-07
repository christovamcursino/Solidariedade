using Solidariedade.Application.DTO;
using Solidariedade.Domain.Entities.Donator;
using System.Collections.Generic;

namespace Solidariedade.Application.Interfaces
{
    public interface IDonationApp
    {
        Donation AddDonation(Donation donation);
        Donation AddDonation(DonationRequestedProductDTO donationRequestedProductDTO);
        IEnumerable<Donation> GetAllDonations();
    }
}
