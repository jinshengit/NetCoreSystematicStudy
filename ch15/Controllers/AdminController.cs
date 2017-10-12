using ch15.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ch15.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index() => View("Result", new Result
        {
            Controller = nameof(AdminController),
            Action = nameof(Index)
        });
    }
}
