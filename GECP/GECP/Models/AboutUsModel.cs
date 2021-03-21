using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models
{
    public class AboutUsModel
    {
        public string _id { get; set; }
        public string about_image { get; set; }
        public string about_description { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
