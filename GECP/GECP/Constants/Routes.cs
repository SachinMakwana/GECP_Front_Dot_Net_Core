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

        }
    }
}
