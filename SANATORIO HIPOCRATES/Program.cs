using Microsoft.EntityFrameworkCore;
using SANATORIO_HIPOCRATES.Config;
using SANATORIO_HIPOCRATES.Entidades;
using SANATORIO_HIPOCRATES.Services;
using System;
using System.Collections.Generic;
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


            Recepcionista recepcionistaLaburando = new Recepcionista();
            recepcionistaLaburando.CrearTurno("39641779", "Tommy", "ApelldiORandom", 'M', "1234567890",
                            "tommi@example.com", "Calle Falsa 123",
                            new DateTime(1996, 03, 10), "Argentina", "Galeno", 170400);


            TurnoService turnoService = new TurnoService();
            List<Turno> turnosEnCola = turnoService.mostrarTodosLosTurnos();
            foreach (Turno turno in turnosEnCola)
            {
                MessageBox.Show($" Turnos en cola: {turno.ToString()}.");
            }

        }

        /*
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
        */


    
    }
}
