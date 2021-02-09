using GECP.Models;
using GECP.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GECP.Repository
{
    public interface IAboutUs
    {

        public Task<AboutUsPageModel> getAboutUsPageDetail();
    }

}
