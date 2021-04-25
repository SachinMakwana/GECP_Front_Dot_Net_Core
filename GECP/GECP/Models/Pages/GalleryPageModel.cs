using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models.Pages
{
    public class GalleryPageModel
    {
        public GalleryModel ImageResModel { get; set; }
        public IList<IndividualImage> GalleryModels { get; set; }

        public IList<CategoryClass> CategoryModels { get; set; }

        public GalleryPageModel()
        {
            ImageResModel = new GalleryModel();
            GalleryModels = new List<IndividualImage>();
            CategoryModels = new List<CategoryClass>();

        }
    }
}
