using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.textBox_contrasena = new System.Windows.Forms.TextBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar_login = new System.Windows.Forms.PictureBox();
            this.btn_minimizar_login = new System.Windows.Forms.PictureBox();
            this.btn_registrar_usuario = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar_login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.pictureBox1.Location = new System.Drawing.Point(371, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_usuario.Location = new System.Drawing.Point(402, 157);
            this.textBox_usuario.Multiline = true;
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(235, 37);
            this.textBox_usuario.TabIndex = 1;
            this.textBox_usuario.Text = "USUARIO";
            this.textBox_usuario.Enter += new System.EventHandler(this.textBox_usuario_Enter);
            this.textBox_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_usuario_KeyPress_1);
            this.textBox_usuario.Leave += new System.EventHandler(this.textBox_usuario_Leave);
            // 
            // textBox_contrasena
            // 
            this.textBox_contrasena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contrasena.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox_contrasena.Location = new System.Drawing.Point(402, 223);
            this.textBox_contrasena.Multiline = true;
            this.textBox_contrasena.Name = "textBox_contrasena";
            this.textBox_contrasena.Size = new System.Drawing.Size(235, 37);
            this.textBox_contrasena.TabIndex = 2;
            this.textBox_contrasena.Text = "CONTRASEÑA";
            this.textBox_contrasena.Enter += new System.EventHandler(this.textBox_contrasena_Enter);
            this.textBox_contrasena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_contrasena_KeyPress);
            this.textBox_contrasena.Leave += new System.EventHandler(this.textBox_contrasena_Leave_1);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.FlatAppearance.BorderSize = 0;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ingresar.Location = new System.Drawing.Point(414, 291);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(214, 36);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "INGRESAR";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // btn_cerrar_login
            // 
            this.btn_cerrar_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_login.Image = global::Presentacion.Properties.Resources.image_removebg_preview__1_;
            this.btn_cerrar_login.Location = new System.Drawing.Point(961, 51);
            this.btn_cerrar_login.Name = "btn_cerrar_login";
            this.btn_cerrar_login.Size = new System.Drawing.Size(29, 27);
            this.btn_cerrar_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar_login.TabIndex = 5;
            this.btn_cerrar_login.TabStop = false;
            this.btn_cerrar_login.Click += new System.EventHandler(this.btn_cerrar_login_Click);
            // 
            // btn_minimizar_login
            // 
            this.btn_minimizar_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar_login.Image = global::Presentacion.Properties.Resources.image_removebg_preview__2_;
            this.btn_minimizar_login.Location = new System.Drawing.Point(901, 51);
            this.btn_minimizar_login.Name = "btn_minimizar_login";
            this.btn_minimizar_login.Size = new System.Drawing.Size(29, 27);
            this.btn_minimizar_login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar_login.TabIndex = 6;
            this.btn_minimizar_login.TabStop = false;
            this.btn_minimizar_login.Click += new System.EventHandler(this.btn_minimizar_login_Click);
            // 
            // btn_registrar_usuario
            // 
            this.btn_registrar_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btn_registrar_usuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_usuario.FlatAppearance.BorderSize = 0;
            this.btn_registrar_usuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_registrar_usuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_registrar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_usuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_registrar_usuario.Location = new System.Drawing.Point(742, 51);
            this.btn_registrar_usuario.Name = "btn_registrar_usuario";
            this.btn_registrar_usuario.Size = new System.Drawing.Size(125, 27);
            this.btn_registrar_usuario.TabIndex = 8;
            this.btn_registrar_usuario.Text = "REGISTRATE";
            this.btn_registrar_usuario.UseVisualStyleBackColor = false;
            this.btn_registrar_usuario.Click += new System.EventHandler(this.btn_registrar_usuario_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(812, 346);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Prueba";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 587);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btn_registrar_usuario);
            this.Controls.Add(this.btn_minimizar_login);
            this.Controls.Add(this.btn_cerrar_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.textBox_contrasena);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar_login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_usuario;
        private TextBox textBox_contrasena;
        private Button btn_ingresar;
        private Label label1;
        private PictureBox btn_cerrar_login;
        private PictureBox btn_minimizar_login;
        private Button btn_registrar_usuario;
        private ErrorProvider errorProvider1;
        private Button btnTest;
    }
}
