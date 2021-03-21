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
            AboutUsPageModel aboutUsPageModel = new AboutUsPageModel();

            //Message Of Committee
            HttpResponseMessage httpResponseAbout = await http.GetAsync(AboutRoutes.GetAboutUsDetails);

            var contentAbout = httpResponseAbout.Content;
            string mycontentAbout = await contentAbout.ReadAsStringAsync();
            AboutUsModel itemAbout = JsonConvert.DeserializeObject<AboutUsModel>(mycontentAbout);

            aboutUsPageModel.AboutUsModel = itemAbout;

            //Message Of Committee
            HttpResponseMessage httpResponseMessage = await http.GetAsync(AboutRoutes.GetMessageOFCommitte + "?PageId=" + itemAbout._id);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            MessageModel items = JsonConvert.DeserializeObject<MessageModel>(mycontent);

            aboutUsPageModel.MsgCmtModel = items;

            //Feedback Of People
            HttpResponseMessage httpResponsePeople = await http.GetAsync(AboutRoutes.GetAlumniDetails + "?PageId=" + itemAbout._id);

            var peopleContent = httpResponsePeople.Content;
            string myPeopleContent = await peopleContent.ReadAsStringAsync();
            List<Alumni> peopleitems = JsonConvert.DeserializeObject<List<Alumni>>(myPeopleContent);

            aboutUsPageModel.Alumnis = peopleitems;

            //Vission Mission
            HttpResponseMessage httpResponseVM = await http.GetAsync(CommonRoutes.GetVissionMission + "?PageId=" + itemAbout._id);
            var VMContent = httpResponseVM.Content;
            string myVMContent = await VMContent.ReadAsStringAsync();
            VissionMission item2 = JsonConvert.DeserializeObject<VissionMission>(myVMContent);

            aboutUsPageModel.VissionMission = item2;

            return aboutUsPageModel;
        }
    }
}
