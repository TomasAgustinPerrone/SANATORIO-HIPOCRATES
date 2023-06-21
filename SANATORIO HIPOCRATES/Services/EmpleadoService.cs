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
    public class EmpleadoService
    {

        ConexionService conexionService = new ConexionService();


        public Empleado BuscarEmpleadoByIdDePersona(long idPersona)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var empleadoExistente = context.Empleados.FirstOrDefault(p => p.IdPersona == idPersona);

                if (empleadoExistente != null)
                {
                    return empleadoExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un empleado registrado con el id persona: " + idPersona);
                }
            }
        }

        public Empleado BuscarEmpleadoByIdEmpleado(long idEmpleado)
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var empleadoExistente = context.Empleados.FirstOrDefault(p => p.IdEmpleado == idEmpleado);

                if (empleadoExistente != null)
                {
                    return empleadoExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un empleado registrado con el id empleado: " + idEmpleado);
                }
            }
        }

        public Empleado BuscarEmpleadoByUsername(string username)
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var empleadoExistente = context.Empleados.FirstOrDefault(p => p.Username == username);

                if (empleadoExistente != null)
                {
                    return empleadoExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un empleado registrado con el username: " + username);
                }
            }
        }


        public Empleado CrearEmpleado(string username, string password, DateTime fechaAlta, double salario, string sector, Persona persona)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {

                try
                {
                    MessageBox.Show($"Verificando la existencia de username: {username}");
                    var empleadoExistente = BuscarEmpleadoByUsername(username);
                    MessageBox.Show($"El empleado con el username {username} ya está registrado en la base");
                    return empleadoExistente;
                }
                catch (ElementoNoEncontrado e)
                {
                    MessageBox.Show(e.Message);

                    string passwordEncriptada = EncriptacionPassword.GenerarHash(password.Trim());

                    var nuevoEmpleado = new Empleado
                    {
                        Username = username,
                        Password = passwordEncriptada,
                        FechaAlta = DateTime.Now,
                        Salario = salario,
                        IdPersona = persona.IdPersona
                    };

                    context.Empleados.Add(nuevoEmpleado);
                    context.SaveChanges();

                    if (sector == "Recepcion")
                    {
                        var nuevoRecepcionista = new Recepcionista
                        {
                            IdEmpleado = nuevoEmpleado.IdEmpleado
                        };
                        context.Recepcionistas.Add(nuevoRecepcionista);
                        context.SaveChanges();
                    }
                    else if(sector == "Medico")
                    {
                        var nuevoMedico = new MedicoPersonal
                        {
                            IdEmpleado = nuevoEmpleado.IdEmpleado
                        };
                        context.Medicos.Add(nuevoMedico);
                        context.SaveChanges();
                    }

                    MessageBox.Show("Se ha creado un empleado nuevo");
                    return nuevoEmpleado;
                }

            }
        }
    }
}
