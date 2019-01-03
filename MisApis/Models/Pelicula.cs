using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisApis.Models
{
    public class Pelicula
    {
        public Pelicula(string nombre, DateTime fecha, string genero, string recomendacion, int duracion, string imagen, List<Funcion> funciones )
        {
            Nombre = nombre;
            FechaEstreno = fecha;
            Genero = genero;
            Recomendacion = recomendacion;
            Duracion = duracion;
            Imagen = imagen;
            Funciones = funciones;
        }

        public string Nombre { get; set; }

        public DateTime FechaEstreno { get; set; }

        public string Genero { get; set; }

        public string Recomendacion { get; set; }

        public int Duracion { get; set; }

        public string Imagen { get; set; }

        public IEnumerable<Funcion> Funciones { get; set; }
    }
}