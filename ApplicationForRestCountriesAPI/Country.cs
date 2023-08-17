using System.Text.Json.Serialization;

namespace ApplicationForRestCountriesAPI
{
    
    public class Country
    {
        

        public static int id { get; set; }

        [JsonPropertyName("name")]
        public static string name { get; set; }
        [JsonPropertyName("flag")]

        public static object flag { get; set; }
        [JsonPropertyName("capital")]
        public static string capital { get; set; }

        [JsonPropertyName("lang")]
        public static string language { get; set; }


    }
}
