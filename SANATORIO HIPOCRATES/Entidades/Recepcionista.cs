using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Recepcionista : Empleado
    {

        private long idRecepcionista;

        public void CrearTurno()
        {

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

        public Recepcionista(long idPersona, string dni, string nombre, string apellido, string sexo, string telefono, string email, string domicilio, DateTime fechaNacimiento, string nacionalidad, long idEmpleado, string username, string password, DateTime fechaAlta, double salario, long idRecepcionista) : base(idPersona, dni, nombre, apellido, sexo, telefono, email, domicilio, fechaNacimiento, nacionalidad, idEmpleado, username, password, fechaAlta, salario)
        {
            this.idRecepcionista = idRecepcionista;
        }


        public long IdRecepcionista { get => idRecepcionista; set => idRecepcionista = value; }


        public override string ToString()
        {
            return base.ToString() + $", ID Recepcionista: {IdRecepcionista}";
        }

    }
}
