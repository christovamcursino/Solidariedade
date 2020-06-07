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
using Solidariedade.Domain.Entities.Donee;
using Solidariedade.MVC.Models;

namespace Solidariedade.MVC.Controllers
{
    public class DoneeController : CustomBaseController
    {
        private readonly IDoneeMapper _doneeMapper;
        private readonly IProductApp _productApp;
        private readonly IRequestedProductApp _requestedProductApp;

        public DoneeController(ILogger<HomeController> logger, ISessionApp sessionApp, IDoneeMapper doneeMapper, IProductApp productApp, IRequestedProductApp requestedProductApp) : base(logger, sessionApp)
        {
            _doneeMapper = doneeMapper;
            _productApp = productApp;
            _requestedProductApp = requestedProductApp;
        }

        // GET: DoneeController
        //Tela com doações recebidas e doações solicitadas, com botão de incluir necessidade
        public ActionResult Index()
        {
            DoneeDTO dto = _doneeMapper.DoneeToDoneeDTO((DoneePerson)_sessionApp.GetLoggedPerson());
            return View(dto);
        }

        // GET: DoneeController/Create
        public ActionResult AddRequest()
        {
            AddRequestViewModel model = new AddRequestViewModel
            {
                Products = _productApp.GetAllProducts()
            };
            return View(model);
        }

        // POST: DoneeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddRequest(AddRequestViewModel addRequestViewModel)
        {
            if (ModelState.IsValid)
            {
                addRequestViewModel.RequestedProduct.DoneePerson = (DoneePerson) _sessionApp.GetLoggedPerson();
                _requestedProductApp.AddRequestedProduct(addRequestViewModel.RequestedProduct);
                return RedirectToAction(nameof(Index));
            }
            //Erro de validacao
            return View(addRequestViewModel);
        }
    }
}
