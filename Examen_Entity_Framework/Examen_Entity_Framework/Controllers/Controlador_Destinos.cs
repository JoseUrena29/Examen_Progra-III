using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Examen_Entity_Framework.Models;
using Examen_Entity_Framework.Models.ViewModels;

namespace Examen_Entity_Framework.Controllers
{
    public class Controlador_Destinos : Controller
    {
        // GET: Controlador_Destinos
        public ActionResult Index()
        {
            List<Modelo_Destinos> lst;

            using (EntityFrameworkEntitiess db = new EntityFrameworkEntitiess())
            {
                lst = (from d in db.Destinos
                           select new Modelo_Destinos
                           {
                               Codigo = d.codigo,
                               Nombre = d.nombre,
                               Descripcion = d.descripcion,
                               Foto = d.foto,
                               Precio = (int)d.precio
                           }).ToList();

            }
            return View(lst);
        }
    }
}