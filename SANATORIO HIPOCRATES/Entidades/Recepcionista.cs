using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Recepcionista
    {
        private Empleado empleado;

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

        public Recepcionista(Empleado empleado)
        {
            this.empleado = empleado;
        }

        [Key]
        public long IdEmpleado { get; set; }

        public Empleado Empleado { get => empleado; set => empleado = value; }

        public override string ToString()
        {
            return $"ID Empleado: {IdEmpleado}";
        }
    }

}
