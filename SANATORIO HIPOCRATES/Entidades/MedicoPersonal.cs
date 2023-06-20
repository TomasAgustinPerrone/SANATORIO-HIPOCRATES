using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SANATORIO_HIPOCRATES.Entidades
{
    public class MedicoPersonal
    {
        private long idMedico;
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
            this.empleado = empleado;
        }


        [Key]
        public long IdMedico { get => idMedico; set => idMedico = value; }


        public long IdEmpleado { get; set; }

        [ForeignKey("IdEmpleado")]
        public Empleado Empleado { get => empleado; set => empleado = value; }

        public override string ToString()
        {
            return $"ID Empleado: {IdEmpleado}";
        }
    }

}
