using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Solidariedade.Application.Implementations
{
    public class DonationApp : IDonationApp
    {
        private IDonationService _donationService;

        public DonationApp(IDonationService donationService)
        {
            _donationService = donationService;
        }

        public Donation AddDonation(Donation donation)
        {
            return _donationService.AddDonation(donation);
        }

        public IEnumerable<Donation> GetAllDonations()
        {
            return _donationService.GetAllDonations();
        }
    }
}
