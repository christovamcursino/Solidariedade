using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.DTO;
using Solidariedade.Application.Implementations.Facades;
using Solidariedade.Application.Interfaces;
using Solidariedade.Application.Interfaces.Facades;
using System;

namespace Solidariedade.MVC.Controllers
{
    public class PersonController : CustomBaseController
    {
        private readonly IPersonFacade _personFacade;

        public PersonController(ILogger<HomeController> logger, ISessionApp sessionApp, IPersonFacade personFacade) : base(logger, sessionApp)
        {
            _personFacade = personFacade;
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            PersonDTO dto = new PersonDTO();
            dto.Email = _sessionApp.GetEmail();
            return View(dto);
        }

        // POST: PersonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonDTO person)
        {
            if (ModelState.IsValid)
            {
                _personFacade.CreatePerson(person);
                return RedirectToAction("Index", "Home");
            }
            return View(person);
        }

    }
}
