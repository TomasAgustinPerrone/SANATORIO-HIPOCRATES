using SANATORIO_HIPOCRATES.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            */

            Persona persona = new Persona();
            persona.Apellido = "algasdasdasdasdo";
            MessageBox.Show(persona.Apellido);
            MessageBox.Show(persona.ToString() );

            Paciente paciente = new Paciente();
            paciente.Dni = "341341341";
            MessageBox.Show(paciente.Dni);
            MessageBox.Show(paciente.ToString());

            Empleado empleado = new Empleado();
            empleado.Username = "papito1";
            MessageBox.Show(empleado.ToString() );

            Medico medico = new Medico();
            medico.Especialidad = "oftalmologia";
            MessageBox.Show(medico.ToString());


        }
    }
}
