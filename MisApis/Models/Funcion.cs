using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisApis.Models
{
    public class Funcion
    {
        public Funcion(string cinema, string sala, string ciudad, int precio)
        {
            Cinema = cinema;
            Sala = sala;
            Ciudad = ciudad;
            Precio = precio;
        }

        public string Cinema { get; set; }

        public string Sala { get; set; }

        public string Ciudad { get; set; }

        public int Precio { get; set; }
    }
}