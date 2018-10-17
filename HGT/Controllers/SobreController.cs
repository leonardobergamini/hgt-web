using HGT.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaveAGoodTime.Controllers
{
    public class SobreController : Controller
    {
        // GET: Sobre
        public ActionResult Index()
        {
            Global.IdEventoSelecionado = null;
            Global.IdLocalEvento = null;
            Global.IdFaixaEtariaEvento = null;
            Global.IngressoSelecionado = null;

            Dados d1 = new Dados();
            ViewBag.Layout = d1.getLayout();

            return View();
        }
    }
}