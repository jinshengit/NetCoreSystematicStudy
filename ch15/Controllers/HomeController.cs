using ch15.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch15.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() => View("Result", new Result
        {
            Controller = nameof(HomeController),
            Action = nameof(Index)
        });

        public ViewResult CustomVariable(string id)
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable)
            };
            r.Data["id"] = id ?? "<no value>";//RouteData.Values["id"];
            return View("Result", r);
        }
    }
}
