using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models.Pages
{
    public class FacultyPageModel
    {
        public FacultyDetailsModel FacultyDetailsModel { get; set; }
        public IList<FacultyDetailsModel> FacultyDetailsModels { get; set; }

        public FacultyPageModel()
        {
            FacultyDetailsModels = new List<FacultyDetailsModel>();
        }
    }
}
