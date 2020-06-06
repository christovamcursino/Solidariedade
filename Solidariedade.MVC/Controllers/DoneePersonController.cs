using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities.Donee;

namespace Solidariedade.MVC.Controllers
{
    public class DoneePersonController : Controller
    {
        private readonly IDoneePersonApp _doneePersonApp;

        public DoneePersonController(IDoneePersonApp doneePersonApp)
        {
            _doneePersonApp = doneePersonApp;
        }

        // GET: DoneePersonController
        public ActionResult Index()
        {
            //caso o donatario ja esteja cadastrado, vai para o menu inicial
            return View();
        }

        // GET: DoneePersonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoneePersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DoneePerson doneePerson)
        {
            if (ModelState.IsValid)
            {
                _doneePersonApp.AddDoneePerson(doneePerson);
                return RedirectToAction(nameof(Index));
            }
            //Erro de validacao
            return View();
        }
    }
}
