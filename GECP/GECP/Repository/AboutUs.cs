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
    public class AboutUs : Common,IAboutUs
    {
        
        public async Task<AboutUsPageModel> getAboutUsPageDetail()
        { 
            var http = HttpClientFactory.Create();
            int id = (int)Pages.AboutUs;

            //Message Of Committee
            HttpResponseMessage httpResponseMessage = await http.GetAsync(AboutRoutes.GetMessageOFCommitte + "?PageId=" + id);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            MessageModel items = JsonConvert.DeserializeObject<MessageModel>(mycontent);

            AboutUsPageModel aboutUsPageModel = new AboutUsPageModel();
            aboutUsPageModel.MsgCmtModel = items;

            //Feedback Of People
            HttpResponseMessage httpResponsePeople = await http.GetAsync(AboutRoutes.GetAlumniDetails + "?PageId=" + id);

            var peopleContent = httpResponsePeople.Content;
            string myPeopleContent = await peopleContent.ReadAsStringAsync();
            List<Alumni> peopleitems = JsonConvert.DeserializeObject<List<Alumni>>(myPeopleContent);

            aboutUsPageModel.Alumnis = peopleitems;

            return aboutUsPageModel;
        }
    }
}
