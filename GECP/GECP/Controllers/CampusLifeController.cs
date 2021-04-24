using GECP.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Controllers
{
    public class CampusLifeController : Controller
    {
        private readonly ILogger<DepartmentController> _logger;
        private IGallery _gallery;

        public CampusLifeController(ILogger<DepartmentController> logger)
        {
            _logger = logger;
            _gallery = new Gallery();
        }

        public IActionResult Gallery()
        {
            var obj = _gallery.getGalleryPageDetail();
            return View(obj);
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
