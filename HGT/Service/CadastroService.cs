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
    public class CadastroService
    {

        public Boolean Inserir(Cliente _cliente)
        {
            if (_cliente.Nome.Equals("vitor"))
            {
                return true;
            }

            return false;
        }

        public void InserirCliente(ClienteInsert _cliente)
        {

            //Global.Global.Auth = new APIConfig().Auth();
            //Global.Global.AccessToken = Global.Global.Auth.access_token;
            //Global.Global.Url = Global.Global.Auth.instance_url;

            ////var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/sobjects/Contact/";
            //var _urlAccountApi = "https://na59.salesforce.com/services/data/v43.0/sobjects/Contact/";

            //var _body = JsonConvert.SerializeObject(_cliente);

            //StringContent _conteudo = new StringContent(_body, Encoding.UTF8, "application/json");

            //HttpClient client = new HttpClient();
            //client.DefaultRequestHeaders.Authorization =
            //    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);
            //var response = client.PostAsync(_urlAccountApi, _conteudo).Result;

            //if (response.IsSuccessStatusCode)
            //{
            //    var conteudoResposta = response.Content.ReadAsStringAsync().Result;
            //    dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(conteudoResposta);

            //    Console.WriteLine("Id da Conta Gerado: " + json.id);

            //}
            //else
            //{
            //    throw new Exception(response.ReasonPhrase);
            //}

                       
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            string url = "https://na59.salesforce.com/services/data/v43.0/sobjects/Contact/";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);
            string conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(_cliente);
            StringContent conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, conteudoJsonString).Result;
            if (!response.IsSuccessStatusCode) new Exception(response.ReasonPhrase);


        }

    }
}