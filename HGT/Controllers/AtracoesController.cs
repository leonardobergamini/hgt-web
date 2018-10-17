using HGT.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaveAGoodTime.Controllers
{
    public class AtracoesController : Controller
    {
        // GET: Atracoes
        public ActionResult Index()
        {
            Dados d1 = new Dados();
            ViewBag.Layout = d1.getLayout();


            return View();
        }
    }
}