using HGT.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HGT.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Index()
        {

            Global.Global.Cliente = null;

            Dados d1 = new Dados();
            d1.TrocarLayout("~/Views/Shared/LayoutPrincipal.cshtml");
            return RedirectToAction("Index","Home");
        }
    }
}