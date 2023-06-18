using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    internal class Medico : Empleado
    {
        private long idMedico;
        private string especialidad;

        public void AtenderPaciente()
        {

        }

        public void GenerarCertificado()
        {

        }

        public Medico()
        {

        }


        public Medico(long idPersona, string dni, string nombre, string apellido, string sexo, string telefono, string email, string domicilio, DateTime fechaNacimiento, string nacionalidad, long idEmpleado, string username, string password, DateTime fechaAlta, double salario, long idMedico, string especialidad) : base(idPersona, dni, nombre, apellido, sexo, telefono, email, domicilio, fechaNacimiento, nacionalidad, idEmpleado, username, password, fechaAlta, salario)
        {
            this.idMedico = idMedico;
            this.especialidad = especialidad;
        }

        public long IdMedico { get => idMedico; set => idMedico = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }


        public override string ToString()
        {
            return base.ToString() + $", ID Medico: {IdMedico}, Especialidad: {Especialidad}";
        }
    }
}
