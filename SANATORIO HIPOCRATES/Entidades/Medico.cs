using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Medico
    {
        private string especialidad;
        private Empleado empleado;

        public void AtenderPaciente()
        {

        }

        public void GenerarCertificado()
        {

        }

        public Medico()
        {

        }

        public Medico(string especialidad, Empleado empleado)
        {
            this.especialidad = especialidad;
            this.empleado = empleado;
        }

        [Key]
        public long IdEmpleado { get; set; }

        public string Especialidad { get => especialidad; set => especialidad = value; }

        public Empleado Empleado { get => empleado; set => empleado = value; }

        public override string ToString()
        {
            return $"ID Empleado: {IdEmpleado}, Especialidad: {Especialidad}";
        }
    }

}
