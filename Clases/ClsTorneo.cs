using Parcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial3.Clases
{
    public class ClsTorneo
    {
        private DBEXAMEN3Entities1 db = new DBEXAMEN3Entities1(); // tu contexto

        public Torneo torneo { get; set; }

        public string Insertar()
        {
            try
            {
                db.Torneos.Add(torneo);
                db.SaveChanges();
                return "Torneo registrado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al insertar el torneo: " + ex.Message;
            }
        }

        public string Actualizar()
        {
            try
            {
                db.Torneos.Add(torneo);
                db.SaveChanges();
                return "Torneo actualizado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al actualizar el torneo: " + ex.Message;
            }
        }

        public Torneo ConsultarPorNombre(string nombre)
        {
            return db.Torneos.FirstOrDefault(t => t.NombreTorneo == nombre);
        }

        public List<Torneo> ConsultarPorTipo(string tipo)
        {
            return db.Torneos.Where(t => t.TipoTorneo == tipo).ToList();
        }

        public List<Torneo> ConsultarPorFecha(DateTime fecha)
        {
            return db.Torneos.Where(t => t.FechaTorneo == fecha).ToList();
        }

        public string Eliminar(int id)
        {
            try
            {
                var t = db.Torneos.Find(id);
                if (t == null) return "Torneo no encontrado.";
                db.Torneos.Remove(t);
                db.SaveChanges();
                return "Torneo eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar: " + ex.Message;
            }
        }
    }

}