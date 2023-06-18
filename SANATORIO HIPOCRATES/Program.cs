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


            Recepcionista recepcionistaLaburando = new Recepcionista();
            recepcionistaLaburando.CrearTurno("9055675895", "Julian", "Perez", 'M', "1234567890",
                            "juan.perez@example.com", "Calle Falsa 123",
                            new DateTime(1980, 03, 10), "Argentina", "Galeno", 1210540);




            /*
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder.UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=123456;",
                new MySqlServerVersion(new Version(8, 0, 21)) // or whatever version you have
            );


            using (var context = new Conexion(optionsBuilder.Options))
            {


                
                var nuevaPersona = new Persona
                {
                    Dni = "12345678",
                    Nombre = "Juan",
                    Apellido = "Perez",
                    Sexo = 'M',
                    Telefono = "1234567890",
                    Email = "juan.perez@example.com",
                    Domicilio = "Calle Falsa 123",
                    FechaNacimiento = new DateTime(1980, 1, 1),
                    Nacionalidad = "Argentina"
                };

                context.Personas.Add(nuevaPersona);
                context.SaveChanges();


                var nuevoPaciente = new Paciente
                {
                    IdPersona = nuevaPersona.IdPersona,
                    Persona = nuevaPersona,
                    ObraSocial = "Swiss",
                    NumeroCarnet = 4500
                };

                context.Pacientes.Add(nuevoPaciente);
                context.SaveChanges();



                /////////////////////
                ///
                var nuevoPersonal = new Persona
                {
                    Dni = "12345678",
                    Nombre = "Esteban",
                    Apellido = "Perez",
                    Sexo = 'M',
                    Telefono = "1234567890",
                    Email = "juan.perez@example.com",
                    Domicilio = "Calle Falsa 123",
                    FechaNacimiento = new DateTime(1980, 1, 1),
                    Nacionalidad = "Argentina"
                };

                context.Personas.Add(nuevoPersonal);
                context.SaveChanges();


                var nuevoEmpleado = new Empleado
                {
                    Username = "rapa",
                    Password = "sese",
                    FechaAlta = DateTime.Now,
                    Salario = 10000,
                    IdPersona = nuevoPersonal.IdPersona,
                    Persona = nuevoPersonal
                };

                context.Empleados.Add(nuevoEmpleado);
                context.SaveChanges();

                var nuevoRecepcionista = new Recepcionista
                {
                    IdEmpleado = nuevoEmpleado.IdEmpleado,
                    Empleado = nuevoEmpleado
                };

                context.Recepcionistas.Add(nuevoRecepcionista);
                context.SaveChanges();

                var nuevoMedico = new Medico
                {
                    IdEmpleado = nuevoEmpleado.IdEmpleado,
                    Especialidad = "Odontologia",
                    Empleado = nuevoEmpleado
                };

                context.Medicos.Add(nuevoMedico);
                context.SaveChanges();

                */

        }

        /*
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
        */


    
    }
}
