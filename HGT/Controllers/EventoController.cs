using HGT.Business;
using HGT.Models;
using HGT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HGT.Controllers
{
    public class EventoController : Controller
    {
        Evento e = new Evento();
        EventoService es;
        Local local = new Local();
        FaixaEtaria faixaEtaria = new FaixaEtaria();

        // GET: Evento
        public ActionResult Index()
        {
            if (Global.Global.Cliente == null || Global.Global.Cliente.Usuario != "adm")
            {

                return Redirect("/Home/Index");
            }

            es = new EventoService();

            List<Local> locais = es.GetLocais();
            List<FaixaEtaria> faixasEtarias = es.GetFaixaEtarias();

            ViewBag.Locais = locais;
            ViewBag.FaixasEtarias = faixasEtarias;

            if (Global.Global.EventoPesquisado == null)
            {
                ViewBag.EventoPesquisado = e;
                ViewBag.Local = local;
                ViewBag.FaixaEtaria = faixaEtaria;

                ViewBag.DataInicio = "";
                ViewBag.HoraInicioEvento = "";
                ViewBag.DataFinal = "";
                ViewBag.HoraTerminoEvento = "";
                ViewBag.DataInicioVenda = "";
                ViewBag.DataFinalVenda = "";

                return View();
            }

            ViewBag.EventoPesquisado = Global.Global.EventoPesquisado;

            ViewBag.DataInicio = Global.Global.EventoPesquisado.DataInicio.ToString("dd/MM/yyyy");
            ViewBag.HoraInicioEvento = Global.Global.EventoPesquisado.HoraInicioEvento.ToString("hh:mm");
            ViewBag.DataFinal = Global.Global.EventoPesquisado.DataFinal.ToString("dd/MM/yyyy");
            ViewBag.HoraTerminoEvento = Global.Global.EventoPesquisado.HoraTerminoEvento.ToString("hh:mm");
            ViewBag.DataInicioVenda = Global.Global.EventoPesquisado.DataInicioVenda.ToString("dd/MM/yyyy");
            ViewBag.DataFinalVenda = Global.Global.EventoPesquisado.DataFinalVenda.ToString("dd/MM/yyyy");


            local = es.GetLocalById(Global.Global.EventoPesquisado.IdLocal);
            faixaEtaria = es.GetFaixaEtariaById(Global.Global.EventoPesquisado.IdFaixaEtaria);

            ViewBag.Local = local;
            ViewBag.FaixaEtaria = faixaEtaria;


            return View();
        }

        public ActionResult AdicionarEvento()
        {
            if (Global.Global.Cliente == null || Global.Global.Cliente.Usuario != "adm")
            {

                return Redirect("/Home/Index");
            }


            es = new EventoService();
            List<Local> locais = es.GetLocais();
            List<FaixaEtaria> faixasEtarias = es.GetFaixaEtarias();

            ViewBag.Locais = locais;
            ViewBag.FaixasEtarias = faixasEtarias;

            return View();
        }

        public ActionResult Adicionar(EventoInsert _evento)
        {
            try
            {          
                EventoBusiness eb = new EventoBusiness();
                eb.Adicionar(_evento);

                return Redirect("/Evento/AdicionarEvento");
            }
            catch
            {
                return Redirect("/Evento/AdicionarEvento");
            }

        }


        public ActionResult Buscar(Pesquisa _pesquisa)
        {
            try
            {
                EventoBusiness eb = new EventoBusiness();
                Evento evento = new Evento();

                if (_pesquisa.Filtro == "Nome")
                {
                    evento = eb.BuscarPorNome(_pesquisa.Dado);
                }
                else if (_pesquisa.Filtro == "Id")
                {
                    evento = eb.BuscarPorId(_pesquisa.Dado);
                }

                Global.Global.EventoPesquisado = evento;

                return Redirect("/Evento/");
            }
            catch
            {
                return Redirect("/Evento/");
            }
        }

        public ActionResult Alterar(EventoInsert _evento)
        {
            try
            {
                EventoBusiness eb = new EventoBusiness();
                Evento evento = new Evento();
                evento.IdEvento = _evento.IdEvento;

                eb.Alterar(_evento);

                evento = eb.BuscarPorId(evento.IdEvento);

                Global.Global.EventoPesquisado = evento;

                return Redirect("/Evento/");
            }
            catch
            {
                return Redirect("/Evento/");
            }
        }

        public ActionResult Excluir(Evento _evento)
        {
            try
            {
                EventoBusiness eb = new EventoBusiness();

                eb.Excluir(_evento.IdEvento);

                Global.Global.EventoPesquisado = null;

                return Redirect("/Evento/");
            }
            catch
            {
                return Redirect("/Evento/");
            }
        }


    }
}