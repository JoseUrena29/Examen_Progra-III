using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Entity_Framework.Models.ViewModels
{
    public class Modelo_Destinos
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Foto { get; set; }
        public int Precio { get; set; }
    }
}