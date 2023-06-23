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
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
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
            string hashPasswordIngresada = GenerarHash(passwordIngresada.Trim() );
            return hashPasswordIngresada == hashAlmacenado;
        }


    }
}
