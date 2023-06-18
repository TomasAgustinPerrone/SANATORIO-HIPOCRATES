using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Entidades
{
    public class Paciente
    {

        private long idPaciente;
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
        public long IdPaciente { get => idPaciente; set => idPaciente = value; }

        public long IdPersona { get; set; }


        public string ObraSocial { get => obraSocial; set => obraSocial = value; }
        public long NumeroCarnet { get => numeroCarnet; set => numeroCarnet = value; }

        [ForeignKey("IdPersona")]
        public Persona Persona { get => persona; set => persona = value; }

    }
}
