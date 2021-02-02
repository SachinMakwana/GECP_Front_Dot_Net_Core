using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Controllers
{
    public class CampusLifeController : Controller
    {
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Canteen()
        {
            return View();
        }

        public IActionResult CampusMap()
        {
            return View();
        }
    }
}
