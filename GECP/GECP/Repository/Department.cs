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
    public class Department : Common, IDepartment
    {
        public async Task<DepartmentPageModel> getDepartmentPageDetail(int deptCode)
        {
            var http = HttpClientFactory.Create();
            DepartmentPageModel departmentPageModel = new DepartmentPageModel();

            //Department Details
            HttpResponseMessage httpResponseMessage = await http.GetAsync(DepartmentRoutes.GetDepartmentByCode + "?code=" + deptCode);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            DepartmentModel items = JsonConvert.DeserializeObject<DepartmentModel>(mycontent);

            departmentPageModel.DepartmentModel = items;

            //Message Of HOD
            HttpResponseMessage httpResponsePeople = await http.GetAsync(CommonRoutes.GetMessageOFCommitte + "?PageId=" + items._id);

            var messageContent = httpResponsePeople.Content;
            string myPeopleContent = await messageContent.ReadAsStringAsync();
            MessageModel item = JsonConvert.DeserializeObject<MessageModel>(myPeopleContent);

            departmentPageModel.MsgCmtModel = item;

            //Vission Mission
            HttpResponseMessage httpResponseVM = await http.GetAsync(CommonRoutes.GetVissionMission + "?PageId=" + items._id);
            var VMContent = httpResponseVM.Content;
            string myVMContent = await VMContent.ReadAsStringAsync();
            VissionMission item2 = JsonConvert.DeserializeObject<VissionMission>(myVMContent);

            departmentPageModel.VissionMissionModel = item2;

            //Faculty Details
            HttpResponseMessage httpResponseFD = await http.GetAsync(CommonRoutes.GetFacultyDetails + "?deptCode=" + items._id);
            var FDContent = httpResponseFD.Content;
            string myFDContent = await FDContent.ReadAsStringAsync();
            List<FacultyDetailsModel> item3 = JsonConvert.DeserializeObject<List<FacultyDetailsModel>>(myFDContent);

            departmentPageModel.FacultyDetailsModel = item3;

            //Get Images
            HttpResponseMessage httpResponseImage = await http.GetAsync(GalleryRoutes.GetImageByPageIdResponse + "?PageId=" + items._id);

            var contentImages = httpResponseImage.Content;
            string myImageContent = await contentImages.ReadAsStringAsync();
            GalleryModel itemsRes = JsonConvert.DeserializeObject<GalleryModel>(myImageContent);

            departmentPageModel.ImageResModel = itemsRes;
            departmentPageModel.CategoryModels = itemsRes.categoryClass;
            departmentPageModel.GalleryModels = itemsRes.data;
            return departmentPageModel;
        }
    }
}
