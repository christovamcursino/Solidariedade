using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donator;
using Solidariedade.Domain.Entities.Donee;

namespace Solidariedade.MVC.Controllers
{
    public class DonationController : Controller
    {
        private readonly IDonationApp _donationApp;
        private readonly ISessionApp _sessionApp;

        public DonationController(IDonationApp donationApp, ISessionApp sessionApp)
        {
            _donationApp = donationApp;
            _sessionApp = sessionApp;
        }

        // GET: DonationController
        public ActionResult Index()
        {
            return View(_donationApp.GetAllDonations());
        }

        // GET: DonationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DonationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Donation donation)
        {
            if (ModelState.IsValid)
            {
                donation.DonatorPerson = (DonatorPerson)_sessionApp.GetLoggedPerson();
                _donationApp.AddDonation(donation);
                //doneeperson tem que vir do objeto escolhido
                return RedirectToAction(nameof(Index));
            }
            return View(donation);
        }
    }
}
