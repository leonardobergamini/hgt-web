using HGT.Models;
using HGT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HGT.Controllers
{
    public class DestaquesController : Controller
    {
        // GET: Destaques
        public ActionResult Index()
        {
            if (Global.Global.Cliente == null || Global.Global.Cliente.Usuario != "adm")
            {

                return Redirect("/Home/Index");
            }

            Global.Global.ClientePesquisado = null;

            try { 
                DestaqueService ds = new DestaqueService();
                List<Destaque> destaques = new List<Destaque>();

                destaques = ds.GetDestaques();

                ViewBag.Destaques = destaques;

                return View("Index");
            }
            catch
            {
                return Redirect("/Destaques/Index");
            }
        }

        public ActionResult Destaque2()
        {
            DestaqueService ds = new DestaqueService();
            List<Destaque> destaques = new List<Destaque>();

            destaques = ds.GetDestaques();

            ViewBag.Destaques = destaques;

            return View("Destaque2");
        }

        public ActionResult Destaque3()
        {
            DestaqueService ds = new DestaqueService();
            List<Destaque> destaques = new List<Destaque>();

            destaques = ds.GetDestaques();

            ViewBag.Destaques = destaques;

            return View("Destaque3");
        }

        public ActionResult Salvar(DestaquePost _destaque)
        {
            try
            {
                DestaqueService ds = new DestaqueService();

                ds.SalvarDestaque(_destaque);

                return Index();
            }
            catch
            {
                return Redirect("/Destaques/Index");
            }
        }

    }
}