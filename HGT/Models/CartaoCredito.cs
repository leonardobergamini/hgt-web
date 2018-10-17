using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HGT.Models
{
    public class CartaoCredito
    {
        public List<CartaoCredito> records { get; set; }

        //[Key]
        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdCartao { get; set; }

        //[Display(Name = "Nome", Description = "Nome")]
        //[Required(ErrorMessage = "Nome obrigatório")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Digite o nome sem números e caracteres especiais.")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "nome_titular__c")]
        public string NomeTitular { get; set; }

        //[Display(Name = "Validade", Description = "Validade do cartão")]
        //[Required(ErrorMessage = "Validade obrigatória")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "val_cartao__C")]
        public string Validade { get; set; }

        //[Display(Name = "CodigoSeguranca", Description = "Código de segurança")]
        //[Required(ErrorMessage = "Código de segurança obrigatório")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "cod_seguranca__c")]
        public string CodigoSeguranca {get; set;}

        //[Display(Name = "NumeroCartao", Description = "Número do cartão de crédito")]
        //[Required(ErrorMessage = "Número do cartão obrigatório")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string NumeroCartao {get; set;}             

    }
}