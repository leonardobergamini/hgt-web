using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MGT.Models
{
    public class ItemPedido
    {
        
        public int IdItem { get; set; }

        public int idPedido { get; set; }

        public int idTicket { get; set; }

        public int idTitular { get; set; }      

    }
}