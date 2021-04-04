using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Models.Pages
{
    public class BasicCellDetailsPageModel
    {
        public BasicCellDetailsModel BasicCellDetailsModel { get; set; }
        public VissionMission vissionMissionModel { get; set; }
        public MessageModel MsgCmtModel { get; set; }

        public BasicCellDetailsPageModel()
        {
            vissionMissionModel = new VissionMission();
            MsgCmtModel = new MessageModel();

        }

    }
}
