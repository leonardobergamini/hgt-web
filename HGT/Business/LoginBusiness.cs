using HGT.Models;
using HGT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.Business
{
    public class LoginBusiness
    {
        public Cliente Entrar(Login _usuario)
        {
            var cliente = new LoginService().GetCliente(_usuario);
            return cliente;
        }
    }
}