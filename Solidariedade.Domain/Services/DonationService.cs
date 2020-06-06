using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
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
        private IRequestedProductService __requestedProductService;

        public DonationService(IUnitOfWork uow, IDonationRepository donationRepository, IRequestedProductService requestedProductService)
        {
            _uow = uow;
            _donationRepository = donationRepository;
            __requestedProductService = requestedProductService;
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

        public Donation AddDonation(Donation donation, IEnumerable<RequestedProduct> requestedProducts)
        {
            _uow.BeginTransaction();
            donation.Id = Guid.NewGuid();

            List<DonationItem> donationItems = new List<DonationItem>();

            foreach (RequestedProduct req in requestedProducts ) {
                DonationItem i = new DonationItem();
                i.Id = Guid.NewGuid();
                i.Amount = req.Amount;
                i.Product = req.Product;
                donationItems.Add(i);
            }
            donation.Items = donationItems;

            Donation result = _donationRepository.Insert(donation);
            __requestedProductService.CheckOutRequestedProducts(requestedProducts);

            _uow.Commit();
            return result;
        }

        public IEnumerable<Donation> GetAllDonations()
        {
            return _donationRepository.GetAll();
        }
    }
}
