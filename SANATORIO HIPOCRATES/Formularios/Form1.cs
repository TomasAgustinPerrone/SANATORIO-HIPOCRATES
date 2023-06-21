using SANATORIO_HIPOCRATES.Excepciones;
using SANATORIO_HIPOCRATES.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SANATORIO_HIPOCRATES.Formularios
{
    public partial class Form1 : Form
    {
        //MOVIMIENTO DE VENTANA
        private bool mouseDown;
        private Point lastLocation;
        public Form1()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
                txtContra.UseSystemPasswordChar = true;
            }
        }

        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text =="")
            {
                txtContra.Text = "Contraseña";
                txtContra.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registrarUsuario_Click(object sender, EventArgs e)
        {
            RegistrarEmpleado registrarEmpleado = new RegistrarEmpleado();
            registrarEmpleado.ShowDialog();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginService login = new LoginService();
                if (login.IniciarSesion(txtUser.Text, txtContra.Text))
                {
                    MessageBox.Show("Sesión iniciada con éxito");
                    Recepcion recepcion = new Recepcion();
                    recepcion.Show();
                    this.Hide();
                } 
                else
                {
                    MessageBox.Show("La contraseña es incorrecta. Intentelo nuevamente");
                }
            }
            catch (ElementoNoEncontrado) {
                MessageBox.Show("El usuario no existe. Intentelo nuevamente");
            }
            
    
        }
    }
}
