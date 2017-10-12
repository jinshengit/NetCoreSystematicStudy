using ch15.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch15.Controllers
{
    public class CustomerController : Controller
    {
        [Route("[controller]/MyAction")] //changing the name of action
        public ViewResult Index() => View("Result", new Result
        {
            Controller = nameof(CustomerController),
            Action = nameof(Index)
        });

        public ViewResult List(string id)
        {
            Result r = new Result
            {
                Controller = nameof(CustomerController),
                Action = nameof(List)
            };

            r.Data["id"] = id ?? "<no value>";
            r.Data["catchall"] = RouteData.Values["catchall"];

            return View("Result", r);
        }

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
