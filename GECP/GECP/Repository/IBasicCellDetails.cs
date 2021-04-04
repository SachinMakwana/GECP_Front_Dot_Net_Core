using GECP.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Repository
{
    interface IBasicCellDetails
    {
        public Task<BasicCellDetailsPageModel> getSSIPCellDetailsPageDetail();
        public Task<BasicCellDetailsPageModel> getWomenCellDetailsPageDetail();
        public Task<BasicCellDetailsPageModel> getPlacementCellDetailsPageDetail();
        public Task<BasicCellDetailsPageModel> getNssCellDetailsPageDetail();
        public Task<BasicCellDetailsPageModel> getGrievenceCellDetailsPageDetail();
        public Task<BasicCellDetailsPageModel> getAntiRaggingCellDetailsPageDetail();

    }
}
