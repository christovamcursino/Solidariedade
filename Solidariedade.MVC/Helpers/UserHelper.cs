using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Solidariedade.MVC.Helpers
{
    public static class UserHelper
    {
        public static string ExtractEmail(ClaimsPrincipal user)
        {
            return user.FindFirst("email").Value;
        }
    }
}
