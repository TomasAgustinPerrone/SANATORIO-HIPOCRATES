using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Empleado
    {
        private long idEmpleado;
        private string username;
        private string password;
        private DateTime fechaAlta;
        private double salario;
        private Persona persona;

        public void CalcularAntiguedad()
        {

        }

        public Empleado()
        {

        }

        public Empleado(long idEmpleado, string username, string password, DateTime fechaAlta, double salario, Persona persona)
        {
            this.idEmpleado = idEmpleado;
            this.username = username;
            this.password = password;
            this.fechaAlta = fechaAlta;
            this.salario = salario;
            this.persona = persona;
        }

        [Key]
        public long IdEmpleado { get => idEmpleado; set => idEmpleado = value; }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public double Salario { get => salario; set => salario = value; }

        public long IdPersona { get; set; }

        public Persona Persona { get => persona; set => persona = value; }

        public override string ToString()
        {
            return $"ID Empleado: {IdEmpleado}, Username: {Username}, Fecha Alta: {FechaAlta}, Salario: {Salario}";
        }
    }





}

