using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Persona
    {

        private long idPersona;
        private long dni;
        private string nombre;
        private string apellido;
        private char sexo;
        private string telefono;
        private string email;
        private string domicilio;
        private DateTime fechaNacimiento;
        private string nacionalidad;

        
        public void CalcularEdad()
        {

        }

 
        public Persona()
        {
        }

        public Persona(long idPersona, long dni, string nombre, string apellido, char sexo, string telefono, string email, string domicilio, DateTime fechaNacimiento, string nacionalidad)
        {
            this.idPersona = idPersona;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.telefono = telefono;
            this.email = email;
            this.domicilio = domicilio;
            this.fechaNacimiento = fechaNacimiento;
            this.nacionalidad = nacionalidad;

        }


        public override string ToString()
        {
            return $"ID: {IdPersona}, DNI: {Dni}, Nombre: {Nombre}, Apellido: {Apellido}, Sexo: {Sexo}, Telefono: {Telefono}, Email: {Email}, Domicilio: {Domicilio}, Fecha de Nacimiento: {FechaNacimiento}, Nacionalidad: {Nacionalidad}";
        }

        [Key]
        public long IdPersona { get => idPersona; set => idPersona = value; }


        public long Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public char Sexo { get => sexo; set => sexo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
    }


}
