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
    public class AboutUs : Common, IAboutUs
    {
        
        public async Task<IList<AboutUsPageModel>> getAboutUsPageDetail()
        { 
            var http = HttpClientFactory.Create();
            var id = (int)Pages.AboutUs;

            HttpResponseMessage httpResponseMessage = await http.GetAsync(AboutRoutes.GetMessageOFCommitte + "?PageId=" + (int)Pages.AboutUs);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            MessageModel items = JsonConvert.DeserializeObject<MessageModel>(mycontent);

            AboutUsPageModel aboutUsPageModel = new AboutUsPageModel();
            aboutUsPageModel.MsgCmtModels.Add(items);

            return (IList<AboutUsPageModel>)aboutUsPageModel;

            /*List<AboutUsModel> listuser = new List<AboutUsModel>();
            AboutUsModel users;
            AboutUsPageModel aboutUsPageModel = new AboutUsPageModel();

            //HttpResponseMessage httpResponseMessage = http.GetAsync(AbouteRoutes.GetDetails);

            

            string mycontent = content.ReadAsStringAsync();
            AboutUsModel[] items = JsonConvert.DeserializeObject<AboutUsModel[]>(mycontent);

            foreach (var val in items)
            {
                //listuser.Add(val);
                aboutUsPageModel.AboutUsModels.Add(val);
            }
            //var data = await  http.GetStringAsync(AbouteRoutes.GetDetails);
            */

            //return View(listuser);
            //return View(aboutUsPageModel);
        }
    }
}
