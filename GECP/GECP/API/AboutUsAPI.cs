using GECP.Constants;
using GECP.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace GECP.API
{
    public class AboutUsAPI : Routes
    {
        public async void getAboutUS()
        {
            var http = HttpClientFactory.Create();
            HttpResponseMessage httpResponseMessage = await http.GetAsync(AboutRoutes.GetAboutUsDetails);

            var content = httpResponseMessage.Content;
            
            string mycontent = await content.ReadAsStringAsync();
            AboutUsModel[] items = JsonConvert.DeserializeObject<AboutUsModel[]>(mycontent);

            //var data = await  http.GetStringAsync(AbouteRoutes.GetDetails);
        }
    }
}
