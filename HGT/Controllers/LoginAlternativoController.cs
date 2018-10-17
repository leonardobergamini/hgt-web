using HGT.Business;
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
    public class LoginAlternativoController : Controller
    {
        // GET: LoginAlternativo
        public ActionResult Index()
        {
            if (Global.Global.Cliente == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Entrar(Login _login)
        {

            try
            {
                var cliente = new LoginBusiness().Entrar(_login);

                if (cliente.Usuario == "admin")
                {
                    return View();
                }
                Global.Global.Cliente = cliente;


                Dados d1 = new Dados();
                d1.TrocarLayout("~/Views/Shared/LayoutLogado.cshtml");

                return RedirectToAction("Index", "Pagamento");
            }
            catch (Exception e)
            {

                return View("Index");
            }

        }
    }
}