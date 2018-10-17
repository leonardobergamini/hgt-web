using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.Models
{
    public class Ticket
    {
        public List<Ticket> records { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public String IdTicket { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "preco__c")]
        public Double Preco { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cod_ingresso__c")]
        public String CodIngresso { get; set; }


        [Newtonsoft.Json.JsonProperty(PropertyName = "setor__c")]
        public String IdSetor { get; set; }
        public Setor Setor { get; set; }

        public String QrCode { get { return ToString(); } }
    }
}