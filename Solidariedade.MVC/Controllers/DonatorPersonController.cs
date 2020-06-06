using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donator;

namespace Solidariedade.MVC.Controllers
{
    public class DonatorPersonController : Controller
    {
        private readonly IDonatorPersonApp _donatorPersonApp;

        public DonatorPersonController(IDonatorPersonApp donatorPersonApp)
        {
            _donatorPersonApp = donatorPersonApp;
        }


        // GET: DonatorPersonController
        public ActionResult Index()
        {
            //caso o doador ja esteja cadastrado, vai para o menu inicial
            return View();
        }

        // GET: DonatorPersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonatorPersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DonatorPerson donatorPerson)
        {
            if (ModelState.IsValid)
            {
                _donatorPersonApp.AddDonatorPerson(donatorPerson);
                return RedirectToAction(nameof(Index));
            }
            //Na verdade tem que pra home
            return View(donatorPerson);
        }

    }
}
