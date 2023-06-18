using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Paciente
    {

        private string obraSocial;
        private long numeroCarnet;
        private Persona persona;

        public Paciente()
        {
        }

        public Paciente(string obraSocial, long numeroCarnet, Persona persona)
        {
            this.obraSocial = obraSocial;
            this.numeroCarnet = numeroCarnet;
            this.persona = persona;
        }


        [Key]
        public long IdPersona { get; set; }


        public string ObraSocial { get => obraSocial; set => obraSocial = value; }
        public long NumeroCarnet { get => numeroCarnet; set => numeroCarnet = value; }

        public Persona Persona { get => persona; set => persona = value; }


        /*
        public override string ToString()
        {
            return base.ToString() + $", {nameof(IdPaciente)}: {IdPaciente}, {nameof(ObraSocial)}: {ObraSocial}, {nameof(NumeroCarnet)}: {NumeroCarnet}";
        }
        */
    }
}
