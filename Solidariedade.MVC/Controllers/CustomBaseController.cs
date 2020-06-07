using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Solidariedade.Application.Interfaces;
using Solidariedade.MVC.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solidariedade.MVC.Controllers
{
    [Authorize]
    public abstract class CustomBaseController : Controller
    {
        protected readonly ILogger<HomeController> _logger;

        protected readonly ISessionApp _sessionApp;

        public CustomBaseController(ILogger<HomeController> logger, ISessionApp sessionApp)
        {
            _logger = logger;
            _sessionApp = sessionApp;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            _sessionApp.SetSessionUser(UserHelper.ExtractEmail(User));
        }
    }
}
