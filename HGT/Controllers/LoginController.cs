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
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            if (Global.Cliente == null)
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

                Global.Cliente = cliente;


                Dados d1 = new Dados();

                if (cliente.Usuario == "adm")
                {
                    d1.TrocarLayout("~/Views/Shared/LayoutAdm.cshtml");
                }
                else
                {
                    d1.TrocarLayout("~/Views/Shared/LayoutLogado.cshtml");
                }              
                
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return View("Index");
            }

        }
    }
}