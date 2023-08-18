namespace ApplicationForRestCountriesAPI.Models
{
    public class CountriesModel
    {
        public string[] capital { get; set; }
        public string flag { get; set; }

        public string[] languages { get; set; }

        public CountryName name { get; set; }
        

       

          
    }
    public class CountryName
    {
        public string common { get; set; }
        public string official { get; set; }

    }
}
