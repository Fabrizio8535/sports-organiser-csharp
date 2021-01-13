using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP.NETMVCCORE.Models;
using ASP.NETMVCCORE.ViewModels;

namespace ASP.NETMVCCORE.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public IActionResult About()
        {

            return View();
        }
    }
}
