using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Config
{
    public static class EncriptacionPassword
    {
        //Encripta la contraseña en protocolo SHA256 
        public static string GenerarHash(string password)
        {
            // Método para generar un hash a partir de una contraseña
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Calcula el hash de la contraseña convirtiendo la cadena de texto en bytes y aplicando la función de hash

                StringBuilder builder = new StringBuilder();// Crea un objeto StringBuilder para construir la representación en cadena del hash
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        //Verifica que sea la contraseña esperada en la bbdd
        public static bool VerificarPassword(string passwordIngresada, string hashAlmacenado)
        {
            string hashPasswordIngresada = GenerarHash(passwordIngresada.Trim() );// Genera un hash a partir de la contraseña ingresada (se aplica la misma función de hash)
            return hashPasswordIngresada == hashAlmacenado;
        }


    }
}
