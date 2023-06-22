using Microsoft.EntityFrameworkCore;
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
    public class TurnoService
    {

        ConexionService conexionService = new ConexionService();

        public Turno BuscarTurnoEnDB(long idPaciente)
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                var turnoExistente = context.Turnos.FirstOrDefault(p => p.IdPaciente == idPaciente);

                if (turnoExistente != null)
                {
                    return turnoExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No hay turnos creados para el paciente");
                }
            }
        }


        public Turno CrearTurnoEnDB(long idPaciente)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {

                try
                {
                    MessageBox.Show($"Verificando la existencia de un turno ya creado para el id de paciente: {idPaciente}");
                    var turnoExistente = BuscarTurnoEnDB(idPaciente);
                    MessageBox.Show($"Ya existe un turno para este paciente");
                    return turnoExistente;
                }
                catch (ElementoNoEncontrado e)
                {
                    MessageBox.Show(e.Message);
                    var nuevoTurno = new Turno
                    {
                        FechaCreacion = DateTime.Now,
                        IdPaciente = idPaciente
                    };

                    context.Turnos.Add(nuevoTurno);
                    MessageBox.Show("Se ha creado un turno nuevo");
                    context.SaveChanges();
                    return nuevoTurno;
                }

            }
        }

        public void EliminarTurno(long idPaciente)
        {

            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {

                try
                {
                    var turnoExistente = BuscarTurnoEnDB(idPaciente);
                    context.Turnos.Remove(turnoExistente);
                    context.SaveChanges();
                    MessageBox.Show("Se ha eliminado el turno de la lista de espera");
                }
                catch (ElementoNoEncontrado e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        public List<Turno> mostrarTodosLosTurnos()
        {
            using (var context = new Conexion(conexionService.ConexionMYSQL().Options))
            {
                return context.Turnos.ToList();
            }
        } 
    }
}
