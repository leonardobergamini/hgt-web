using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.Models
{
    public class FormaPagamento
    {
        public List<FormaPagamento> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdFormaPagamento { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cartao_credito__c")]
        public string idCartao { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Contato__C")]
        public string idCliente { get; set; }    

    }
}