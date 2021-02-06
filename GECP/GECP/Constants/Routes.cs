using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Constants
{
    public class Routes
    {
        const string BaseURL = "http://localhost:3000";
        public class AbouteRoutes
        {
            public static string GetDetails => BaseURL + "/college";
        }
    }
}
