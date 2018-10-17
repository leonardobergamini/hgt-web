using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MGT.Models
{
    public class Pedido
    {
        
        public int IdPedido { get; set; }

        public int idCartao { get; set; }

        public int idCliente { get; set; }     

    }
}