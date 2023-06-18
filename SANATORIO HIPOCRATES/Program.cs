using Microsoft.EntityFrameworkCore;
using SANATORIO_HIPOCRATES.Config;
using SANATORIO_HIPOCRATES.Entidades;
using System;


namespace SANATORIO_HIPOCRATES
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder.UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=123456;",
                new MySqlServerVersion(new Version(8, 0, 21)) // or whatever version you have
            );


            using (var context = new Conexion(optionsBuilder.Options))
            {
                var nuevaPersona = new Persona
                {
                    IdPersona = 1, // Este valor debe ser único
                    Dni = "12345678",
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Sexo = "M",
                    Telefono = "1234567890",
                    Email = "juan.perez@example.com",
                    Domicilio = "Calle Falsa 123",
                    FechaNacimiento = new DateTime(1980, 1, 1),
                    Nacionalidad = "Argentina"
                };

                context.Personas.Add(nuevaPersona);
                context.SaveChanges();
            }

            /*
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */


        }
    }
}
