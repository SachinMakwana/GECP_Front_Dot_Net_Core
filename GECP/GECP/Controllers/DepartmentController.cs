using GECP.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GECP.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ILogger<DepartmentController> _logger;
        private IDepartment _department;

        public DepartmentController(ILogger<DepartmentController> logger)
        {
            _logger = logger;
            _department = new Department();
        }

        public IActionResult Computer()
        {
            var obj = _department.getDepartmentPageDetail((int)Common.DEPTCODES.CSE);
            return View(obj);
        }

        public IActionResult Ec()
        {
            var obj = _department.getDepartmentPageDetail((int)Common.DEPTCODES.ECE);
            return View(obj);
        }

        public IActionResult Electrical()
        {
            var obj = _department.getDepartmentPageDetail((int)Common.DEPTCODES.ELE);
            return View(obj);
        }

        public IActionResult Civil()
        {
            return View();
        }

        public IActionResult Mechanical()
        {
            return View();
        }

        public IActionResult Library()
        {
            return View();
        }

        public IActionResult General()
        {
            return View();
        }

        public IActionResult Teqip()
        {
            return View();
        }
    }
}
