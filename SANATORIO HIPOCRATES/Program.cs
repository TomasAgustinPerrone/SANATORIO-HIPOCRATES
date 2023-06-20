using System;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            /*
            Recepcionista recepcionistaLaburando = new Recepcionista();
            recepcionistaLaburando.CrearPersona("37044040", "Pablo", "Moyano", 'M', "1234567890",
                            "tommi@example.com", "Calle Falsa 123",
                            new DateTime(1996, 03, 10), "Argentina", "Galeno", 140240);

            */


            /*
            recepcionistaLaburando.CrearTurno("4540540", "Julian", "Fernandez", 'M', "1234567890",
                            "tommi@example.com", "Calle Falsa 123",
                            new DateTime(1996, 03, 10), "Argentina", "Galeno", 54240240);


            TurnoService turnoService = new TurnoService();
            List<Turno> turnosEnCola = turnoService.mostrarTodosLosTurnos();
            foreach (Turno turno in turnosEnCola)
            {
                MessageBox.Show($" Turnos en cola: {turno.ToString()}.");
            }
            */

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistrarPaciente());
        }


    }
}
