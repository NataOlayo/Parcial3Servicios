using Parcial3.Clases;
using Parcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using static Parcial3.Models.LibLogin;


namespace Parcial3.Controllers
{
    
        [RoutePrefix("api/Login")]
        public class LoginController : ApiController
        {
            [HttpPost]
            [Route("Ingresar")]
            public IQueryable<LoginRespuesta> Ingresar([FromBody] Login login)
            {
                clsLogin _login = new clsLogin();
                _login.login = login;
                return _login.Ingresar();
            }
        }
    
}