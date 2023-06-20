using SANATORIO_HIPOCRATES.Excepciones;
using SANATORIO_HIPOCRATES.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Recepcionista
    {
        private long idRecepcionista;
        private Empleado empleado;

        public void CrearPersona(long dni, string nombre, string apellido, char sexo, string telefono,
            string email, string domicilio, DateTime fechaNacimiento, string nacionalidad, string obraSocial, long nroCarnet)
        {
            PersonaService personaService = new PersonaService();
            Persona personaNueva = personaService.CrearPersona(dni, nombre, apellido, sexo, telefono,
                                    email, domicilio, fechaNacimiento, nacionalidad);

            PacienteService pacienteService = new PacienteService();
            Paciente pacienteNuevo = pacienteService.CrearPaciente(obraSocial, nroCarnet, personaNueva);
            MessageBox.Show($"El paciente {nombre} {apellido}, DNI: {dni} y nro carnet: {nroCarnet} solicita un turno.");
        }

        public void CrearEmpleado(long dni, string nombre, string apellido, char sexo, string telefono,
                            string email, string domicilio, DateTime fechaNacimiento, string nacionalidad, string username, string password, DateTime fechaAlta, double salario)
        {
            PersonaService personaService = new PersonaService();
            Persona personaNueva = personaService.CrearPersona(dni, nombre, apellido, sexo, telefono,
                                    email, domicilio, fechaNacimiento, nacionalidad);

            EmpleadoService empleadoService = new EmpleadoService();
            Empleado empleadoNuevo = empleadoService.CrearEmpleado(username, password, fechaAlta, salario, personaNueva);
            MessageBox.Show($"El paciente {nombre} {apellido}, DNI: {dni} y username: {username} solicita un turno.");
            
        }

        public void CrearTurno(long idPaciente)
        {
            TurnoService turnoService = new TurnoService();
            Turno turnoNuevo = turnoService.CrearTurnoEnDB(idPaciente);
            MessageBox.Show($"Informe al paciente que aguarde a ser llamado. " +
                $"\nSu turno es el nro {turnoNuevo.IdTurno}");
        }

        public void EliminarTurno()
        {

        }

        public void ModificarTurno()
        {

        }

        public Recepcionista()
        {

        }

        public Recepcionista(Empleado empleado)
        {
            this.empleado = empleado;
        }

        [Key]
        public long IdRecepcionista { get => idRecepcionista; set => idRecepcionista = value; }


        public long IdEmpleado { get; set; }

        [ForeignKey("IdEmpleado")]
        public Empleado Empleado { get => empleado; set => empleado = value; }

        public override string ToString()
        {
            return $"ID Empleado: {IdEmpleado}";
        }
    }

}
