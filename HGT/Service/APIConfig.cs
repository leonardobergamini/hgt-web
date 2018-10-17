using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;

namespace HGT.Service
{
    public class APIConfig
    {
        static String securityKey = "e9PniOXjngD9zsdKYH5zVZWA";
        static String clientSecret = "365439225014601628";
        static String clientId = "3MVG9zlTNB8o8BA35PlESwZ1230xTA.0LK9DiQ89GCVjyuovnQbhd7uXARjm3pycVP8fGZfiCMfoiv34S2BwM";
        static String grantAcess = "password";
        static String userName = "alantor.xs@gmail.com";
        static String password = "Xtreme@4546" + securityKey;
        public String urlSalesForceAuth = "https://login.salesforce.com/services/oauth2/token";

        public String access_token { get; set; }
        public String instance_url { get; set; }
        public String token_type { get; set; }

        public Dictionary<String, String> AcessarAPI()
        {
            var parameters = new Dictionary<String, String> {
                { "grant_type" , grantAcess },
                { "username" , userName },
                { "password" , password },
                { "client_id", clientId },
                { "client_secret", clientSecret },
            };

            return parameters;

        }


        public APIConfig Auth()
        {

            APIConfig apiConfig = new APIConfig();

            var parameters = apiConfig.AcessarAPI();
            var encodedContent = new FormUrlEncodedContent(parameters);
            HttpClient client = new HttpClient();
            var response = client.PostAsync(apiConfig.urlSalesForceAuth, encodedContent).Result;

            if (response.IsSuccessStatusCode)
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var json = JsonConvert.DeserializeObject<APIConfig>(conteudoResposta);
                return json;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
    }
}