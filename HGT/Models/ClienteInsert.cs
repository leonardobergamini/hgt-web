using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.Models
{
    public class ClienteInsert
    {
        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("Firstname")]
        public string Nome { get; set; }

        [JsonProperty("LastName")]
        public string Sobrenome { get; set; }

        [JsonProperty("Birthdate")]
        public string DataNascimento { get; set; }

        [JsonProperty("cpf__c")]
        public string Cpf { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("MobilePhone")]
        public string Telefone { get; set; }

        [JsonProperty("rg__c")]
        public string Rg { get; set; }

        [JsonProperty("MailingStreet")]
        public string Endereco { get; set; }

        [JsonProperty("MailingPostalCode")]
        public string Cep { get; set; }

        [JsonProperty("MailingCity")]
        public string cidade { get; set; }

        [JsonProperty("MailingState")]
        public string estado { get; set; }

        [JsonProperty("usuario__c")]
        public string Usuario { get; set; }

        [JsonProperty("senha__c")]
        public string Senha { get; set; }
    }
}