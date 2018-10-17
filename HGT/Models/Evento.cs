using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HGT.Models
{
    public class Evento
    {
        public List<Evento> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Nome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_inicio_evento__c")]
        public DateTime DataInicio {get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_final_evento__c")]
        public DateTime DataFinal {get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_inicio_venda__c")]
        public DateTime DataInicioVenda {get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_final_venda__c")]
        public DateTime DataFinalVenda {get; set;}

        [Newtonsoft.Json.JsonProperty(PropertyName = "url_img__c")]
        public String UrlImagem { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Hr_inicio_evento__c")]
        public DateTime HoraInicioEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Hr_termino_evento__c")]
        public DateTime HoraTerminoEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "faixa_etaria__c")]
        public String IdFaixaEtaria { get; set; }
        //public FaixaEtaria FaixaEtaria { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "local__c")]
        public String IdLocal { get; set; }
        //public Local Local { get; set; }

    }
}