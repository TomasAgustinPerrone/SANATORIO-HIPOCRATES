using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Medico
    {
        private long idMedico;
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
        public long IdMedico { get => idMedico; set => idMedico = value; }


        public long IdEmpleado { get; set; }

        public string Especialidad { get => especialidad; set => especialidad = value; }


        [ForeignKey("IdEmpleado")]
        public Empleado Empleado { get => empleado; set => empleado = value; }

        public override string ToString()
        {
            return $"ID Empleado: {IdEmpleado}, Especialidad: {Especialidad}";
        }
    }

}
