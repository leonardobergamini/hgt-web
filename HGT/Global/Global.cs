using HGT.Models;
using HGT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.Global
{
    public class Global
    {
        public static Cliente Cliente { get; set; }

        public static APIConfig Auth { get; set; }
        public static String AccessToken { get; set; }
        public static String Url { get; set; }

        //----------------------------------------------
        
        public static string IdEventoSelecionado { get; set; }
        public static string IdLocalEvento { get; set; }
        public static string IdFaixaEtariaEvento { get; set; }


        public static Ingresso IngressoSelecionado { get; set; }

        public static Cliente ClientePesquisado { get; set; }

        public static Evento EventoPesquisado { get; set; }

    }
}