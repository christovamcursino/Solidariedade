using Solidariedade.Domain.Entities.Donator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Services
{
    public interface IDonationService
    {
        Donation AddDonation(Donation donation);
    }
}
