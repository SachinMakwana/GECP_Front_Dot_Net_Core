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
            var obj = _department.getDepartmentPageDetail((int)Common.DEPTCODES.CIVIL);
            return View(obj);
        }

        public IActionResult Mechanical()
        {
            var obj = _department.getDepartmentPageDetail((int)Common.DEPTCODES.MECH);
            return View(obj);
        }

        public IActionResult Library()
        {
            var obj = _department.getDepartmentPageDetail((int)Common.DEPTCODES.LIBRARY);
            return View(obj);
        }

        public IActionResult General()
        {
            var obj = _department.getDepartmentPageDetail((int)Common.DEPTCODES.ADMIN);
            return View(obj);
        }
        public IActionResult Teqip()
        {
            var obj = _department.getDepartmentPageDetail((int)Common.DEPTCODES.TEQ);
            return View(obj);
        }
    }
}
