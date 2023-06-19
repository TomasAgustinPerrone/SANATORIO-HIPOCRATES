
namespace SANATORIO_HIPOCRATES
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.botonIngresar = new System.Windows.Forms.Button();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.linkContra = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::SANATORIO_HIPOCRATES.Properties.Resources._1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.Color.White;
            this.txtContra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtContra.Location = new System.Drawing.Point(432, 185);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(209, 23);
            this.txtContra.TabIndex = 2;
            this.txtContra.Text = "Contraseña";
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtContra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // botonIngresar
            // 
            this.botonIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botonIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonIngresar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.botonIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(123)))), ((int)(((byte)(157)))));
            this.botonIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.botonIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonIngresar.ForeColor = System.Drawing.SystemColors.Window;
            this.botonIngresar.Location = new System.Drawing.Point(432, 231);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(209, 30);
            this.botonIngresar.TabIndex = 3;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = false;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtLogin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLogin.Location = new System.Drawing.Point(496, 107);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(76, 16);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "Login";
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLogin.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txtUser.Location = new System.Drawing.Point(432, 137);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(209, 23);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Usuario";
            this.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUser.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::SANATORIO_HIPOCRATES.Properties.Resources.x_button;
            this.btnCerrar.Location = new System.Drawing.Point(775, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(13, 12);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // linkContra
            // 
            this.linkContra.ActiveLinkColor = System.Drawing.Color.SeaGreen;
            this.linkContra.AutoSize = true;
            this.linkContra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkContra.LinkColor = System.Drawing.Color.White;
            this.linkContra.Location = new System.Drawing.Point(454, 273);
            this.linkContra.Name = "linkContra";
            this.linkContra.Size = new System.Drawing.Size(157, 15);
            this.linkContra.TabIndex = 0;
            this.linkContra.TabStop = true;
            this.linkContra.Text = "?Ha olvidado su contraseña¿";
            this.linkContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkContra.VisitedLinkColor = System.Drawing.Color.Teal;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.linkContra);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.botonIngresar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.LinkLabel linkContra;
    }
}

