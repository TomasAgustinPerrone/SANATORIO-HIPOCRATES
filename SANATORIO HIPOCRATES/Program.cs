using System;
using System.Windows.Forms;
using SANATORIO_HIPOCRATES.Formularios;

namespace SANATORIO_HIPOCRATES
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


    }
}
