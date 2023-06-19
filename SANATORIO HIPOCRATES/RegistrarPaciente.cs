using SANATORIO_HIPOCRATES.Entidades;
using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES
{
    public partial class RegistrarPaciente : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public RegistrarPaciente()
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;
            this.MouseMove += Form1_MouseMove;
            this.MouseUp += Form1_MouseUp;
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recepcionista recepcionista = new Recepcionista();

            if (string.IsNullOrEmpty(inputDNI.Text) ||
                string.IsNullOrEmpty(inputNombre.Text) ||
                string.IsNullOrEmpty(inputApellido.Text) ||
                string.IsNullOrEmpty(inputMail.Text) ||
                string.IsNullOrEmpty(inputNacionalidad.Text) ||
                string.IsNullOrEmpty(inputSexo.Text) ||
                string.IsNullOrEmpty(inputTlf.Text) ||
                string.IsNullOrEmpty(inputDomicilio.Text) ||
                string.IsNullOrEmpty(inputFechaNac.Text) ||
                string.IsNullOrEmpty(inputObraSocial.Text) ||
                string.IsNullOrEmpty(inputCarnet.Text))
            {
                MessageBox.Show("Por favor, rellene todos los campos.");
                return;
            }

            string nombre = inputNombre.Text;
            string apellido = inputApellido.Text;
            string email = inputMail.Text;
            string nacionalidad = inputNacionalidad.Text;
            char sexo = char.ToUpper(inputSexo.Text[0]);
            string telefono = inputTlf.Text;
            string domicilio = inputDomicilio.Text;
            string fechaComoCadena = inputFechaNac.Text;
            string obraSocial = inputObraSocial.Text;

            if (!long.TryParse(inputDNI.Text, out long dni))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el DNI.");
                return;
            }

            if (!long.TryParse(inputCarnet.Text, out long numeroCarnet))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el carnet.");
                return;
            }

            // Validación del formato de fecha.
            if (!DateTime.TryParseExact(fechaComoCadena, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida (dd-MM-yyyy).");
                return;
            }

            // Validación del formato de correo electrónico.
            if (!Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$"))
            {
                MessageBox.Show("Por favor, ingrese una dirección de correo electrónico válida.");
                return;
            }

            // Validación del sexo.
            if (!(sexo == 'F' || sexo == 'M'))
            {
                MessageBox.Show("Por favor, ingrese un sexo válido (F o M).");
                return;
            }


            recepcionista.CrearPersona(dni, nombre, apellido, sexo, telefono, email, domicilio, fecha, nacionalidad, obraSocial, numeroCarnet);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputDNI.Text = "";
            inputNombre.Text = "";
            inputApellido.Text = "";
            inputMail.Text = "";
            inputNacionalidad.Text = "";
            inputSexo.Text = "";
            inputTlf.Text = "";
            inputDomicilio.Text = "";
            inputFechaNac.Text = "";
            inputObraSocial.Text = "";
            inputCarnet.Text = "";
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
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RegistrarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inputNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void inputSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void inputTlf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void inputDomicilio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void inputCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void inputDNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
