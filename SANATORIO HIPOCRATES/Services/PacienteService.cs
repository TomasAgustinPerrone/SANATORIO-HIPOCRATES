using Microsoft.EntityFrameworkCore;
using SANATORIO_HIPOCRATES.Config;
using SANATORIO_HIPOCRATES.Entidades;
using SANATORIO_HIPOCRATES.Excepciones;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES.Services
{
    public class PacienteService
    {

        public DbContextOptionsBuilder<Conexion> conexionConDB()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder.UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=123456;",
                    new MySqlServerVersion(new Version(8, 0, 21))
            );

            return optionsBuilder;
        }

        public Paciente BuscarPacienteEnDB(long nroCarnet)
        {
            using (var context = new Conexion(conexionConDB().Options))
            {
                var pacienteExistente = context.Pacientes.FirstOrDefault(p => p.NumeroCarnet == nroCarnet);

                if (pacienteExistente != null)
                {
                    return pacienteExistente;
                }
                else
                {
                    throw new ElementoNoEncontrado("No existe un paciente registrado con el nro carnet: " + nroCarnet);
                }
            }
        }


        public Paciente CrearPaciente(string obraSocial, long nroCarnet, Persona persona)
        {

            using (var context = new Conexion(conexionConDB().Options))
            {

                try
                {
                    MessageBox.Show($"Verificando la existencia de Nro de carnet: {nroCarnet}");
                    var pacienteExistente = BuscarPacienteEnDB(nroCarnet);
                    MessageBox.Show($"El paciente con nro carnet {nroCarnet} ya está registrado en la base");
                    return pacienteExistente;
                }
                catch(ElementoNoEncontrado e)
                {
                    MessageBox.Show(e.Message);
                    var nuevoPaciente = new Paciente
                    {
                        ObraSocial = obraSocial,
                        NumeroCarnet = nroCarnet,
                        IdPersona = persona.IdPersona
                    };

                    context.Pacientes.Add(nuevoPaciente);
                    MessageBox.Show("Se ha creado una persona nueva con el nro carnet " + nuevoPaciente.NumeroCarnet);
                    context.SaveChanges();
                    return nuevoPaciente;
                }
 
            }
        }
    }
}
