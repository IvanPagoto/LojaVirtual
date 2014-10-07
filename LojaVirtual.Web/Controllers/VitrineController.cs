using LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;

        // GET: Vitrine
        public ActionResult Index()
        {


            return View();
        }
    }
}