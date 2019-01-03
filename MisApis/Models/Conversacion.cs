using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisApis.Models
{
    public class Conversacion
    {
        public string Nombre { get; set; }

        public string UltimoMensaje { get; set; }

        public string HoraUltimoMensaje { get; set; }

        public string Imagen { get; set; }

        public List<Mensaje> Historial { get; set; }
    }
}