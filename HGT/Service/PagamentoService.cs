using HGT.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace HGT.Service
{
    public class PagamentoService
    {
        public FormaPagamento GetFormaPagamento(Cliente _cliente)
        {

            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "Contato__c, cartao_credito__c FROM forma_de_pagamento__c " +
                "WHERE Contato__c = '" + _cliente.IdCliente + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var formaApi = JsonConvert.DeserializeObject<FormaPagamento>(conteudoResposta);

                return formaApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }

        public CartaoCredito GetCartaoCredito(FormaPagamento _formaPagamento)
        {

            //Global.AccessToken = Global.Auth.access_token;
            //Global.Url = Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Auth.instance_url + "/services/data/v43.0/query/?q= SELECT Id, " +
                "nome_titular__c, val_cartao__C, cod_seguranca__c, Name FROM credit_card__c " +
                "WHERE Id = '" + _formaPagamento.idCartao + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.Auth.access_token);

            var response = client.GetAsync(_urlAccountApi).Result;

            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var formaApi = JsonConvert.DeserializeObject<CartaoCredito>(conteudoResposta);

                return formaApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }
    }
}