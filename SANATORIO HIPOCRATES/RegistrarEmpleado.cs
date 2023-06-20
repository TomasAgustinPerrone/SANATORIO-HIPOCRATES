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
        //MOVIMIENTO DE VENTANA
        private bool mouseDown;
        private Point lastLocation;
        public RegistrarEmpleado()
        {

            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;

            //DESPLEGABLE DE SECTOR
            comboBox1.Items.Add("Recepcion");
            comboBox1.Items.Add("Medico");
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        //FIN MOVIMIENTO DE VENTANA
        //BOTONES DE VENTANAS
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Boton minimizar
        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //FIN DETALLE VENTANA

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
            string valorSeleccionado = comboBox1.SelectedItem.ToString();
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
            comboBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14CONTRASEÑA_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
