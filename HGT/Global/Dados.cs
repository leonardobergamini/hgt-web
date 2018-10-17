using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.Global
{
    public class Dados
    {
        public static String LayoutPrincipal = "~/Views/Shared/LayoutPrincipal.cshtml";

        public void TrocarLayout(String _layout)
        {
            LayoutPrincipal = _layout;
        }

        public String getLayout()
        {
            return LayoutPrincipal;
        }
    }

    
}