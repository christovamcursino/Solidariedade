using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Interfaces.Repositories;
using Solidariedade.Domain.Interfaces.Services;
using Solidariedade.Domain.Interfaces.UoW;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solidariedade.Domain.Services
{
    public class DonationService : IDonationService
    {
        private IUnitOfWork _uow;
        private IDonationRepository _donationRepository;

        public DonationService(IUnitOfWork uow, IDonationRepository donationRepository)
        {
            _uow = uow;
            _donationRepository = donationRepository;
        }

        //INCLUIR A VALIDACAO

        public Donation AddDonation(Donation donation)
        {
            _uow.BeginTransaction();
            donation.Id = Guid.NewGuid();
            Donation result = _donationRepository.Insert(donation);
            _uow.Commit();

            return result;
        }

        public IEnumerable<Donation> GetAllDonations()
        {
            return _donationRepository.GetAll();
        }
    }
}
