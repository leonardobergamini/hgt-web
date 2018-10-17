using HGT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;

namespace HGT.Service
{
    public class DestaqueService
    {
        public List<Destaque> GetDestaques()
        {

            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c, url__c FROM Noticia__c ";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var formaApi = JsonConvert.DeserializeObject<Destaque>(conteudoResposta);

                return formaApi.records;
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }

        public void SalvarDestaque(DestaquePost destaque)
        {
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var uri = "https://na59.salesforce.com/services/data/v43.0/sobjects/Noticia__c/" + destaque.IdDestaque;
            destaque.IdDestaque = null; // PATCH nao permite o ID no payload
            var conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(destaque);
            System.Net.Http.HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);
            var method = new HttpMethod("PATCH");
            var request = new HttpRequestMessage(method, uri)
            {
                Content = new StringContent(conteudoJson, Encoding.UTF8, "application/json")
            };
            HttpResponseMessage response = client.SendAsync(request).Result;
            if (!response.IsSuccessStatusCode) new Exception(response.ReasonPhrase);
        }
    }
}