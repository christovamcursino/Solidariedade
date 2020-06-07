using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.DTO;
using Solidariedade.Application.Interfaces;
using Solidariedade.Application.Interfaces.Mappers;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.MVC.Models;

namespace Solidariedade.MVC.Controllers
{
    public class DonatorController : CustomBaseController
    {
        private readonly IDonatorPersonApp _donatorPersonApp;
        private readonly IDonatorMapper _donatorMapper;
        private readonly IRequestedProductApp _requestedProductApp;
        private readonly IDonationApp _donationApp;

        public DonatorController(ILogger<HomeController> logger, ISessionApp sessionApp, IDonatorPersonApp donatorPersonApp, IDonatorMapper donatorMapper, IRequestedProductApp requestedProductApp, IDonationApp donationApp) : base(logger, sessionApp)
        {
            _donatorPersonApp = donatorPersonApp;
            _donatorMapper = donatorMapper;
            _requestedProductApp = requestedProductApp;
            _donationApp = donationApp;
        }

        // GET: DonatorController
        public ActionResult Index()
        {
            DonatorDTO dto = _donatorMapper.DonatorToDonatorDTO((DonatorPerson)_sessionApp.GetLoggedPerson(),
                _requestedProductApp.GetRequestedProductsByState(_sessionApp.GetLoggedPerson().State.UF));
            return View(dto);
        }

        // GET: DonatorController/AddDonation/RequestedID
        public ActionResult AddDonation(Guid id)
        {
            RequestedProduct req = _requestedProductApp.GetRequestedProduct(id);
            DonationProductItemViewModel donation = new DonationProductItemViewModel {
                IdDonee = req.DoneePerson.Id,
                RequestedProduct = req
            };            
            return View(donation);
        }

        // POST: DonatorController/AddDonation
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddDonation(DonationProductItemViewModel donationProductItemViewModel)
        {
            if (ModelState.IsValid)
            {
                Donation donation = new Donation
                {
                    DonatorPerson = (DonatorPerson)_sessionApp.GetLoggedPerson(),
                    DoneePerson = new DoneePerson { Id = donationProductItemViewModel.IdDonee }
                };
                DonationRequestedProductDTO dto = new DonationRequestedProductDTO{
                    Donation = donation,
                    RequestedProducts = new List<RequestedProduct> { donationProductItemViewModel.RequestedProduct }
                };

                _donationApp.AddDonation(dto);
                return RedirectToAction(nameof(Index));
            }
            //Erro de validacao
            return View(donationProductItemViewModel);
        }
    }
}
