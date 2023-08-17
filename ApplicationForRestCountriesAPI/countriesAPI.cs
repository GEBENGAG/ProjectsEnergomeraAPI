using ApplicationForRestCountriesAPI.Models;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApplicationForRestCountriesAPI
{
    public class countriesAPI
    {
       

            public int idCountry { get; set; }

            [JsonPropertyName("name")]
            public string nameCountry { get; set; }
            [JsonPropertyName("flag")]

            public object flagCountry { get; set; }
            [JsonPropertyName("capital")]
            public string capitalCountry { get; set; }

            [JsonPropertyName("lang")]
            public string languageCountry { get; set; }

        

    

        static HttpWebRequest _request;
        static string _url;
        public static string Response { get; set; }
        
        
        public countriesAPI(string url)
        {
            _url = url;

        }
        public static void Run()
        {
            _request = (HttpWebRequest)WebRequest.Create(_url);
            _request.Method = "GET";
            try
            {
                HttpWebResponse response = (HttpWebResponse)_request.GetResponse();
                var stream = response.GetResponseStream();
                if (stream != null) Response = new StreamReader(stream).ReadToEnd();
                
                  //List<countriesAPI> country = JsonSerializer.Deserialize<List<countriesAPI>>(Response);

            }
            catch (Exception ex)
            {

            }
             }
    }
}
