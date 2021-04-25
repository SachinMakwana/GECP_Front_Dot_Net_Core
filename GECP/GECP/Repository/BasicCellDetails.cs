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
    public class BasicCellDetails : Common, IBasicCellDetails
    {
        public async Task<BasicCellDetailsPageModel> getSSIPCellDetailsPageDetail()
        {
            BasicCellDetailsPageModel basicCellDetailsPageModel = new BasicCellDetailsPageModel();

            //basic details
            basicCellDetailsPageModel.BasicCellDetailsModel = getBasicCellDetails(CommitteesRoutes.GetSsipCellDetails).Result;
            //vission mission
            basicCellDetailsPageModel.vissionMissionModel = getVissionMissionDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Head Message
            basicCellDetailsPageModel.MsgCmtModel = getMessageDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            return basicCellDetailsPageModel;
        }

        public async Task<BasicCellDetailsPageModel> getWomenCellDetailsPageDetail()
        {
            BasicCellDetailsPageModel basicCellDetailsPageModel = new BasicCellDetailsPageModel();

            //basic details
            basicCellDetailsPageModel.BasicCellDetailsModel = getBasicCellDetails(CommitteesRoutes.GetWomenCellDetails).Result;
            //vission mission
            basicCellDetailsPageModel.vissionMissionModel = getVissionMissionDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Head Message
            basicCellDetailsPageModel.MsgCmtModel = getMessageDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Get Images
            basicCellDetailsPageModel.ImageResModel = getImageByPageId(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            basicCellDetailsPageModel.CategoryModels = basicCellDetailsPageModel.ImageResModel.categoryClass;
            basicCellDetailsPageModel.GalleryModels = basicCellDetailsPageModel.ImageResModel.data;
            return basicCellDetailsPageModel;
        }

        public async Task<BasicCellDetailsPageModel> getPlacementCellDetailsPageDetail()
        {
            BasicCellDetailsPageModel basicCellDetailsPageModel = new BasicCellDetailsPageModel();

            //basic details
            basicCellDetailsPageModel.BasicCellDetailsModel = getBasicCellDetails(CommitteesRoutes.GetPlacementCellDetails).Result;
            //vission mission
            basicCellDetailsPageModel.vissionMissionModel = getVissionMissionDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Head Message
            basicCellDetailsPageModel.MsgCmtModel = getMessageDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            return basicCellDetailsPageModel;
        }

        public async Task<BasicCellDetailsPageModel> getNssCellDetailsPageDetail()
        {
            BasicCellDetailsPageModel basicCellDetailsPageModel = new BasicCellDetailsPageModel();

            //basic details
            basicCellDetailsPageModel.BasicCellDetailsModel = getBasicCellDetails(CommitteesRoutes.GetNssCellDetails).Result;
            //vission mission
            basicCellDetailsPageModel.vissionMissionModel = getVissionMissionDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Head Message
            basicCellDetailsPageModel.MsgCmtModel = getMessageDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Get Images
            basicCellDetailsPageModel.ImageResModel = getImageByPageId(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            basicCellDetailsPageModel.CategoryModels = basicCellDetailsPageModel.ImageResModel.categoryClass;
            basicCellDetailsPageModel.GalleryModels = basicCellDetailsPageModel.ImageResModel.data;
            return basicCellDetailsPageModel;
        }

        public async Task<BasicCellDetailsPageModel> getGrievenceCellDetailsPageDetail()
        {
            BasicCellDetailsPageModel basicCellDetailsPageModel = new BasicCellDetailsPageModel();

            //basic details
            basicCellDetailsPageModel.BasicCellDetailsModel = getBasicCellDetails(CommitteesRoutes.GetGrievenceCellDetails).Result;
            //vission mission
            basicCellDetailsPageModel.vissionMissionModel = getVissionMissionDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Head Message
            basicCellDetailsPageModel.MsgCmtModel = getMessageDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            return basicCellDetailsPageModel;
        }

        public async Task<BasicCellDetailsPageModel> getAntiRaggingCellDetailsPageDetail()
        {
            BasicCellDetailsPageModel basicCellDetailsPageModel = new BasicCellDetailsPageModel();

            //basic details
            basicCellDetailsPageModel.BasicCellDetailsModel = getBasicCellDetails(CommitteesRoutes.GetAntiRaggingCellDetails).Result;
            //vission mission
            basicCellDetailsPageModel.vissionMissionModel = getVissionMissionDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Head Message
            basicCellDetailsPageModel.MsgCmtModel = getMessageDetails(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            //Get Images
            basicCellDetailsPageModel.ImageResModel = getImageByPageId(basicCellDetailsPageModel.BasicCellDetailsModel._id).Result;
            basicCellDetailsPageModel.CategoryModels = basicCellDetailsPageModel.ImageResModel.categoryClass;
            basicCellDetailsPageModel.GalleryModels = basicCellDetailsPageModel.ImageResModel.data;
            return basicCellDetailsPageModel;
        }


        private async Task<BasicCellDetailsModel> getBasicCellDetails(string url)
        {
            var http = HttpClientFactory.Create();

            HttpResponseMessage httpResponseMessage = await http.GetAsync(url);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            BasicCellDetailsModel item = JsonConvert.DeserializeObject<BasicCellDetailsModel>(mycontent);
            return item;
        }

        private async Task<VissionMission> getVissionMissionDetails(string pageId)
        {
            var http = HttpClientFactory.Create();

            HttpResponseMessage httpResponseMessage = await http.GetAsync(CommonRoutes.GetVissionMission + "?PageId=" + pageId);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            VissionMission item = JsonConvert.DeserializeObject<VissionMission>(mycontent);
            return item;
        }

        private async Task<MessageModel> getMessageDetails(string pageId)
        {
            var http = HttpClientFactory.Create();

            HttpResponseMessage httpResponseMessage = await http.GetAsync(AboutRoutes.GetMessageOFCommitte + "?PageId=" + pageId);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            MessageModel item = JsonConvert.DeserializeObject<MessageModel>(mycontent);
            return item;
        }

        private async Task<GalleryModel> getImageByPageId(string pageId)
        {
            var http = HttpClientFactory.Create();

            //Get Images
            HttpResponseMessage httpResponseImage = await http.GetAsync(GalleryRoutes.GetImageByPageIdResponse + "?PageId=" + pageId);

            var contentImages = httpResponseImage.Content;
            string myImageContent = await contentImages.ReadAsStringAsync();
            GalleryModel itemsRes = JsonConvert.DeserializeObject<GalleryModel>(myImageContent);

            return itemsRes;
        }
    }
}
