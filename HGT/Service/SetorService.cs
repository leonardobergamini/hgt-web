using HGT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HGT.Service
{
    public class SetorService
    {
        public List<Setor> GetSetoresByLocal(String _idLocal)
        {

            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;


            var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c, capacidade_total_setor__c, " +
                "capacidade_usada_setor__c, local__c FROM setor__c " +
                "WHERE local__c = '" + _idLocal + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var setorApi = JsonConvert.DeserializeObject<Setor>(conteudoResposta);

                return setorApi.records;
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }
    }
}