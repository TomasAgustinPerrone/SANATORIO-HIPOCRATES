using SANATORIO_HIPOCRATES.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES.Formularios
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
            this.Close();
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
                string.IsNullOrEmpty(inputUsername.Text) ||
                string.IsNullOrEmpty(inputPassword.Text) ||
                string.IsNullOrEmpty(inputFechaAlta.Text) ||
                string.IsNullOrEmpty(inputSalario.Text))
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
            string fechaNacComoCadena = inputFechaNac.Text;
            string username = inputUsername.Text;
            string password = inputPassword.Text;
            string fechaAltaComoCadena = inputFechaAlta.Text;

            //VALIDACIONES DEL SISTEMA
            if (!long.TryParse(inputDNI.Text, out long dni))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el DNI.");
                return;
            }

            //Validacion numero de carnet.
            if (!long.TryParse(inputSalario.Text, out long salarioEmpleado))
            {
                MessageBox.Show("Por favor, ingrese un número válido para el carnet.");
                return;
            }

            // Validación del formato de fecha.
            if (!DateTime.TryParseExact(fechaNacComoCadena, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaNac))
            {
                MessageBox.Show("Por favor, ingrese una fecha válida (dd-MM-yyyy).");
                return;
            }

            if (!DateTime.TryParseExact(fechaAltaComoCadena, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaAlta))
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

            string sectorSeleccionado = null;
            if (comboBox1.SelectedItem != null)
            {
                sectorSeleccionado = comboBox1.SelectedItem.ToString();
                MessageBox.Show(sectorSeleccionado);
            }

            recepcionista.CrearEmpleado(dni, nombre, apellido, sexo, telefono, email, domicilio, fechaNac, nacionalidad, username, password, fechaAlta, salarioEmpleado, sectorSeleccionado);

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
            inputUsername.Text = "";
            inputPassword.Text = "";
            inputSalario.Text = "";
            inputFechaAlta.Text = "";
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
