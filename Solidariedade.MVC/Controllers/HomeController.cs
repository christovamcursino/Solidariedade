using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.Interfaces;
using Solidariedade.MVC.Helpers;
using Solidariedade.MVC.Models;

namespace Solidariedade.MVC.Controllers
{
    public class HomeController : CustomBaseController
    {
        public HomeController(ILogger<HomeController> logger, ISessionApp sessionApp) : base(logger, sessionApp)
        {
        }

        public IActionResult Index()
        {
            if (_sessionApp.IsNewUser())
            {
                return RedirectToAction("Create", "Person");
            }

            if (_sessionApp.IsCurrentUserADonator())
            {
                return RedirectToAction("Index", "Donator");
            }

            if (_sessionApp.IsCurrentUserADonee())
            {
                return RedirectToAction("Index", "Donee");
            }

            return View();
        }

        public IActionResult Logout()
        {
            return new SignOutResult(new[] { "oidc", "cookie" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
