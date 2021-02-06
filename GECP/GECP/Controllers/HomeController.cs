using GECP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static GECP.Constants.Routes;

namespace GECP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Newsletter()
        {
            return View();
        }

        public async Task<IActionResult> AboutAsync()
        {
            List<AboutUsModel> listuser = new List<AboutUsModel>();
            AboutUsModel users;

            var http = HttpClientFactory.Create();
            HttpResponseMessage httpResponseMessage = await http.GetAsync(AbouteRoutes.GetDetails);

            var content = httpResponseMessage.Content;

            string mycontent = await content.ReadAsStringAsync();
            AboutUsModel[] items = JsonConvert.DeserializeObject<AboutUsModel[]>(mycontent);

            foreach(var val in items)
            {
                listuser.Add(val);
            }
            //var data = await  http.GetStringAsync(AbouteRoutes.GetDetails);

            
            return View(listuser);
        }
        public IActionResult Coe()
        {
            return View();
        }
        public IActionResult Rti()
        {
            return View();
        }
        public IActionResult Admissionprocess()
        {
            return View();
        }
        public IActionResult Achievements()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
