using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Configuracion
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
            this.tbpConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnGuardarPaciente = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCedulaDoctor = new System.Windows.Forms.TextBox();
            this.btnGuardarDoctor = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefonoDoctor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_hora = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpConfig
            // 
            this.tbpConfig.Controls.Add(this.tabPage1);
            this.tbpConfig.Controls.Add(this.tabPage2);
            this.tbpConfig.Controls.Add(this.tabPage3);
            this.tbpConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpConfig.Location = new System.Drawing.Point(0, 0);
            this.tbpConfig.Name = "tbpConfig";
            this.tbpConfig.SelectedIndex = 0;
            this.tbpConfig.Size = new System.Drawing.Size(1234, 656);
            this.tbpConfig.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtCedula);
            this.tabPage1.Controls.Add(this.btnGuardarPaciente);
            this.tabPage1.Controls.Add(this.dtpFechaNacimiento);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtTelefonoPaciente);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDireccionPaciente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtApellidoPaciente);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNombrePaciente);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(486, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 37);
            this.label11.TabIndex = 45;
            this.label11.Text = "Actualizar datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(315, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 38;
            this.label7.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCedula.Location = new System.Drawing.Point(315, 140);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(274, 45);
            this.txtCedula.TabIndex = 37;
            // 
            // btnGuardarPaciente
            // 
            this.btnGuardarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btnGuardarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPaciente.FlatAppearance.BorderSize = 0;
            this.btnGuardarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPaciente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarPaciente.Location = new System.Drawing.Point(507, 471);
            this.btnGuardarPaciente.Name = "btnGuardarPaciente";
            this.btnGuardarPaciente.Size = new System.Drawing.Size(214, 36);
            this.btnGuardarPaciente.TabIndex = 44;
            this.btnGuardarPaciente.Text = "Guardar";
            this.btnGuardarPaciente.UseVisualStyleBackColor = false;
            this.btnGuardarPaciente.Click += new System.EventHandler(this.btnGuardarPaciente_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(641, 369);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(270, 22);
            this.dtpFechaNacimiento.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(637, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 21);
            this.label5.TabIndex = 36;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(319, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Telefono";
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(319, 348);
            this.txtTelefonoPaciente.Multiline = true;
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(274, 45);
            this.txtTelefonoPaciente.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(637, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Direccíon";
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDireccionPaciente.Location = new System.Drawing.Point(637, 241);
            this.txtDireccionPaciente.Multiline = true;
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(274, 45);
            this.txtDireccionPaciente.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(319, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Apellido";
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtApellidoPaciente.Location = new System.Drawing.Point(319, 241);
            this.txtApellidoPaciente.Multiline = true;
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(274, 45);
            this.txtApellidoPaciente.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(633, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nombre";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombrePaciente.Location = new System.Drawing.Point(633, 140);
            this.txtNombrePaciente.Multiline = true;
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(274, 45);
            this.txtNombrePaciente.TabIndex = 39;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtCedulaDoctor);
            this.tabPage2.Controls.Add(this.btnGuardarDoctor);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtTelefonoDoctor);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtNombreDoctor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(482, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(251, 37);
            this.label8.TabIndex = 46;
            this.label8.Text = "Actualizar datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(475, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Cedula";
            // 
            // txtCedulaDoctor
            // 
            this.txtCedulaDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCedulaDoctor.Location = new System.Drawing.Point(475, 197);
            this.txtCedulaDoctor.Multiline = true;
            this.txtCedulaDoctor.Name = "txtCedulaDoctor";
            this.txtCedulaDoctor.Size = new System.Drawing.Size(274, 45);
            this.txtCedulaDoctor.TabIndex = 34;
            // 
            // btnGuardarDoctor
            // 
            this.btnGuardarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btnGuardarDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarDoctor.FlatAppearance.BorderSize = 0;
            this.btnGuardarDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardarDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarDoctor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarDoctor.Location = new System.Drawing.Point(499, 492);
            this.btnGuardarDoctor.Name = "btnGuardarDoctor";
            this.btnGuardarDoctor.Size = new System.Drawing.Size(214, 36);
            this.btnGuardarDoctor.TabIndex = 39;
            this.btnGuardarDoctor.Text = "Guardar";
            this.btnGuardarDoctor.UseVisualStyleBackColor = false;
            this.btnGuardarDoctor.Click += new System.EventHandler(this.btnGuardarDoctor_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(471, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Telefono";
            // 
            // txtTelefonoDoctor
            // 
            this.txtTelefonoDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTelefonoDoctor.Location = new System.Drawing.Point(471, 391);
            this.txtTelefonoDoctor.Multiline = true;
            this.txtTelefonoDoctor.Name = "txtTelefonoDoctor";
            this.txtTelefonoDoctor.Size = new System.Drawing.Size(274, 45);
            this.txtTelefonoDoctor.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(471, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 21);
            this.label10.TabIndex = 31;
            this.label10.Text = "Nombre";
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreDoctor.Location = new System.Drawing.Point(471, 286);
            this.txtNombreDoctor.Multiline = true;
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(274, 45);
            this.txtNombreDoctor.TabIndex = 36;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.label_hora);
            this.tabPage3.Controls.Add(this.label_fecha);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1226, 627);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Diseño_sin_título__10_;
            this.pictureBox1.Location = new System.Drawing.Point(504, 493);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label_hora
            // 
            this.label_hora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_hora.AutoSize = true;
            this.label_hora.BackColor = System.Drawing.Color.Transparent;
            this.label_hora.Font = new System.Drawing.Font("Century Gothic", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label_hora.Location = new System.Drawing.Point(329, 111);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(448, 157);
            this.label_hora.TabIndex = 3;
            this.label_hora.Text = "HORA";
            // 
            // label_fecha
            // 
            this.label_fecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_fecha.AutoSize = true;
            this.label_fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_fecha.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label_fecha.Location = new System.Drawing.Point(76, 297);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(200, 70);
            this.label_fecha.TabIndex = 4;
            this.label_fecha.Text = "HORA";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick_1);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 35);
            this.panel1.TabIndex = 1;
            // 
            // Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1234, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Configuracion";
            this.Text = "Reportes";
            this.tbpConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbpConfig;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label7;
        private TextBox txtCedula;
        private Button btnGuardarPaciente;
        private DateTimePicker dtpFechaNacimiento;
        private Label label5;
        private Label label4;
        private TextBox txtTelefonoPaciente;
        private Label label2;
        private TextBox txtDireccionPaciente;
        private Label label1;
        private TextBox txtApellidoPaciente;
        private Label label3;
        private TextBox txtNombrePaciente;
        private Label label6;
        private TextBox txtCedulaDoctor;
        private Button btnGuardarDoctor;
        private Label label9;
        private TextBox txtTelefonoDoctor;
        private Label label10;
        private TextBox txtNombreDoctor;
        private Label label11;
        private Label label8;
        private TabPage tabPage3;
        private PictureBox pictureBox1;
        private Label label_hora;
        private Label label_fecha;
        private Timer horafecha;
        private ErrorProvider errorProvider;
        private Panel panel1;
    }
}