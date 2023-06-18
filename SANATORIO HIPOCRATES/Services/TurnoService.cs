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

        public DbContextOptionsBuilder<Conexion> conexionConDB()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder.UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=123456;",
                    new MySqlServerVersion(new Version(8, 0, 21))
            );

            return optionsBuilder;
        }

        public Turno BuscarTurnoEnDB(long idPaciente)
        {
            using (var context = new Conexion(conexionConDB().Options))
            {
                var turnoExistente = context.Turnos.FirstOrDefault(p => p.IdPaciente == idPaciente);

                if (turnoExistente != null)
                {
                    return turnoExistente;
                }
                else
                {
                    //MessageBox.Show("No existe un paciente registrado con el nro carnet: " + idPaciente);
                    throw new ElementoNoEncontrado("No hay turnos creados para el paciente");
                }
            }
        }


        public Turno CrearTurnoEnDB(Paciente paciente)
        {

            using (var context = new Conexion(conexionConDB().Options))
            {

                try
                {
                    MessageBox.Show($"Verificando la existencia de un turno ya creado para el id de paciente: {paciente.IdPaciente}");
                    var turnoExistente = BuscarTurnoEnDB(paciente.IdPaciente);
                    MessageBox.Show($"Ya existe un turno para este paciente");
                    return turnoExistente;
                }
                catch (ElementoNoEncontrado e)
                {
                    MessageBox.Show(e.Message);
                    var nuevoTurno = new Turno
                    {
                        FechaCreacion = DateTime.Now,
                        IdPaciente = paciente.IdPaciente
                    };

                    context.Turnos.Add(nuevoTurno);
                    MessageBox.Show("Se ha creado un turno nuevo");
                    context.SaveChanges();
                    return nuevoTurno;
                }

            }
        }

        public List<Turno> mostrarTodosLosTurnos()
        {
            using (var context = new Conexion(conexionConDB().Options))
            {
                return context.Turnos.ToList();
            }
        } 
    }
}
