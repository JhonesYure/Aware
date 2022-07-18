using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace Aware.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("user")))
            {
                context.HttpContext.Response.Redirect("/Home/Login");
            }
        }
    }
}