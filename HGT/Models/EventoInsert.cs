using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace HGT.Models
{
    public class EventoInsert
    {
        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Nome { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "descricao__c")]
        public string Descricao { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_inicio_evento__c")]
        public string DataInicio { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_final_evento__c")]
        public string DataFinal { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_inicio_venda__c")]
        public string DataInicioVenda { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "dt_final_venda__c")]
        public string DataFinalVenda { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "url_img__c")]
        public String UrlImagem { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Hr_inicio_evento__c")]
        public string HoraInicioEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Hr_termino_evento__c")]
        public string HoraTerminoEvento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "faixa_etaria__c")]
        public String IdFaixaEtaria { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "local__c")]
        public String IdLocal { get; set; }
    }
}