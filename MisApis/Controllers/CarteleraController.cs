using MisApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MisApis.Controllers
{
    public class CarteleraController : ApiController
    {
        public IEnumerable<Pelicula> Get()
        {
            var listado = ObtenerPeliculas();
            return listado;
        }

        private IEnumerable<Pelicula> ObtenerPeliculas()
        {
            var funciones = new List<Funcion>
            {
                new Funcion("Los Molinos", "Sala 1", "Medellin", 12000),
                new Funcion("Santa Fe", "Sala 4", "Medellin", 15000),
                new Funcion("Unicentro", "Sala 2", "Bogota", 13000)
            };

            var peliculas = new List<Pelicula>
            {
                new Pelicula("Venom", new DateTime(2018,10,04),"Acción, Ciencia Ficción, Horror.", "Mayores de 7 años",115, Url.Content("~/Content/Images/venom.jpg"),funciones),
                new Pelicula("Pie Pequeño", new DateTime(2018,10,04),"Aventura, Comedia", "Todo público",97, Url.Content("~/Content/Images/piepequeno.jpg"),funciones),
                new Pelicula("Nace una Estrella", new DateTime(2018,10,18),"Drama, Musical", "Mayores de 12 años",135, Url.Content("~/Content/Images/naceunaestrella.jpg"),funciones),
                new Pelicula("Buscando", new DateTime(2018,10,18),"Suspenso", "Mayores de 12 años",101, Url.Content("~/Content/Images/searching.jpg"),funciones),
                new Pelicula("El Reality", new DateTime(2018,10,04),"Comedia", "Todo público",104, Url.Content("~/Content/Images/reality.jpg"),funciones)
            };


            var listado = peliculas.ToList();
            listado.ForEach(x => x.Imagen = Url.Content(x.Imagen));

            return peliculas;
        }
    }
}
