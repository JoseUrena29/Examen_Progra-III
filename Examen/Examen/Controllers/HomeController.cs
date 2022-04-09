using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examen.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Exámen Programación III - Entity Framework SQL Server";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Estudiantes:";

            return View();
        }
    }
}