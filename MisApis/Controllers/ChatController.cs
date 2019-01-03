using MisApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MisApis.Controllers
{
    public class ChatController : ApiController
    {
        public IEnumerable<Conversacion> Get()
        {
            var listado = new List<Conversacion>()
            {
                new Conversacion
                {
                    Nombre = "Carlos Lopez", UltimoMensaje = "Nos vemos luego", HoraUltimoMensaje = "3:35 p.m", Imagen = Url.Content("~/Content/Images/user1.png"),
                    Historial = new List<Mensaje>
                    {
                        new Mensaje { Descripcion = "Hola Carlos", Hora="1:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Necesito tu ayuda", Hora="1:10 p.m", Leido = true },
                        new Mensaje { Descripcion = "Es posible hacerlo?", Hora="2:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Nos vemos luego", Hora="3:35 p.m", Leido = false },
                    }
                },
                new Conversacion
                {
                    Nombre = "Andres Murillo", UltimoMensaje = "Doc, te necesito por aca", HoraUltimoMensaje = "4:00 p.m", Imagen = Url.Content("~/Content/Images/user2.png"),
                    Historial = new List<Mensaje>
                    {
                        new Mensaje { Descripcion = "Hola Andres", Hora="1:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Necesito tu ayuda", Hora="1:10 p.m", Leido = true },
                        new Mensaje { Descripcion = "Es posible hacerlo?", Hora="2:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Doc, te necesito por aca", Hora="4:00 p.m", Leido = false },
                    }
                },
                new Conversacion
                {
                    Nombre = "Yurany Aristizabal", UltimoMensaje = "Que bueno sería", HoraUltimoMensaje = "3:40 p.m", Imagen = Url.Content("~/Content/Images/user3.png"),
                    Historial = new List<Mensaje>
                    {
                        new Mensaje { Descripcion = "Hola Yurany", Hora="1:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Necesito tu ayuda", Hora="1:10 p.m", Leido = true },
                        new Mensaje { Descripcion = "Es posible hacerlo?", Hora="2:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Que bueno sería", Hora="3:40 p.m", Leido = false },
                    }
                },
                new Conversacion
                {
                    Nombre = "Alejandro Madrid", UltimoMensaje = "Asi nos funciona muy bien, es mejor que no realicemos cambios", HoraUltimoMensaje = "5:30 p.m", Imagen = Url.Content("~/Content/Images/user4.png"),
                    Historial = new List<Mensaje>
                    {
                        new Mensaje { Descripcion = "Hola Alejandro", Hora="1:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Necesito tu ayuda", Hora="1:10 p.m", Leido = true },
                        new Mensaje { Descripcion = "Es posible hacerlo?", Hora="2:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Asi nos funciona muy bien, es mejor que no realicemos cambios", Hora="5:30 p.m", Leido = false },
                    }
                },
                new Conversacion
                {
                    Nombre = "Marlon Restrepo", UltimoMensaje = "Nos fuimos, es ahora o nunca!", HoraUltimoMensaje = "6:35 p.m", Imagen = Url.Content("~/Content/Images/user5.png"),
                    Historial = new List<Mensaje>
                    {
                        new Mensaje { Descripcion = "Hola Marlon", Hora="1:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Necesito tu ayuda", Hora="1:10 p.m", Leido = true },
                        new Mensaje { Descripcion = "Es posible hacerlo?", Hora="2:00 p.m", Leido = true },
                        new Mensaje { Descripcion = "Nos fuimos, es ahora o nunca!", Hora="6:35 p.m", Leido = false },
                    }
                }
            };

            return listado;
        }
    }
}
