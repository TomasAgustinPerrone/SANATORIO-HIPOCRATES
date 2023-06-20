using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES
{
    public partial class RegistrarEmpleado : Form
    {

        public RegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2BORRAR_Click(object sender, EventArgs e)
        {
            inputDomicilio.Text = "";
            inputMail.Text = "";
            inputTlf.Text = "";
            inputSexo.Text = "";
            inputApellido.Text = "";
            inputNombre.Text = "";
            inputDNI.Text = "";
            inputFechaNac.Text = "";
            inputNacionalidad.Text = "";
            textUSUARIO.Text = "";
            textBoxCONTRASEÑA.Text = "";
            TEXSALARIO.Text = "";
            textFECHAINICIO.Text = "";
        }
    }
}
