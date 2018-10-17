using HGT.Models;
using HGT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HGT.Controllers
{
    public class ConsultaController : Controller
    {
        ClienteService cs;
        Cliente c = new Cliente();

        // GET: Consulta
        public ActionResult Index()
        {
            if (Global.Global.Cliente == null || Global.Global.Cliente.Usuario != "adm")
            {

                return Redirect("/Home/Index");
            }

            if (Global.Global.ClientePesquisado == null)
            {
                ViewBag.Cliente = c;
                return View();
            }

            ViewBag.Cliente = Global.Global.ClientePesquisado;

            return View();
        }

        public ActionResult Pesquisar(Pesquisa _pesquisa)
        {
            try
            {
                if (_pesquisa.Filtro == "CPF")
                {
                    Global.Global.ClientePesquisado = PesquisarPorCPF(_pesquisa.Dado);
                    return Redirect("/Consulta/Index");
                }
                else if (_pesquisa.Filtro == "Email")
                {
                    Global.Global.ClientePesquisado = PesquisarPorEmail(_pesquisa.Dado);
                    return Redirect("/Consulta/Index");
                }
                else if (_pesquisa.Filtro == "Usuario")
                {
                    Global.Global.ClientePesquisado = PesquisarPorUsuario(_pesquisa.Dado);
                    return Redirect("/Consulta/Index");
                }
                else
                {
                    return Redirect("/Consulta/Index");
                }
            }
            catch
            {
                return Redirect("/Consulta/Index");
            }
        }

        public Cliente PesquisarPorCPF(string _cpf)
        {

            cs = new ClienteService();

            return cs.GetClienteByCPF(_cpf);
        }

        public Cliente PesquisarPorEmail(string _email)
        {
            cs = new ClienteService();

            return cs.GetClienteByEmail(_email);
        }

        public Cliente PesquisarPorUsuario(string _usuario)
        {
            cs = new ClienteService();

            return cs.GetClienteByUsuario(_usuario);
        }

    }
}