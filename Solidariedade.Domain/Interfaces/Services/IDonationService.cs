using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Interfaces.Services
{
    public interface IDonationService
    {
        //Adiciona uma doacao avulsa
        Donation AddDonation(Donation donation);
        //Adiciona uma doacao de itens solicitados
        Donation AddDonation(Donation donation, IEnumerable<RequestedProduct> requestedProducts);
        IEnumerable<Donation> GetAllDonations();
    }
}
