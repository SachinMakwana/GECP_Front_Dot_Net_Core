using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models.Pages
{
    public class AboutUsPageModel
    {
        public AboutUsModel AboutUsModel { get; set; }
        public IList<AboutUsModel> AboutUsModels { get; set; }

        public MessageModel MsgCmtModel { get; set; }

        public IList<MessageModel> MsgCmtModels { get; set; }

        public AboutUsPageModel()
        {
            AboutUsModels = new List<AboutUsModel>();
            MsgCmtModels = new List<MessageModel>();
        }
    }
}
