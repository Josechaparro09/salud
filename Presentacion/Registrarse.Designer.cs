using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Registrarse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_atras_registro = new System.Windows.Forms.PictureBox();
            this.btn_minimizar_registro = new System.Windows.Forms.PictureBox();
            this.textbox_registrar_nombres = new System.Windows.Forms.TextBox();
            this.btn_registrar_persona = new System.Windows.Forms.Button();
            this.textbox_registrar_apellidos = new System.Windows.Forms.TextBox();
            this.textbox_registrar_contrasena = new System.Windows.Forms.TextBox();
            this.textbox_registrar_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProviderRegistro = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atras_registro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar_registro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.pictureBox1.Location = new System.Drawing.Point(371, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "REGISTRO";
            // 
            // btn_atras_registro
            // 
            this.btn_atras_registro.BackColor = System.Drawing.Color.Transparent;
            this.btn_atras_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atras_registro.Image = global::Presentacion.Properties.Resources.image_removebg_preview__4_;
            this.btn_atras_registro.Location = new System.Drawing.Point(961, 51);
            this.btn_atras_registro.Name = "btn_atras_registro";
            this.btn_atras_registro.Size = new System.Drawing.Size(29, 27);
            this.btn_atras_registro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_atras_registro.TabIndex = 2;
            this.btn_atras_registro.TabStop = false;
            this.btn_atras_registro.Click += new System.EventHandler(this.btn_atras_registro_Click_1);
            // 
            // btn_minimizar_registro
            // 
            this.btn_minimizar_registro.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar_registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar_registro.Image = global::Presentacion.Properties.Resources.image_removebg_preview__2_;
            this.btn_minimizar_registro.Location = new System.Drawing.Point(901, 51);
            this.btn_minimizar_registro.Name = "btn_minimizar_registro";
            this.btn_minimizar_registro.Size = new System.Drawing.Size(29, 27);
            this.btn_minimizar_registro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar_registro.TabIndex = 3;
            this.btn_minimizar_registro.TabStop = false;
            this.btn_minimizar_registro.Click += new System.EventHandler(this.btn_minimizar_registro_Click_1);
            // 
            // textbox_registrar_nombres
            // 
            this.textbox_registrar_nombres.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_registrar_nombres.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textbox_registrar_nombres.Location = new System.Drawing.Point(200, 165);
            this.textbox_registrar_nombres.Multiline = true;
            this.textbox_registrar_nombres.Name = "textbox_registrar_nombres";
            this.textbox_registrar_nombres.Size = new System.Drawing.Size(274, 45);
            this.textbox_registrar_nombres.TabIndex = 1;
            // 
            // btn_registrar_persona
            // 
            this.btn_registrar_persona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btn_registrar_persona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar_persona.FlatAppearance.BorderSize = 0;
            this.btn_registrar_persona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar_persona.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_persona.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_registrar_persona.Location = new System.Drawing.Point(395, 350);
            this.btn_registrar_persona.Name = "btn_registrar_persona";
            this.btn_registrar_persona.Size = new System.Drawing.Size(245, 47);
            this.btn_registrar_persona.TabIndex = 5;
            this.btn_registrar_persona.Text = "REGISTRAR";
            this.btn_registrar_persona.UseVisualStyleBackColor = false;
            this.btn_registrar_persona.Click += new System.EventHandler(this.btn_registrar_persona_Click_1);
            // 
            // textbox_registrar_apellidos
            // 
            this.textbox_registrar_apellidos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_registrar_apellidos.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textbox_registrar_apellidos.Location = new System.Drawing.Point(558, 165);
            this.textbox_registrar_apellidos.Multiline = true;
            this.textbox_registrar_apellidos.Name = "textbox_registrar_apellidos";
            this.textbox_registrar_apellidos.Size = new System.Drawing.Size(274, 45);
            this.textbox_registrar_apellidos.TabIndex = 2;
            // 
            // textbox_registrar_contrasena
            // 
            this.textbox_registrar_contrasena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_registrar_contrasena.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textbox_registrar_contrasena.Location = new System.Drawing.Point(558, 261);
            this.textbox_registrar_contrasena.Multiline = true;
            this.textbox_registrar_contrasena.Name = "textbox_registrar_contrasena";
            this.textbox_registrar_contrasena.Size = new System.Drawing.Size(274, 45);
            this.textbox_registrar_contrasena.TabIndex = 4;
            // 
            // textbox_registrar_usuario
            // 
            this.textbox_registrar_usuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_registrar_usuario.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textbox_registrar_usuario.Location = new System.Drawing.Point(200, 261);
            this.textbox_registrar_usuario.Multiline = true;
            this.textbox_registrar_usuario.Name = "textbox_registrar_usuario";
            this.textbox_registrar_usuario.Size = new System.Drawing.Size(274, 45);
            this.textbox_registrar_usuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(200, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(558, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contraseña";
            // 
            // errorProviderRegistro
            // 
            this.errorProviderRegistro.ContainerControl = this;
            // 
            // Registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Presentacion.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 587);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox_registrar_usuario);
            this.Controls.Add(this.textbox_registrar_contrasena);
            this.Controls.Add(this.textbox_registrar_apellidos);
            this.Controls.Add(this.btn_registrar_persona);
            this.Controls.Add(this.textbox_registrar_nombres);
            this.Controls.Add(this.btn_minimizar_registro);
            this.Controls.Add(this.btn_atras_registro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_atras_registro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar_registro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox btn_atras_registro;
        private PictureBox btn_minimizar_registro;
        private TextBox textbox_registrar_nombres;
        private Button btn_registrar_persona;
        private TextBox textbox_registrar_apellidos;
        private TextBox textbox_registrar_contrasena;
        private TextBox textbox_registrar_usuario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProviderRegistro;
    }
}