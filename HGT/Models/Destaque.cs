using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.Models
{
    public class Destaque
    {
        public List<Destaque> records { get; set; }

        
        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdDestaque { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__C")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "url__c")]
        public string UrlYoutube { get; set; }


    }
}