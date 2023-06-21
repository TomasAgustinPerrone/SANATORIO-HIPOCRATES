using SANATORIO_HIPOCRATES.Config;
using SANATORIO_HIPOCRATES.Entidades;
using SANATORIO_HIPOCRATES.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES.Services
{
    public class LoginService
    {
        ConexionService conexionService = new ConexionService();

        public bool IniciarSesion(string username, string password)
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var usuarioExistente = context.Empleados.FirstOrDefault(p => p.Username == username);

                if (usuarioExistente != null)
                {
                    if (EncriptacionPassword.VerificarPassword(password, usuarioExistente.Password))
                    {
                        return true;
                    } 
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un usuario registrado con el id persona: " + username);
                }
            }
        }
    }
}
