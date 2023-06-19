using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SANATORIO_HIPOCRATES.Entidades
{
    public class MedicoPersonal
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

        public MedicoPersonal()
        {

        }

        public MedicoPersonal(string especialidad, Empleado empleado)
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
