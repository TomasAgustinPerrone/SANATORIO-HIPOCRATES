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
    public class MedicoService
    {
        ConexionService conexionService = new ConexionService();

        public MedicoPersonal BuscarMedicoById(long idMedico)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var medicoExistente = context.Medicos.FirstOrDefault(p => p.IdMedico == idMedico);

                if (medicoExistente != null)
                {
                    return medicoExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un medico registrado con el id medico: " + idMedico);
                }
            }
        }

        public MedicoPersonal BuscarMedicoByIdEmpleado(long idEmpleado)
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var medicoExistente = context.Medicos.FirstOrDefault(p => p.IdEmpleado == idEmpleado);

                if (medicoExistente != null)
                {
                    return medicoExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un medico registrado con el id empleado: " + idEmpleado);
                }
            }
        }


        public MedicoPersonal CrearRecepcionista(Empleado empleado)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {

                try
                {
                    MessageBox.Show($"Verificando la existencia de recepcionista id: {empleado.IdEmpleado}");
                    var medicoExistente = BuscarMedicoByIdEmpleado(empleado.IdEmpleado);
                    MessageBox.Show($"El medico con el id empleado {empleado.IdEmpleado} ya está registrado en la base");
                    return medicoExistente;
                }
                catch (ElementoNoEncontrado e)
                {
                    MessageBox.Show(e.Message);
                    var nuevoMedico = new MedicoPersonal
                    {
                        IdEmpleado = empleado.IdEmpleado
                    };

                    context.Medicos.Add(nuevoMedico);
                    MessageBox.Show("Se ha creado un empleado nuevo");
                    context.SaveChanges();
                    return nuevoMedico;
                }

            }
        }
    }
