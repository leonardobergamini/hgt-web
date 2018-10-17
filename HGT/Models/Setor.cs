using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HGT.Models
{
    public class Setor
    {
        public List<Setor> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdSetor { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Nome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "capacidade_total_setor__c")]
        public string CapacidadeTotal {get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "capacidade_usada_setor__c")]
        public string CapacidadeUsada { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "local__c")]
        public string IdLocal {get; set;}

    }
}