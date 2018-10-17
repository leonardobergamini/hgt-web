using HGT.Models;
using HGT.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;

namespace HGT.Service
{
    public class LoginService
    {
        public Boolean Entrar(Login _login)
        {
            if (_login.Usuario == "vitor" && _login.Senha == "123")
            {
                return true;
            }

            return false;
        }

        public Cliente GetCliente(Login _login)
        {
            Global.Global.Auth = new APIConfig().Auth();
            Global.Global.AccessToken = Global.Global.Auth.access_token;
            Global.Global.Url = Global.Global.Auth.instance_url;

            var _urlAccountApi = Global.Global.Url + "/services/data/v43.0/query/?q= SELECT+Id+," +
                "+FirstName+,+LastName+,+Birthdate+,+cpf__c+,+Email+,+MobilePhone" +
                "+,+rg__c+,+usuario__c+,+senha__c+,+MailingStreet+,+MailingCity+," +
                "+MailingState+,+MailingPostalCode+FROM+Contact+" +
                "WHERE+usuario__c+LIKE+'" + _login.Usuario +
                "'+AND+senha__c+LIKE+'" + _login.Senha + "'";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
                      new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Global.Global.AccessToken);

            var response = client.GetAsync(_urlAccountApi).Result;


            try
            {
                var conteudoResposta = response.Content.ReadAsStringAsync().Result;
                var usersApi = JsonConvert.DeserializeObject<Cliente>(conteudoResposta);

                String ano = usersApi.records[0].DataNascimento.Substring(0, 4);
                String mes = usersApi.records[0].DataNascimento.Substring(5, 2);
                String dia = usersApi.records[0].DataNascimento.Substring(8, 2);

                usersApi.records[0].DataNascimento = dia + "/" + mes + "/" + ano;

                return usersApi.records[0];
            }
            catch (Exception e)
            {
                //(response.IsSuccessStatusCode)
                throw;
            }

        }
    }
}