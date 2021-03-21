using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models
{
    public class DepartmentModel
    {
        public string _id { get; set; }
        public int code { get; set; }
        public string name { get; set; }
        public string ShortName { get; set; }
        public string image { get; set; }
        public string about { get; set; }
        public string coverPhoto { get; set; }
        public int Intake { get; set; }
        public int TotalSubject { get; set; }
    }
}
