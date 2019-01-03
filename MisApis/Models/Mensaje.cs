using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisApis.Models
{
    public class Mensaje
    {
        public string Descripcion { get; set; }

        public string Hora { get; set; }

        public bool Leido { get; set; }
    }
}