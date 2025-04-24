using Parcial3.Clases;
using Parcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Parcial3.Controllers
{
    [RoutePrefix("api/Torneos")]
    public class TorneosController : ApiController
    {
        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Torneo torneo)
        {
            var cls = new ClsTorneo { torneo = torneo };
            return cls.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Torneo torneo)
        {
            var cls = new ClsTorneo { torneo = torneo };
            return cls.Actualizar();
        }

        [HttpGet]
        [Route("ConsultarPorNombre")]
        public Torneo ConsultarPorNombre(string nombre)
        {
            return new ClsTorneo().ConsultarPorNombre(nombre);
        }

        [HttpGet]
        [Route("ConsultarPorTipo")]
        public List<Torneo> ConsultarPorTipo(string tipo)
        {
            return new ClsTorneo().ConsultarPorTipo(tipo);
        }

        [HttpGet]
        [Route("ConsultarPorFecha")]
        public List<Torneo> ConsultarPorFecha(DateTime fecha)
        {
            return new ClsTorneo().ConsultarPorFecha(fecha);
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar(int id)
        {
            return new ClsTorneo().Eliminar(id);
        }
    }

}