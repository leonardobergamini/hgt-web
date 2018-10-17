using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HGT.Global;
using HGT.Service;
using HGT.Models;

namespace HaveAGoodTime.Controllers
{
    public class HomeController : Controller
    {
        EventoService es = new EventoService();
        DestaqueService ds = new DestaqueService();
        static List<Evento> eventos = new List<Evento>();
        static List<Local> locais = new List<Local>();
        static List<FaixaEtaria> faixasEtarias = new List<FaixaEtaria>();
        static List<Destaque> destaques = new List<Destaque>();


        // GET: Home
        public ActionResult Index()
        {
            Global.IdEventoSelecionado = null;
            Global.IdLocalEvento = null;
            Global.IdFaixaEtariaEvento = null;
            Global.IngressoSelecionado = null;
            Global.ClientePesquisado = null;

            eventos = es.GetEventos();
            locais = es.GetLocais();
            faixasEtarias = es.GetFaixaEtarias();
            destaques = ds.GetDestaques();

            ViewBag.Eventos = eventos;

            ViewBag.Destaques = destaques;

            Dados d1 = new Dados();
            ViewBag.Layout = d1.getLayout();

            return View();
        }

        public String GetNomeLocal(String Type)
        {


            foreach (Local l in locais)
            {
                if (l.IdLocal.Equals(Type))
                {
                    return l.Nome;
                }
            }

            return null;
        }

        public String GetDescricaoLocal(String Type)
        {

            foreach (Local l in locais)
            {
                if (l.IdLocal.Equals(Type))
                {
                    return l.Descricao;
                }
            }

            return null;
        }

        public String GetLocalidade(String Type)
        {

            String localidade;

            foreach (Local l in locais)
            {
                if (l.IdLocal.Equals(Type))
                {
                    localidade = l.Cidade + " - " + l.UF;
                    return localidade;
                }
            }

            return null;
        }

        public string GetValorFaixaEtaria(String Type)
        {

            foreach (FaixaEtaria f in faixasEtarias)
            {
                if (f.IdFaixaEtaria.Equals(Type))
                {
                    return f.Nome;
                }
            }
            return null;
        }





        //------MY WAY---------
        public ActionResult GetMessage0()
        {
            Global.IdEventoSelecionado = eventos[0].IdEvento;
            Global.IdLocalEvento = eventos[0].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[0].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult GetMessage1()
        {
            Global.IdEventoSelecionado = eventos[1].IdEvento;
            Global.IdLocalEvento = eventos[1].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[1].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult GetMessage2()
        {
            Global.IdEventoSelecionado = eventos[2].IdEvento;
            Global.IdLocalEvento = eventos[2].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[2].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult GetMessage3()
        {
            Global.IdEventoSelecionado = eventos[3].IdEvento;
            Global.IdLocalEvento = eventos[3].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[3].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult GetMessage4()
        {
            Global.IdEventoSelecionado = eventos[4].IdEvento;
            Global.IdLocalEvento = eventos[4].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[4].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        public ActionResult GetMessage5()
        {
            Global.IdEventoSelecionado = eventos[5].IdEvento;
            Global.IdLocalEvento = eventos[5].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[5].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult GetMessage6()
        {
            Global.IdEventoSelecionado = eventos[6].IdEvento;
            Global.IdLocalEvento = eventos[6].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[6].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult GetMessage7()
        {
            Global.IdEventoSelecionado = eventos[7].IdEvento;
            Global.IdLocalEvento = eventos[7].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[7].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        public ActionResult GetMessage8()
        {
            Global.IdEventoSelecionado = eventos[8].IdEvento;
            Global.IdLocalEvento = eventos[8].IdLocal;
            Global.IdFaixaEtariaEvento = eventos[8].IdFaixaEtaria;
            return new JsonResult { Data = "", JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
    }
}