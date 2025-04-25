using Parcial3.Clases;
using Parcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Parcial3.Controllers
{
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {
        [HttpPost]
        [Route("CrearUsuario")]
        public string CrearUsuario([FromBody] Usuario usuario, int idPerfil)
        {
            clsUsuario Usuario = new clsUsuario();
            Usuario.usuario = usuario;
            return Usuario.CrearUsuario(idPerfil);
        }
    }
}
