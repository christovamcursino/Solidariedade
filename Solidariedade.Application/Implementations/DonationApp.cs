using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Interfaces.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Services
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
