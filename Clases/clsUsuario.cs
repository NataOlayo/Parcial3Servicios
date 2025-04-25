using Parcial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parcial3.Clases
{
    public class clsUsuario
    {
        private DBExamenEntities dbAgecia = new DBExamenEntities();
        public Usuario usuario { get; set; }
        public string CrearUsuario(int idPerfil)
        {
            try
            {
                clsCypher cypher = new clsCypher();
                cypher.Password = usuario.Clave;
                if (cypher.CifrarClave())
                {
                    usuario.Clave = cypher.PasswordCifrado;
                    usuario.Salt = cypher.Salt;
                    dbAgecia.Usuarios.Add(usuario);
                    dbAgecia.SaveChanges();
                    Usuario_Perfil UsuarioPerfil = new Usuario_Perfil();
                    UsuarioPerfil.idPerfil = idPerfil;
                    UsuarioPerfil.Activo = true;
                    UsuarioPerfil.idUsuario = usuario.id;
                    dbAgecia.Usuario_Perfil.Add(UsuarioPerfil);
                    dbAgecia.SaveChanges();
                    return "Usuario creado correctamente";

                }
                else
                {
                    return "Error al encriptar la clave";
                }


            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
