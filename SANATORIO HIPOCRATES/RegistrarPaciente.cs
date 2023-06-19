using SANATORIO_HIPOCRATES.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SANATORIO_HIPOCRATES
{
    public partial class RegistrarPaciente : Form
    {
        public RegistrarPaciente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recepcionista recepcionista = new Recepcionista();

            string dni = inputDNI.Text;
            string nombre = inputNombre.Text;
            string apellido = inputApellido.Text;
            string email = inputMail.Text;
            string nacionalidad = inputNacionalidad.Text;
            char sexo = char.Parse(inputSexo.Text);
            string telefono = inputTlf.Text;
            string domicilio = inputDomicilio.Text;

            string fechaComoCadena = inputFechaNac.Text;
            DateTime fecha = DateTime.ParseExact(fechaComoCadena, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            string obraSocial = inputObraSocial.Text;
            long numeroCarnet = long.Parse(inputCarnet.Text);


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
    }
}
