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
    public class CommitteesController : Controller
    {
        private readonly ILogger<CommitteesController> _logger;
        private IBasicCellDetails _basicCellDetails;

        public CommitteesController(ILogger<CommitteesController> logger)
        {
            _logger = logger;
            _basicCellDetails = new BasicCellDetails();
        }
        public IActionResult WomenCell()
        {
            var obj = _basicCellDetails.getWomenCellDetailsPageDetail();
            return View(obj);
        }

        public IActionResult SsipCell()

        {
            var obj = _basicCellDetails.getSSIPCellDetailsPageDetail();
            return View(obj);
        }


        public IActionResult NssCell()
        {
            var obj = _basicCellDetails.getNssCellDetailsPageDetail();
            return View(obj);
        }

        public IActionResult AntiRaggingCell()
        {
            var obj = _basicCellDetails.getAntiRaggingCellDetailsPageDetail();
            return View(obj);
        }

        public IActionResult GrievenceCell()
        {
            var obj = _basicCellDetails.getGrievenceCellDetailsPageDetail();
            return View(obj);
        }

        public IActionResult PlacementCell()
        {
            var obj = _basicCellDetails.getPlacementCellDetailsPageDetail();
            return View(obj);
        }


    }
}
