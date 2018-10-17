using HGT.Business;
using HGT.Global;
using HGT.Models;
using HGT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaveAGoodTime.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        public ActionResult Index()
        {
            Global.IdEventoSelecionado = null;
            Global.IdLocalEvento = null;
            Global.IdFaixaEtariaEvento = null;
            Global.IngressoSelecionado = null;

            if (Global.Cliente == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Cadastrar(ClienteInsert _cliente)
        {
            try
            {
                var dia = _cliente.DataNascimento.Substring(0, 2);
                var mes = _cliente.DataNascimento.Substring(3, 2);
                var ano = _cliente.DataNascimento.Substring(6, 4);

                _cliente.DataNascimento = ano + "-" + mes + "-" + dia;

                CadastroService cs = new CadastroService();

                cs.InserirCliente(_cliente);

                //-----------------------------------

                Login Login = new Login();

                Login.Usuario = _cliente.Usuario;
                Login.Senha = _cliente.Senha;

                var cliente = new LoginBusiness().Entrar(Login);

                Global.Cliente = cliente;

                Dados d1 = new Dados();

                d1.TrocarLayout("~/Views/Shared/LayoutLogado.cshtml");

                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return Redirect("/Cadastro/CadastroErro");
            }
        }

        public ActionResult CadastroErro()
        {
            return View();
        }
    }
}