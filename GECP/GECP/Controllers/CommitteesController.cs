using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Controllers
{
    public class CommitteesController : Controller
    {
        public IActionResult WomenCell()
        {
            return View();
        }

        public IActionResult SsipCell()
        {
            return View();
        }

        public IActionResult NssCell()
        {
            return View();
        }

        public IActionResult AntiRaggingCell()
        {
            return View();
        }

        public IActionResult GrievenceCell()
        {
            return View();
        }

        public IActionResult PlacementCell()
        {
            return View();
        }
        

    }
}
