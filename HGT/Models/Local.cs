using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HGT.Models
{
    public class Local
    {
        public List<Local> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdLocal { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Nome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "capacidade_total__c")]
        public long CapacidadeTotal {get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "rua__c")]
        public String Endereco { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "numero__c")]
        public long NroEndereco { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "complemento__c")]
        public String ComplementoEndereco { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "CEP__c")]
        public String CEP { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cidade__c")]
        public String Cidade { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "estado__c")]
        public String UF { get; set; }

    }
}