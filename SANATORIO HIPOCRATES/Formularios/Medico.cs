using iTextSharp.text.pdf;
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
    public partial class Medico : Form
    {
        //MOVIMIENTO DE VENTANA
        private bool mouseDown;
        private Point lastLocation;
        public Medico()
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(diagnostico.Text))
            {
                return;
            }


            Recepcionista recepcionista = new Recepcionista();

            DateTime fechaMasAntigua = DateTime.Now; // Inicializar con la fecha actual
            dynamic itemConFechaMasAntigua = null;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    dynamic item = row.DataBoundItem;
                    DateTime fechaCreacion = item.FechaCreacion;

                    if (fechaCreacion < fechaMasAntigua)
                    {
                        fechaMasAntigua = fechaCreacion;
                        itemConFechaMasAntigua = item;
                    }
                }
            }

            if (itemConFechaMasAntigua != null)
            {
                recepcionista.EliminarTurno(itemConFechaMasAntigua.IdPaciente);
            }
            else
            {
                MessageBox.Show("Ya no quedan turnos pendientes por atender!");
            }


            //EXPEDIR DIAGNOSTICO

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Seleccione la ubicación para guardar el archivo PDF";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                using (FileStream stream = new FileStream(path, FileMode.Create))
                {
                    Document doc = new Document();
                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();
                    doc.Add(new Paragraph("Sanatorio Hipocrates \n" +
                        "Avenida Independencia 1127, CABA" +
                        "\n___________________________________________________________________" +
                        "\n\nFecha: " + DateTime.Now +
                        "\n\n" +
                        "ID del paciente: " + itemConFechaMasAntigua.IdPaciente + ". DNI: " + itemConFechaMasAntigua.Dni +
                        "\n\n\n Diagnostico: \n" +
                        diagnostico.Text
                        ));
                    doc.Close();
                }

            }

        }

        private void Medico_Load(object sender, EventArgs e)
        {

        }

        private void resfrescar_Click(object sender, EventArgs e)
        {
            TurnoService turnoService = new TurnoService();
            PacienteService pacienteService = new PacienteService();
            PersonaService personaService = new PersonaService();
            var listaTurnoPersona = new List<object>();

            List<Turno> turnos = turnoService.mostrarTodosLosTurnos();
  
            foreach (Turno turno in turnos)
            {
                Paciente paciente = pacienteService.BuscarPacienteByIdDePaciente(turno.IdPaciente);
                Persona persona = personaService.BuscarPersonaById(paciente.IdPersona);

                var turnoConDatosPersona = new
                {
                    IdTurno = turno.IdTurno,
                    FechaCreacion = turno.FechaCreacion,
                    IdPaciente = turno.IdPaciente,
                    Nombre = persona.Nombre,
                    Apellido = persona.Apellido,
                    Dni = persona.Dni,
                    Sexo = persona.Sexo,
                    FechaNac = persona.FechaNacimiento,
                    ObraSocial = paciente.ObraSocial,
                    NroCarnet = paciente.NumeroCarnet
                };

                listaTurnoPersona.Add(turnoConDatosPersona);
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = listaTurnoPersona;
        }

        private void LlamarPaciente_Click(object sender, EventArgs e)
        {
            List<Object> llamador = new List<object>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    var dataBoundItem = row.DataBoundItem;
                    dynamic item = dataBoundItem;

                    var turnoLlamador = new
                    {
                        IdTurno = item.IdTurno,
                        Nombre = item.Nombre,
                        Apellido = item.Apellido,
                        DNI = item.Dni
                    };
                    llamador.Add(turnoLlamador);
                    break;
                }
            }

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = llamador;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
