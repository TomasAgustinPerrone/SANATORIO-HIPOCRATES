using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    class Empleado : Persona
    {
        private long idEmpleado;
        private string username;
        private string password;
        private DateTime fechaAlta;
        private double salario;


        public void CalcularAntiguedad()
        {

        }


        public Empleado()
        {
        }


        public Empleado(long idPersona, string dni, string nombre, string apellido, string sexo, string telefono, string email, string domicilio, DateTime fechaNacimiento, string nacionalidad, long idEmpleado, string username, string password, DateTime fechaAlta, double salario) : base(idPersona, dni, nombre, apellido, sexo, telefono, email, domicilio, fechaNacimiento, nacionalidad)
        {
            this.idEmpleado = idEmpleado;
            this.username = username;
            this.password = password;
            this.fechaAlta = fechaAlta;
            this.salario = salario;
        }

        public long IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public double Salario { get => salario; set => salario = value; }




        public override string ToString()
        {
            return base.ToString() + $", ID Empleado: {IdEmpleado}, Username: {Username}, Fecha Alta: {FechaAlta}, Salario: {Salario}";
        }



    }
}
