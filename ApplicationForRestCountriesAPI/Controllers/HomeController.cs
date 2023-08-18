using ApplicationForRestCountriesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace ApplicationForRestCountriesAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public string url = @"https://restcountries.com/v3.1/all";
        static HttpClient httpClient = new HttpClient();
        List<CountriesViewModel> countriesViews;

        HttpWebRequest _request;
        
        public static string Response { get; set; }


        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
         


        }
        

        public IActionResult Index()
        {
            var request = new countriesAPI(@"https://restcountries.com/v3.1/all?fields=name,capital,flag,lang");
            countriesAPI.Run();

           List<CountriesModel> countriesViews = JsonConvert.DeserializeObject<List<CountriesModel>>(countriesAPI.Response);

            return View(new CountriesViewModel{
                Countries = countriesViews
            });
            
        }
        public IActionResult Details()
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