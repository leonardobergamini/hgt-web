using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HGT.Models
{
    public class Cliente
    {
        public List<Cliente> records { get; set; }

        //[Key]
        [Newtonsoft.Json.JsonProperty(PropertyName = "Id")]
        public string IdCliente { get; set; }

        //[Display(Name = "Nome", Description = "Seu nome")]
        //[Required(ErrorMessage = "Nome obrigatório")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "O campo Nome deve possuir no mínimo 3 e no máximo 50 caracteres")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Digite o nome sem números e caracteres especiais.")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "FirstName")]
        public string Nome { get; set; }

        //[Display(Name = "Sobrenome", Description = "Seu sobrenome")]
        //[Required(ErrorMessage = "Sobrenome obrigatório")]
        //[StringLength(50, MinimumLength = 3, ErrorMessage = "O campo Sobrenome deve possuir no mínimo 3 e no máximo 50 caracteres")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "Digite o sobrenome sem números e caracteres especiais.")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "LastName")]
        public string Sobrenome { get; set; }

        //[Display(Name = "DataNascimento", Description = "Data de nascimento")]
        //[Required(ErrorMessage = "Data de nascimento obrigatória")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "Birthdate")]
        public string DataNascimento {get; set;}
        //public DateTime DataNascimento { get; set; }

        //[Display(Name = "Cpf", Description = "Seu CPF")]
        //[Required(ErrorMessage = "CPF obrigatório")]
        //[StringLength(11, MinimumLength = 11, ErrorMessage = "O campo CPF deve possuir 11 caracteres")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "cpf__c")]
        public string Cpf {get; set;}

        //[Required(ErrorMessage = "e-Mail obrigatório")]
        //[EmailAddress]
        [Newtonsoft.Json.JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        //[Display(Name = "Telefone", Description = "Seu telefone")]
        //[Required(ErrorMessage = "Telefone obrigatório")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "MobilePhone")]
        public string Telefone {get; set;}

        //[Display(Name = "Rg", Description = "Seu Rg")]
        //[Required(ErrorMessage = "RG obrigatório")]
        //[StringLength(9, MinimumLength = 9, ErrorMessage = "O campo RG deve possuir 9 caracteres")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "rg__c")]
        public string Rg {get; set;}

        //[Display(Name = "Endereco", Description = "Seu endereço")]
        //[Required(ErrorMessage = "Endereço obrigatório")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "MailingStreet")]
        public string Endereco {get; set;}

        //[Display(Name = "Numero", Description = "Seu número")]
        //[Required(ErrorMessage = "Número obrigatório")]
        public string Numero {get; set;}

        //[Display(Name = "Complemento", Description = "Seu complemento")]
        public string Complemento {get; set;}

        //[Display(Name = "Cep", Description = "Seu CEP")]
        //[Required(ErrorMessage = "CEP obrigatório")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "MailingPostalCode")]
        public string Cep {get; set;}

        //[Display(Name = "Cidade", Description = "Sua cidade")]
        //[Required(ErrorMessage = "Cidade obrigatória")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "MailingCity")]
        public string cidade {get; set;}

        //[Display(Name = "Estado", Description = "Seu estado")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "MailingState")]
        public string estado {get; set;}

        //[Display(Name = "Usuario", Description = "Seu usuario")]
        //[Required(ErrorMessage = "Usuario obrigatório")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "usuario__c")]
        public string Usuario {get; set;}

        //[Display(Name = "Senha", Description = "Sua senha")]
        //[Required(ErrorMessage = "Senha obrigatória")]
        //[StringLength(50, MinimumLength = 8, ErrorMessage = "Sua senha deve ter no mínimo 8 caracteres.")]
        [Newtonsoft.Json.JsonProperty(PropertyName = "senha__c")]
        public string Senha {get; set;}


    }
}