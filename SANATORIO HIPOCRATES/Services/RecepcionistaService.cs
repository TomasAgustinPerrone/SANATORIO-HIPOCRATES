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
    public class RecepcionistaService
    {
        ConexionService conexionService = new ConexionService();

        public Recepcionista BuscarRecepcionistaById(long idRecepcionista)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var recepcionistaExistente = context.Recepcionistas.FirstOrDefault(p => p.IdRecepcionista == idRecepcionista);

                if (recepcionistaExistente != null)
                {
                    return recepcionistaExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un recepcionista registrado con el id recepcionista: " + idRecepcionista);
                }
            }
        }

        public Recepcionista BuscarRecepcionistaByIdEmpleado(long idEmpleado)
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var recepcionistaExistente = context.Recepcionistas.FirstOrDefault(p => p.IdEmpleado == idEmpleado);

                if (recepcionistaExistente != null)
                {
                    return recepcionistaExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un recepcionista registrado con el id empleado: " + idEmpleado);
                }
            }
        }


        public Recepcionista CrearRecepcionista(Empleado empleado)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {

                try
                {
                    MessageBox.Show($"Verificando la existencia de recepcionista id: {empleado.IdEmpleado}");
                    var recepcionistaExistente = BuscarRecepcionistaByIdEmpleado(empleado.IdEmpleado);
                    MessageBox.Show($"El empleado con el id empleado {empleado.IdEmpleado} ya está registrado en la base");
                    return recepcionistaExistente;
                }
                catch (ElementoNoEncontrado e)
                {
                    MessageBox.Show(e.Message);
                    var nuevoRecepcionista = new Recepcionista
                    {
                        IdEmpleado = empleado.IdEmpleado
                    };

                    context.Recepcionistas.Add(nuevoRecepcionista);
                    MessageBox.Show("Se ha creado un empleado nuevo");
                    context.SaveChanges();
                    return nuevoRecepcionista;
                }

            }
        }
    }
}
