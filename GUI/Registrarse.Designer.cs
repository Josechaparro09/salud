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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btn_atras_registro = new PictureBox();
            btn_minimizar_registro = new PictureBox();
            textbox_registrar_nombres = new TextBox();
            btn_registrar_persona = new Button();
            textbox_registrar_apellidos = new TextBox();
            textbox_registrar_contrasena = new TextBox();
            textbox_registrar_usuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_atras_registro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar_registro).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            pictureBox1.Location = new Point(325, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 51);
            label1.Name = "label1";
            label1.Size = new Size(100, 22);
            label1.TabIndex = 1;
            label1.Text = "REGISTRO";
            // 
            // btn_atras_registro
            // 
            btn_atras_registro.BackColor = Color.Transparent;
            btn_atras_registro.Cursor = Cursors.Hand;
            btn_atras_registro.Image = Properties.Resources.image_removebg_preview__4_;
            btn_atras_registro.Location = new Point(841, 48);
            btn_atras_registro.Name = "btn_atras_registro";
            btn_atras_registro.Size = new Size(25, 25);
            btn_atras_registro.SizeMode = PictureBoxSizeMode.Zoom;
            btn_atras_registro.TabIndex = 2;
            btn_atras_registro.TabStop = false;
            btn_atras_registro.Click += btn_atras_registro_Click;
            // 
            // btn_minimizar_registro
            // 
            btn_minimizar_registro.BackColor = Color.Transparent;
            btn_minimizar_registro.Cursor = Cursors.Hand;
            btn_minimizar_registro.Image = Properties.Resources.image_removebg_preview__2_;
            btn_minimizar_registro.Location = new Point(788, 48);
            btn_minimizar_registro.Name = "btn_minimizar_registro";
            btn_minimizar_registro.Size = new Size(25, 25);
            btn_minimizar_registro.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimizar_registro.TabIndex = 3;
            btn_minimizar_registro.TabStop = false;
            btn_minimizar_registro.Click += btn_minimizar_registro_Click;
            // 
            // textbox_registrar_nombres
            // 
            textbox_registrar_nombres.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_registrar_nombres.ForeColor = SystemColors.ControlDark;
            textbox_registrar_nombres.Location = new Point(175, 155);
            textbox_registrar_nombres.Multiline = true;
            textbox_registrar_nombres.Name = "textbox_registrar_nombres";
            textbox_registrar_nombres.Size = new Size(240, 42);
            textbox_registrar_nombres.TabIndex = 1;
            textbox_registrar_nombres.Text = "NOMBRES";
            textbox_registrar_nombres.Enter += textbox_registrar_nombres_Enter;
            textbox_registrar_nombres.Leave += textbox_registrar_nombres_Leave;
            // 
            // btn_registrar_persona
            // 
            btn_registrar_persona.BackColor = Color.FromArgb(0, 74, 163);
            btn_registrar_persona.Cursor = Cursors.Hand;
            btn_registrar_persona.FlatAppearance.BorderSize = 0;
            btn_registrar_persona.FlatStyle = FlatStyle.Flat;
            btn_registrar_persona.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_registrar_persona.ForeColor = SystemColors.ControlLightLight;
            btn_registrar_persona.Location = new Point(346, 328);
            btn_registrar_persona.Name = "btn_registrar_persona";
            btn_registrar_persona.Size = new Size(214, 44);
            btn_registrar_persona.TabIndex = 8;
            btn_registrar_persona.Text = "REGISTRAR";
            btn_registrar_persona.UseVisualStyleBackColor = false;
            btn_registrar_persona.Click += btn_registrar_persona_Click;
            // 
            // textbox_registrar_apellidos
            // 
            textbox_registrar_apellidos.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_registrar_apellidos.ForeColor = SystemColors.ControlDark;
            textbox_registrar_apellidos.Location = new Point(488, 155);
            textbox_registrar_apellidos.Multiline = true;
            textbox_registrar_apellidos.Name = "textbox_registrar_apellidos";
            textbox_registrar_apellidos.Size = new Size(240, 42);
            textbox_registrar_apellidos.TabIndex = 9;
            textbox_registrar_apellidos.Text = "APELLIDOS";
            textbox_registrar_apellidos.Enter += textbox_registrar_apellidos_Enter;
            textbox_registrar_apellidos.Leave += textbox_registrar_apellidos_Leave;
            // 
            // textbox_registrar_contrasena
            // 
            textbox_registrar_contrasena.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_registrar_contrasena.ForeColor = SystemColors.ControlDark;
            textbox_registrar_contrasena.Location = new Point(488, 245);
            textbox_registrar_contrasena.Multiline = true;
            textbox_registrar_contrasena.Name = "textbox_registrar_contrasena";
            textbox_registrar_contrasena.Size = new Size(240, 42);
            textbox_registrar_contrasena.TabIndex = 10;
            textbox_registrar_contrasena.Text = "CONTRASEÑA";
            textbox_registrar_contrasena.Enter += textbox_registrar_contrasena_Enter;
            textbox_registrar_contrasena.Leave += textbox_registrar_contrasena_Leave;
            // 
            // textbox_registrar_usuario
            // 
            textbox_registrar_usuario.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox_registrar_usuario.ForeColor = SystemColors.ControlDark;
            textbox_registrar_usuario.Location = new Point(175, 245);
            textbox_registrar_usuario.Multiline = true;
            textbox_registrar_usuario.Name = "textbox_registrar_usuario";
            textbox_registrar_usuario.Size = new Size(240, 42);
            textbox_registrar_usuario.TabIndex = 11;
            textbox_registrar_usuario.Text = "USUARIO";
            textbox_registrar_usuario.Enter += textbox_registrar_usuario_Enter;
            textbox_registrar_usuario.Leave += textbox_registrar_usuario_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(175, 135);
            label2.Name = "label2";
            label2.Size = new Size(224, 17);
            label2.TabIndex = 12;
            label2.Text = "INGRESA SOLO EL PRIMER NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(488, 135);
            label3.Name = "label3";
            label3.Size = new Size(230, 17);
            label3.TabIndex = 13;
            label3.Text = "INGRESA SOLO EL PRIMER APELLIDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(175, 225);
            label4.Name = "label4";
            label4.Size = new Size(108, 17);
            label4.TabIndex = 14;
            label4.Text = "CREAR USUAIRO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(488, 225);
            label5.Name = "label5";
            label5.Size = new Size(141, 17);
            label5.TabIndex = 15;
            label5.Text = "CREAR CONTRASEÑA";
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 550);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textbox_registrar_usuario);
            Controls.Add(textbox_registrar_contrasena);
            Controls.Add(textbox_registrar_apellidos);
            Controls.Add(btn_registrar_persona);
            Controls.Add(textbox_registrar_nombres);
            Controls.Add(btn_minimizar_registro);
            Controls.Add(btn_atras_registro);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Registrarse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_atras_registro).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar_registro).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}