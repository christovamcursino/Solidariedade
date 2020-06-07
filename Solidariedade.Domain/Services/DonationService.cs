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
        private IRequestedProductService _requestedProductService;
        private IProductService _productService;
        private IDoneePersonService _doneePersonService;
        private IDonatorPersonService _donatorPersonService;

        public DonationService(IUnitOfWork uow, IDonationRepository donationRepository, IRequestedProductService requestedProductService, IProductService productService, IDoneePersonService doneePersonService, IDonatorPersonService donatorPersonService)
        {
            _uow = uow;
            _donationRepository = donationRepository;
            _requestedProductService = requestedProductService;
            _productService = productService;
            _doneePersonService = doneePersonService;
            _donatorPersonService = donatorPersonService;
        }

        //INCLUIR A VALIDACAO

        public Donation AddDonation(Donation donation)
        {
            _uow.BeginTransaction();
            prepare(donation);

            foreach (DonationItem item in donation.Items)
            {
                if (item.Product.Id == null || item.Product.Id.Equals(Guid.Empty))
                {
                    item.Product.Id = Guid.NewGuid();
                }
                else
                {
                    item.Product = _productService.GetProductByID(item.Product.Id);
                }
            }

            Donation result = _donationRepository.Insert(donation);
            _uow.Commit();
            return result;
        }

        private void prepare(Donation donation)
        {
            donation.Id = Guid.NewGuid();
            donation.DonatorPerson = _donatorPersonService.GetDonatorPersonByID(donation.DonatorPerson.Id);
            donation.DoneePerson = _doneePersonService.GetDoneePersonByID(donation.DoneePerson.Id);
            donation.DonationDate = DateTime.Now;
        }

        public Donation AddDonation(Donation donation, IEnumerable<RequestedProduct> requestedProducts)
        {
            _uow.BeginTransaction();
            prepare(donation);

            List<DonationItem> donationItems = new List<DonationItem>();

            foreach (RequestedProduct req in requestedProducts ) {
                RequestedProduct dbRequestedProduct = _requestedProductService.GetRequestedProduct(req.Id);
                DonationItem i = new DonationItem();
                i.Id = Guid.NewGuid();
                i.Amount = req.Amount;
                i.Product = dbRequestedProduct.Product;
                donationItems.Add(i);
            }
            donation.Items = donationItems;

            Donation result = _donationRepository.Insert(donation);
            _requestedProductService.CheckOutRequestedProducts(requestedProducts);

            _uow.Commit();
            return result;
        }

        public IEnumerable<Donation> GetAllDonations()
        {
            return _donationRepository.GetAll();
        }
    }
}
