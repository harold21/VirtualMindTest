using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Model
{
    public class Dolar : ICurrency
    {
        public string GetCotization(string url)
        {
            var jsonObj = new WebClient().DownloadString(url);
            JArray cotizationArray = (JArray) JsonConvert.DeserializeObject(jsonObj);

            var cotization = new Dictionary<string, string>
            {
                {"PurchaseValue", cotizationArray[0].ToString()},
                {"SellValue", cotizationArray[1].ToString()},
                {"DateInformation", cotizationArray[2].ToString()}
            };

            var json = JsonConvert.SerializeObject(cotization);

            return json;
        }
    }
}
