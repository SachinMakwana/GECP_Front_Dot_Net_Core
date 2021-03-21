﻿using GECP.Models;
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
    public class Department : Common,IDepartment
    {
        public async Task<DepartmentPageModel> getDepartmentPageDetail(int deptCode,int pageId)
        {
            var http = HttpClientFactory.Create();

            //Department Details
            HttpResponseMessage httpResponseMessage = await http.GetAsync(DepartmentRoutes.GetDepartmentByCode+ "?code=" + deptCode);

            var content = httpResponseMessage.Content;
            string mycontent = await content.ReadAsStringAsync();
            DepartmentModel items = JsonConvert.DeserializeObject<DepartmentModel>(mycontent);

            DepartmentPageModel departmentPageModel = new DepartmentPageModel();
            departmentPageModel.DepartmentModel = items;

            //Message Of HOD
            HttpResponseMessage httpResponsePeople = await http.GetAsync(CommonRoutes.GetMessageOFCommitte+ "?PageId=" + pageId);

            var messageContent = httpResponsePeople.Content;
            string myPeopleContent = await messageContent.ReadAsStringAsync();
            MessageModel item = JsonConvert.DeserializeObject<MessageModel>(myPeopleContent);

            departmentPageModel.MsgCmtModel = item;

            return departmentPageModel;
        }
    }
}