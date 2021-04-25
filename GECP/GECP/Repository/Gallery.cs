using GECP.Models;
using GECP.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static GECP.Constants.Routes;
using GECP.Constants;
using Newtonsoft.Json;

namespace GECP.Repository
{
    public class Gallery : Common, IGallery
    {
        public async Task<GalleryPageModel> getGalleryPageDetail()
        {
            var http = HttpClientFactory.Create();
            GalleryPageModel galleryPageModel = new GalleryPageModel();

            //Get All Gallery Images
            HttpResponseMessage httpResponseMessage = await http.GetAsync(GalleryRoutes.GetGalleryResponse);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            GalleryModel items = JsonConvert.DeserializeObject<GalleryModel>(mycontent);

            galleryPageModel.ImageResModel = items;
            galleryPageModel.CategoryModels = items.categoryClass;
            galleryPageModel.GalleryModels = items.data;
            return galleryPageModel;

        }

    }
}
