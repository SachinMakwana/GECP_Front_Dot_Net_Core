using System;
using GECP.Models.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Repository
{
    interface IDepartment
    {
        public Task<DepartmentPageModel> getDepartmentPageDetail(int deptCode);

    }
}
