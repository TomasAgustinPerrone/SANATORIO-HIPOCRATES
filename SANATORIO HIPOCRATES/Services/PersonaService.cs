using Microsoft.EntityFrameworkCore;
using SANATORIO_HIPOCRATES.Config;
using SANATORIO_HIPOCRATES.Entidades;
using SANATORIO_HIPOCRATES.Excepciones;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES.Services
{
    public class PersonaService
    {

        public DbContextOptionsBuilder<Conexion> conexionConDB()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder.UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=123456;",
                    new MySqlServerVersion(new Version(8, 0, 21))
            );

            return optionsBuilder;
        }


        public Persona BuscarPersonaEnDB(string dni)
        {
            using (var context = new Conexion(conexionConDB().Options))
            {
                var personaExistente = context.Personas.FirstOrDefault(p => p.Dni == dni);

                if(personaExistente != null)
                {
                    return personaExistente;
                }
                else
                {
                    //MessageBox.Show("No existe una persona registrada con el dni: " + dni);
                    throw new ElementoNoEncontrado("No existe una persona registrada con el dni: " + dni);
                }
            }
        }

        public Persona CrearPersona(string dni, string nombre, string apellido, char sexo, string telefono, 
            string email, string domicilio, DateTime fechaNacimiento, string nacionalidad)
        {

            using (var context = new Conexion(conexionConDB().Options))
            {
                try
                {
                    MessageBox.Show($"Verificando la existencia de DNI: {dni}");
                    var personaExistente = BuscarPersonaEnDB(dni);
                    MessageBox.Show($"La persona con DNI {dni} ya está registrada en la base");
                    return personaExistente;
                } 
                catch(ElementoNoEncontrado e)
                {
                    MessageBox.Show(e.Message);
                    var nuevaPersona = new Persona
                    {
                        Dni = dni,
                        Nombre = nombre,
                        Apellido = apellido,
                        Sexo = sexo,
                        Telefono = telefono,
                        Email = email,
                        Domicilio = domicilio,
                        FechaNacimiento = fechaNacimiento,
                        Nacionalidad = nacionalidad
                    };

                    context.Personas.Add(nuevaPersona);
                    MessageBox.Show("Se ha creado una persona nueva con el dni: " + nuevaPersona.Dni);
                    context.SaveChanges();

                    return nuevaPersona;
                }

            }
        }
    }
}
