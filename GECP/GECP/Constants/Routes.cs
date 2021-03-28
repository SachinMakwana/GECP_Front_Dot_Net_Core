using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Constants
{
    public class Routes
    {
        const string BaseURL = "http://localhost:3000";
        public class AboutRoutes
        {
            public static string GetAboutUsDetails => BaseURL + "/college";

            public static string GetMessageOFCommitte => BaseURL + "/getMessage";

            public static string GetAlumniDetails => BaseURL + "/getAlumnis";

        }

        public class CommonRoutes
        {
            public static string GetMessageOFCommitte => BaseURL + "/getMessage";
            public static string GetVissionMission => BaseURL + "/getVissionMission";
            public static string GetAlumniDetails => BaseURL + "/getAlumnis";
            public static string GetFacultyDetails => BaseURL + "/getFacultyDetails";
        }

        public class DepartmentRoutes
        {
            public static string GetDepartmentByCode => BaseURL + "/departmentByCode";
        }
    }
}
