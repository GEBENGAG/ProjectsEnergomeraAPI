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


        HttpWebRequest _request;
        
        public static string Response { get; set; }


        public HomeController(ILogger<HomeController> logger)
        {

            _logger = logger;
            //_request = (HttpWebRequest)WebRequest.Create(url);
            //_request.Method = "GET";
            //try
            //{
            //    HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
            //    var stream = response.GetResponseStream();
            //    if (stream != null) Response = new StreamReader(stream).ReadToEnd();
            //    try
            //    {
                  
            //    }
            //    catch (Exception) 
            //    {
            //    View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });

            //    }
            //}
            //catch (Exception)
            //{
            //    View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            //}



        }
        

        public IActionResult Index()
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