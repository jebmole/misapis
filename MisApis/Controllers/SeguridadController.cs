using MisApis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MisApis.Controllers
{
    public class SeguridadController : ApiController
    {
        [HttpPost]
        public Respuesta Post(Login login)
        {
            var respuesta = new Respuesta();

            if (login == null)
            {
                respuesta.Mensaje = "No se han especificado las credenciales";
                return respuesta;
            }
            
            bool permitido = login.Usuario.Equals("Admin") && login.Password.Equals("CinemaAdmin");
            respuesta.EsPermitido = permitido;
            respuesta.Mensaje = permitido ? "OK" : "El usuario y/o contraseña no son válidos";

            return respuesta;
        }
    }
}
