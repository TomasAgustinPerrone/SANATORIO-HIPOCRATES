using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;

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
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //EXPEDIR DIAGNOSTICO

            //Document doc = new Document();
            //PdfWriter.GetInstance(doc, new FileStream($"{turnos[0].IdPaciente}_turno.pdf", FileMode.Create));
            //doc.Open();
            //doc.Add(new Paragraph("Sanatorio Hipocrates \n" +
            //    "Avenida Independencia 1127, CABA" +
            //    "\n___________________________________________________________________" +
            //    "\n\nFecha:" + DateTime.Now +
            //    "\n\n" +
            //    "ID del paciente: " + turnos[0].IdPaciente + "Nro de turno: " + turnos[0].IdTurno +
            //    "QUE DICE LA BAAAAAAAAAANDA"
            //    ));
            //doc.Close();
        }

        private void Medico_Load(object sender, EventArgs e)
        {

        }
    }
}
