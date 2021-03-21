using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models.Pages
{
    public class DepartmentPageModel
    {
        public DepartmentModel DepartmentModel { get; set; }
        public IList<DepartmentModel> DepartmentModels { get; set; }
        public MessageModel MsgCmtModel { get; set; }

        //public IList<MessageModel> MsgCmtModels { get; set; }

        public DepartmentPageModel()
        {
            DepartmentModels = new List<DepartmentModel>();
            MsgCmtModel = new MessageModel();
        }
    }
}
