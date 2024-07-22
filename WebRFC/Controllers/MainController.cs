using Business;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRFC.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult GoToGenerate()
        {
            return View("GenerateView");
        }

        public ActionResult Create(E_RFC user) //Crea un registro de usuario, en la capa negocio se genera el RFC
        {
            B_RFC creator =  new B_RFC(); //Objeto de la capa de negocio con las herramientas
        }
    }
}