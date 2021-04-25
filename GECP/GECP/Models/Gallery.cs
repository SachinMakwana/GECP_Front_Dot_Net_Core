using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models
{
    public class GalleryModel : IndividualImage
    {
        public IList<CategoryClass> categoryClass { get; set; }

        public IList<IndividualImage> data { get; set; }
    }
    public class CategoryClass
    {
        public string category { get; set; }
        public string categoryClass { get; set; }
    }

    public class IndividualImage
    {
        public string _id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public string PageId { get; set; }
        public string categoryClass { get; set; }
    }
}
