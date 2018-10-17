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
    public class PagamentoController : Controller
    {
        PagamentoService ps = new PagamentoService();
        FormaPagamento formaPagamento;
        CartaoCredito cartaoCredito;
        CartaoCredito c = new CartaoCredito();

        // GET: Pagamento
        public ActionResult Index()
        {
            try
            {
                formaPagamento = new FormaPagamento();
                cartaoCredito = new CartaoCredito();

                formaPagamento = ps.GetFormaPagamento(Global.Global.Cliente);
                cartaoCredito = ps.GetCartaoCredito(formaPagamento);

                Dados d1 = new Dados();
                ViewBag.Layout = d1.getLayout();

                if (cartaoCredito == null)
                {
                    ViewBag.CartaoCredito = c;

                    return View();
                }

                ViewBag.CartaoCredito = cartaoCredito;

                

                return View();
            }
            catch
            {
                cartaoCredito = new CartaoCredito();
                ViewBag.CartaoCredito = cartaoCredito;

                return View();
            }
        }
    }
}