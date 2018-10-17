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
    public class EventoService
    {

        public List<Evento> GetEventos()
        {
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Url + "/services/data/v43.0/query/?q= SELECT Id, Name, " +
                "local__c, faixa_etaria__c, descricao__c, dt_inicio_evento__c, " +
                "dt_final_evento__c, dt_inicio_venda__c, dt_final_venda__c, url_img__c " +
                ", Hr_inicio_evento__c, Hr_termino_evento__c FROM evento__c ";


            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var eventoApi = JsonConvert.DeserializeObject<Evento>(conteudoResposta);

                return eventoApi.records;
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }

        public Evento GetEventoById(String _idEvento)
        {
            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, Name, " +
                "local__c, faixa_etaria__c, descricao__c, dt_inicio_evento__c, " +
                "dt_final_evento__c, dt_inicio_venda__c, dt_final_venda__c, url_img__c " +
                ", Hr_inicio_evento__c, Hr_termino_evento__c FROM evento__c WHERE Id ='" + _idEvento + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var eventoApi = JsonConvert.DeserializeObject<Evento>(conteudoResposta);


                return eventoApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }

        public List<Local> GetLocais()
        {
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c, capacidade_total__c, rua__c, cidade__c, " +
                "estado__c, CEP__c, pais__c, complemento__c, numero__c " +
                "FROM Local__c";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var localApi = JsonConvert.DeserializeObject<Local>(conteudoResposta);

                return localApi.records;
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }

        public Local GetLocalById(String _idLocal)
        {
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c, capacidade_total__c, rua__c, cidade__c, " +
                "estado__c, CEP__c, pais__c, complemento__c, numero__c " +
                "FROM Local__c WHERE Id ='" + _idLocal + "'";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var localApi = JsonConvert.DeserializeObject<Local>(conteudoResposta);

                return localApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }


        public List<FaixaEtaria> GetFaixaEtarias()
        {
            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c FROM faixa_etaria__c";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var faixaApi = JsonConvert.DeserializeObject<FaixaEtaria>(conteudoResposta);

                return faixaApi.records;

            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }


        public FaixaEtaria GetFaixaEtariaById(String _idFaixa)
        {
            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Name, descricao__c FROM faixa_etaria__c WHERE Id = '" + _idFaixa + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var faixaApi = JsonConvert.DeserializeObject<FaixaEtaria>(conteudoResposta);

                return faixaApi.records[0];

            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }
        }

        public void InserirEvento(EventoInsert _evento)
        {
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            string url = "https://na59.salesforce.com/services/data/v43.0/sobjects/evento__c/";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);
            string conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(_evento);
            StringContent conteudoJsonString = new StringContent(conteudoJson, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(url, conteudoJsonString).Result;
            if (!response.IsSuccessStatusCode) new Exception(response.ReasonPhrase);
        }

        public Evento GetEventoByName(String _nomeEvento)
        {
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, Name, " +
                "local__c, faixa_etaria__c, descricao__c, dt_inicio_evento__c, " +
                "dt_final_evento__c, dt_inicio_venda__c, dt_final_venda__c, url_img__c " +
                ", Hr_inicio_evento__c, Hr_termino_evento__c FROM evento__c WHERE Name ='" + _nomeEvento + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var eventoApi = JsonConvert.DeserializeObject<Evento>(conteudoResposta);


                return eventoApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }

        public void UpdateEvento(EventoInsert _evento)
        {
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var uri = "https://na59.salesforce.com/services/data/v43.0/sobjects/evento__c/" + _evento.IdEvento;
            _evento.IdEvento = null; // PATCH nao permite o ID no payload
            var conteudoJson = Newtonsoft.Json.JsonConvert.SerializeObject(_evento);
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

        public void DeleteEvento(string _idEvento)
        {
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var uri = "https://na59.salesforce.com/services/data/v43.0/sobjects/evento__c/" + _idEvento;
            System.Net.Http.HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);
            HttpResponseMessage response = client.DeleteAsync(uri).Result;
            if (!response.IsSuccessStatusCode) new Exception(response.ReasonPhrase);
        }


    }
}