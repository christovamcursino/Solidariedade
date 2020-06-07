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
    public class RequestedProductController : Controller
    {
        private readonly IRequestedProductApp _requestedProductApp;
        private readonly ISessionApp _sessionApp;

        public RequestedProductController(IRequestedProductApp requestedProductApp, ISessionApp sessionApp)
        {
            _requestedProductApp = requestedProductApp;
            _sessionApp = sessionApp;
        }
        // GET: RequestedProductController
        public ActionResult Index()
        {
            return View(_requestedProductApp.GetRequestedProductsOfPerson( (DoneePerson) _sessionApp.GetLoggedPerson()));
        }

        // GET: RequestedProductController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RequestedProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RequestedProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RequestedProduct requestedProduct)
        {
            if (ModelState.IsValid)
            {
                requestedProduct.DoneePerson = (DoneePerson) _sessionApp.GetLoggedPerson();
                _requestedProductApp.AddRequestedProduct(requestedProduct);
                return RedirectToAction(nameof(Index));
            }
            return View(requestedProduct);
        }
    }
}
