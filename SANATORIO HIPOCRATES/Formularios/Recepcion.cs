﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using SANATORIO_HIPOCRATES.Entidades;
using SANATORIO_HIPOCRATES.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SANATORIO_HIPOCRATES.Formularios
{
    public partial class Recepcion : Form
    {
        //MOVIMIENTO DE VENTANA
        private bool mouseDown;
        private Point lastLocation;
        public Recepcion()
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
        //FIN MOVIMIENTO DE VENTANA
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listaTurnos_TextChanged(object sender, EventArgs e)
        {

        }

        //BOTON BUSCAR POR DNI
        private void button4_Click(object sender, EventArgs e)
        {
            PersonaService personaService = new PersonaService();
            Persona persona = personaService.BuscarPersonaEnDB(long.Parse(inputDNI.Text));
            PacienteService pacienteService = new PacienteService();
            Paciente paciente = pacienteService.BuscarPacienteByIdDePersona(persona.IdPersona);

            var personaPaciente = new
            {
                IdPersona = persona.IdPersona,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Domicilio = persona.Domicilio,
                Dni = persona.Dni,
                Sexo = persona.Sexo,
                Telefono = persona.Telefono,
                Email = persona.Email,
                Nacionalidad = persona.Nacionalidad,
                FechaNac = persona.FechaNacimiento,
                IdPaciente = paciente.IdPaciente,
                ObraSocial = paciente.ObraSocial,
                NroCarnet = paciente.NumeroCarnet
            };

            var listaPersonaPaciente = new List<object> { personaPaciente };

            dataGridPacientes.AutoGenerateColumns = true;
            dataGridPacientes.DataSource = listaPersonaPaciente;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //BUSCAR EL PACIENTE POR CARNET
        private void buscarPacientePorCarnet_Click(object sender, EventArgs e)
        {

            PacienteService pacienteService = new PacienteService();
            Paciente paciente = pacienteService.BuscarPacienteByNroCarnet(long.Parse(inputCarnet.Text) ); 

            PersonaService personaService = new PersonaService();
            Persona persona = personaService.BuscarPersonaById(paciente.IdPersona);

            var result = new
            {
                IdPersona = persona.IdPersona,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Domicilio = persona.Domicilio,
                Dni = persona.Dni,
                Sexo = persona.Sexo,
                Telefono = persona.Telefono,
                Email = persona.Email,
                Nacionalidad = persona.Nacionalidad,
                FechaNac = persona.FechaNacimiento,
                IdPaciente = paciente.IdPaciente,
                ObraSocial = paciente.ObraSocial,
                NroCarnet = paciente.NumeroCarnet
            };

            var resultList = new List<object> { result };

            dataGridPacientes.AutoGenerateColumns = true;
            dataGridPacientes.DataSource = resultList;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //BOTON GENERA TURNO 
        private void generarTurno_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridPacientes.Rows)
            {
                if (!row.IsNewRow)
                {
                    var dataBoundItem = row.DataBoundItem;
                    dynamic item = dataBoundItem;

                    Recepcionista recepcionista = new Recepcionista();

                    long idPaciente = item.IdPaciente;
                    recepcionista.CrearTurno(idPaciente);
                }
            }

            TurnoService turnoService = new TurnoService();
            List<Turno> turnos = turnoService.mostrarTodosLosTurnos();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = turnos;

        }
        //BOTON REFRESCAR
        private void refrescar_Click(object sender, EventArgs e)
        {
            TurnoService turnoService = new TurnoService();
            List<Turno> turnos = turnoService.mostrarTodosLosTurnos();

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = turnos;
        }
        private void inputCarnet_TextChanged(object sender, EventArgs e)
        {

        }

        //REGISTRAR PACIENTE
        private void button5_Click(object sender, EventArgs e)
        {
            RegistrarPaciente registrarPaciente = new RegistrarPaciente();
            registrarPaciente.Show();
        }

        //DETALLE VENTANA
        //Boton cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        //Boton minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }  
        //FIN DETALLE VENTANA

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Recepcion_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void interfazMedico_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Show();
            this.Close();
        }
    }
}
