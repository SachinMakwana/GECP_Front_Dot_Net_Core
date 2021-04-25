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
        public GalleryModel ImageResModel { get; set; }
        public IList<IndividualImage> GalleryModels { get; set; }
        public IList<CategoryClass> CategoryModels { get; set; }
        public BasicCellDetailsPageModel()
        {
            vissionMissionModel = new VissionMission();
            MsgCmtModel = new MessageModel();
            ImageResModel = new GalleryModel();
            GalleryModels = new List<IndividualImage>();
            CategoryModels = new List<CategoryClass>();
        }

    }
}
