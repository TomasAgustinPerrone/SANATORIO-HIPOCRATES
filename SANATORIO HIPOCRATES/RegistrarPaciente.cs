﻿using SANATORIO_HIPOCRATES.Entidades;
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
    }
}
