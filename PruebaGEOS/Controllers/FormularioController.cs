using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaGEOS.Controllers
{
    public class FormularioController : Controller
    {
        //
        // GET: /Formulario/

        public ActionResult Index()
        {
            ViewBag.titulo = "Formulario Secreto!!";

            return View();
        }

        public ActionResult Exito(string palabra)
        {
            ViewBag.titulo = "Exito!!";
            ViewBag.palabra = palabra;

            return View();
        }

    }
}
