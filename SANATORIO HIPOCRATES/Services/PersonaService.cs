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

        ConexionService conexionService = new ConexionService();

        public Persona BuscarPersonaById(long idPersona)
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var personaExistente = context.Personas.FirstOrDefault(p => p.IdPersona == idPersona);

                if (personaExistente != null)
                {
                    return personaExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe una persona registrada con el dni: " + idPersona);
                }
            }
        }

        public Persona BuscarPersonaEnDB(long dni)
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var personaExistente = context.Personas.FirstOrDefault(p => p.Dni == dni);

                if(personaExistente != null)
                {
                    return personaExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe una persona registrada con el dni: " + dni);
                }
            }
        }

        public Persona CrearPersona(long dni, string nombre, string apellido, char sexo, string telefono, 
            string email, string domicilio, DateTime fechaNacimiento, string nacionalidad)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
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
