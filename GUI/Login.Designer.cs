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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            textBox_usuario = new TextBox();
            textBox_contrasena = new TextBox();
            btn_ingresar = new Button();
            label1 = new Label();
            btn_cerrar_login = new PictureBox();
            btn_minimizar_login = new PictureBox();
            link_olvidaste_contraseña = new LinkLabel();
            btn_registrar_usuario = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar_login).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar_login).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            pictureBox1.Location = new Point(325, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox_usuario
            // 
            textBox_usuario.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_usuario.ForeColor = SystemColors.ControlDark;
            textBox_usuario.Location = new Point(352, 147);
            textBox_usuario.Multiline = true;
            textBox_usuario.Name = "textBox_usuario";
            textBox_usuario.Size = new Size(206, 35);
            textBox_usuario.TabIndex = 1;
            textBox_usuario.Text = "USUARIO";
            textBox_usuario.Enter += textBox_usuario_Enter;
            textBox_usuario.Leave += textBox_usuario_Leave;
            // 
            // textBox_contrasena
            // 
            textBox_contrasena.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_contrasena.ForeColor = SystemColors.ControlDark;
            textBox_contrasena.Location = new Point(352, 209);
            textBox_contrasena.Multiline = true;
            textBox_contrasena.Name = "textBox_contrasena";
            textBox_contrasena.Size = new Size(206, 35);
            textBox_contrasena.TabIndex = 2;
            textBox_contrasena.Text = "CONTRASEÑA";
            textBox_contrasena.Enter += textBox_contrasena_Enter;
            textBox_contrasena.Leave += textBox_contrasena_Leave;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.FromArgb(0, 74, 163);
            btn_ingresar.Cursor = Cursors.Hand;
            btn_ingresar.FlatAppearance.BorderSize = 0;
            btn_ingresar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_ingresar.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_ingresar.FlatStyle = FlatStyle.Flat;
            btn_ingresar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ingresar.ForeColor = SystemColors.HighlightText;
            btn_ingresar.Location = new Point(362, 273);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(187, 34);
            btn_ingresar.TabIndex = 3;
            btn_ingresar.Text = "INGRESAR";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(47, 51);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // btn_cerrar_login
            // 
            btn_cerrar_login.BackColor = Color.Transparent;
            btn_cerrar_login.Cursor = Cursors.Hand;
            btn_cerrar_login.Image = Properties.Resources.image_removebg_preview__1_;
            btn_cerrar_login.Location = new Point(841, 48);
            btn_cerrar_login.Name = "btn_cerrar_login";
            btn_cerrar_login.Size = new Size(25, 25);
            btn_cerrar_login.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_cerrar_login.TabIndex = 5;
            btn_cerrar_login.TabStop = false;
            btn_cerrar_login.Click += btn_cerrar_Click;
            // 
            // btn_minimizar_login
            // 
            btn_minimizar_login.BackColor = Color.Transparent;
            btn_minimizar_login.Cursor = Cursors.Hand;
            btn_minimizar_login.Image = Properties.Resources.image_removebg_preview__2_;
            btn_minimizar_login.Location = new Point(788, 48);
            btn_minimizar_login.Name = "btn_minimizar_login";
            btn_minimizar_login.Size = new Size(25, 25);
            btn_minimizar_login.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_minimizar_login.TabIndex = 6;
            btn_minimizar_login.TabStop = false;
            btn_minimizar_login.Click += btn_minimizar_Click;
            // 
            // link_olvidaste_contraseña
            // 
            link_olvidaste_contraseña.ActiveLinkColor = SystemColors.MenuHighlight;
            link_olvidaste_contraseña.AutoSize = true;
            link_olvidaste_contraseña.BackColor = Color.Transparent;
            link_olvidaste_contraseña.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            link_olvidaste_contraseña.Location = new Point(375, 334);
            link_olvidaste_contraseña.Name = "link_olvidaste_contraseña";
            link_olvidaste_contraseña.Size = new Size(160, 16);
            link_olvidaste_contraseña.TabIndex = 7;
            link_olvidaste_contraseña.TabStop = true;
            link_olvidaste_contraseña.Text = "¿Olvidaste la Contraseña?";
            // 
            // btn_registrar_usuario
            // 
            btn_registrar_usuario.BackColor = Color.FromArgb(0, 74, 163);
            btn_registrar_usuario.Cursor = Cursors.Hand;
            btn_registrar_usuario.FlatAppearance.BorderSize = 0;
            btn_registrar_usuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_registrar_usuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_registrar_usuario.FlatStyle = FlatStyle.Flat;
            btn_registrar_usuario.ForeColor = SystemColors.HighlightText;
            btn_registrar_usuario.Location = new Point(649, 48);
            btn_registrar_usuario.Name = "btn_registrar_usuario";
            btn_registrar_usuario.Size = new Size(109, 25);
            btn_registrar_usuario.TabIndex = 8;
            btn_registrar_usuario.Text = "REGISTRATE";
            btn_registrar_usuario.UseVisualStyleBackColor = false;
            btn_registrar_usuario.Click += btn_registrar_usuario_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 550);
            Controls.Add(btn_registrar_usuario);
            Controls.Add(link_olvidaste_contraseña);
            Controls.Add(btn_minimizar_login);
            Controls.Add(btn_cerrar_login);
            Controls.Add(label1);
            Controls.Add(btn_ingresar);
            Controls.Add(textBox_contrasena);
            Controls.Add(textBox_usuario);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            ForeColor = SystemColors.GrayText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += Login_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar_login).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar_login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox_usuario;
        private TextBox textBox_contrasena;
        private Button btn_ingresar;
        private Label label1;
        private PictureBox btn_cerrar_login;
        private PictureBox btn_minimizar_login;
        private LinkLabel link_olvidaste_contraseña;
        private Button btn_registrar_usuario;
    }
}
