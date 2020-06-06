using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solidariedade.Application.Interfaces;
using Solidariedade.Domain.Entities;

namespace Solidariedade.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductApp _productApp;

        public ProductController(IProductApp productApp)
        {
            _productApp = productApp;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            return View(_productApp.GetAllProducts());
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productApp.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
    }
}
