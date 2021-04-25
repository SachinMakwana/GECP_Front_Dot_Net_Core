using System;
using GECP.Models.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Repository
{
    interface IGallery
    {
        public Task<GalleryPageModel> getGalleryPageDetail();

    }
}
