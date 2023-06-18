using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Turno
    {
        private long idTurno;
        private DateTime fechaCreacion;

        public Turno(long idTurno, DateTime fechaCreacion)
        {
            this.idTurno = idTurno;
            this.fechaCreacion = fechaCreacion;
        }

        public Turno()
        {
        }

        public override string ToString()
        {
            return $"Nro turno: {IdTurno}, Fecha de creación: {FechaCreacion}";
        }

        [Key]
        public long IdTurno { get => idTurno; set => idTurno = value; }

        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }

        public long IdPaciente { get; set; }

        [ForeignKey("IdPaciente")]
        public Paciente Paciente { get; set; }
    }

}
