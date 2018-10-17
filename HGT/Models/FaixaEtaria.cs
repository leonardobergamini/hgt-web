using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HGT.Models
{
    public class FaixaEtaria
    {
        public List<FaixaEtaria> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdFaixaEtaria { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Nome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public string Descricao { get; set; }    

    }
}