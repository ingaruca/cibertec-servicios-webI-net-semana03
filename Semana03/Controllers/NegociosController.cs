using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Semana03.Models;

namespace Semana03.Controllers
{
    public class NegociosController : Controller
    {
        Negocios2018Entities bd = new Negocios2018Entities();
        // GET: Negocios
        public ActionResult Index()
        {
            return View(bd.clientes.ToList());
        }

        public ActionResult BuscarClientexPais(string txtFiltroPais)
        {
            ViewBag.paises = new SelectList(bd.paises.ToList(), "Idpais", "NombrePais");
            return View(bd.clientes.Where(c => c.idpais == txtFiltroPais).ToList());
        }

        public ActionResult PedidoxCliente(string txtCliente)
        {
            ViewBag.clientes = new SelectList(bd.clientes.ToList(), "IdCliente", "NomCliente");
            return View(bd.pedidoscabe.Where(p => p.IdCliente == txtCliente).ToList());
        }
    }
}