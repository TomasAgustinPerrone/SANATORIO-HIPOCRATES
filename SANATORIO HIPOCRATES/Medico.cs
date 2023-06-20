using System;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES
{
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool isMaximized = false;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal; // Restaura la ventana al tamaño normal
                isMaximized = false;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; // Maximiza la ventana
                isMaximized = true;
            }
        }
    }
}
