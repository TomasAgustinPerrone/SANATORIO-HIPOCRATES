using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Paciente : Persona
    {

        private long idPaciente;
        private string obraSocial;
        private long numeroCarnet;

        public Paciente()
        {
        }


        public Paciente(long idPersona, string dni, string nombre, string apellido, string sexo, string telefono, string email, string domicilio, DateTime fechaNacimiento, string nacionalidad, long idPaciente, string obraSocial, long numeroCarnet) : base(idPersona, dni, nombre, apellido, sexo, telefono, email, domicilio, fechaNacimiento, nacionalidad)
        {
            this.idPaciente = idPaciente;
            this.obraSocial = obraSocial;
            this.numeroCarnet = numeroCarnet;
        }


        public long IdPaciente { get => idPaciente; set => idPaciente = value; }


        public string ObraSocial { get => obraSocial; set => obraSocial = value; }
        public long NumeroCarnet { get => numeroCarnet; set => numeroCarnet = value; }


        public override string ToString()
        {
            return base.ToString() + $", {nameof(IdPaciente)}: {IdPaciente}, {nameof(ObraSocial)}: {ObraSocial}, {nameof(NumeroCarnet)}: {NumeroCarnet}";
        }
    }
}
