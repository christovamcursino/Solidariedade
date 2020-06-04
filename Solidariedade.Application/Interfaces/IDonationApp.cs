using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Application.Interfaces
{
    public interface IDonationApp
    {
        Donation AddDonation(Donation donation);
        IEnumerable<Donation> GetAllDonations();
    }
}
