using HGT.Global;
using HGT.Models;
using HGT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HGT.Controllers
{
    public class IngressoController : Controller
    {
        
        EventoService es = new EventoService();
        SetorService ss = new SetorService();

        Evento evento;
        Local local;
        FaixaEtaria faixaEtaria;

        List<Setor> setores;

        // GET: Ingresso
        public ActionResult Index()
        {

            evento = new Evento();
            local = new Local();
            faixaEtaria = new FaixaEtaria();

            evento = es.GetEventoById(Global.Global.IdEventoSelecionado);
            local = es.GetLocalById(Global.Global.IdLocalEvento);
            faixaEtaria = es.GetFaixaEtariaById(Global.Global.IdFaixaEtariaEvento);

            setores = ss.GetSetoresByLocal(Global.Global.IdLocalEvento);

            ViewBag.Evento = evento;
            ViewBag.Local = local;
            ViewBag.FaixaEtaria = faixaEtaria;

            ViewBag.Setores = setores;

            Dados d1 = new Dados();
            ViewBag.Layout = d1.getLayout();

            return View();
        }

        public ActionResult Avancar(Ingresso _ingresso)
        {
            Global.Global.IngressoSelecionado = _ingresso;

            if (Global.Global.Cliente == null)
            {
                
                return Redirect("/LoginAlternativo/Index");
            }

            
            return RedirectToAction("Index", "Pagamento");

        }


    }
}