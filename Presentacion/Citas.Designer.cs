using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Citas
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
            this.tbpCitas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_agregar_citas = new System.Windows.Forms.Button();
            this.btn_citas_existentes = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxEspecialidad = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnApartar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgCitas = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBuscarCita = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dtgCitasPaciente = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.dtgCitasDoctores = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnGuardarHistoria = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNotasAdicionales = new System.Windows.Forms.TextBox();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDireccionCita = new System.Windows.Forms.TextBox();
            this.txtTelefonoCita = new System.Windows.Forms.TextBox();
            this.txtNombreCita = new System.Windows.Forms.TextBox();
            this.txtCedulaCita = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnApartarCita = new System.Windows.Forms.Button();
            this.btnMisCitas = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.dtgPacienteCitas = new System.Windows.Forms.DataGridView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.searchTimer = new System.Windows.Forms.Timer(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpCitas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitas)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasPaciente)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasDoctores)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacienteCitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpCitas
            // 
            this.tbpCitas.Controls.Add(this.tabPage1);
            this.tbpCitas.Controls.Add(this.tabPage2);
            this.tbpCitas.Controls.Add(this.tabPage3);
            this.tbpCitas.Controls.Add(this.tabPage4);
            this.tbpCitas.Controls.Add(this.tabPage5);
            this.tbpCitas.Controls.Add(this.tabPage6);
            this.tbpCitas.Controls.Add(this.tabPage7);
            this.tbpCitas.Controls.Add(this.tabPage8);
            this.tbpCitas.Controls.Add(this.tabPage9);
            this.tbpCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpCitas.Location = new System.Drawing.Point(0, 0);
            this.tbpCitas.Name = "tbpCitas";
            this.tbpCitas.SelectedIndex = 0;
            this.tbpCitas.Size = new System.Drawing.Size(1234, 656);
            this.tbpCitas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_agregar_citas);
            this.tabPage1.Controls.Add(this.btn_citas_existentes);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_agregar_citas
            // 
            this.btn_agregar_citas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_agregar_citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(151)))), ((int)(((byte)(224)))));
            this.btn_agregar_citas.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__8_2;
            this.btn_agregar_citas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_citas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_citas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_agregar_citas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btn_agregar_citas.Location = new System.Drawing.Point(209, 160);
            this.btn_agregar_citas.Name = "btn_agregar_citas";
            this.btn_agregar_citas.Size = new System.Drawing.Size(379, 246);
            this.btn_agregar_citas.TabIndex = 4;
            this.btn_agregar_citas.Text = "AGREGAR \r\nCITAS";
            this.btn_agregar_citas.UseVisualStyleBackColor = false;
            this.btn_agregar_citas.Click += new System.EventHandler(this.btn_agregar_citas_Click);
            // 
            // btn_citas_existentes
            // 
            this.btn_citas_existentes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_citas_existentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_citas_existentes.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__9_1;
            this.btn_citas_existentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_citas_existentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_citas_existentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_citas_existentes.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_citas_existentes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btn_citas_existentes.Location = new System.Drawing.Point(629, 160);
            this.btn_citas_existentes.Name = "btn_citas_existentes";
            this.btn_citas_existentes.Size = new System.Drawing.Size(379, 246);
            this.btn_citas_existentes.TabIndex = 6;
            this.btn_citas_existentes.Text = "CITAS \r\nEXISTENTES\r\n";
            this.btn_citas_existentes.UseVisualStyleBackColor = false;
            this.btn_citas_existentes.Click += new System.EventHandler(this.btn_citas_existentes_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.lblBuscar);
            this.tabPage2.Controls.Add(this.txtBuscarPaciente);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ApartarCita";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFecha);
            this.groupBox2.Controls.Add(this.cbxHorario);
            this.groupBox2.Controls.Add(this.cbxDoctor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbxEspecialidad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnApartar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(577, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 451);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cita";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(185, 229);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(238, 26);
            this.dtpFecha.TabIndex = 46;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cbxHorario
            // 
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(185, 316);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(238, 28);
            this.cbxHorario.TabIndex = 39;
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Location = new System.Drawing.Point(185, 151);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(238, 28);
            this.cbxDoctor.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(181, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Horario";
            // 
            // cbxEspecialidad
            // 
            this.cbxEspecialidad.FormattingEnabled = true;
            this.cbxEspecialidad.Location = new System.Drawing.Point(185, 71);
            this.cbxEspecialidad.Name = "cbxEspecialidad";
            this.cbxEspecialidad.Size = new System.Drawing.Size(238, 28);
            this.cbxEspecialidad.TabIndex = 41;
            this.cbxEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbxEspecialidad_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(181, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(181, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 44;
            this.label7.Text = "Doctor";
            // 
            // btnApartar
            // 
            this.btnApartar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btnApartar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApartar.FlatAppearance.BorderSize = 0;
            this.btnApartar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnApartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnApartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApartar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnApartar.Location = new System.Drawing.Point(197, 392);
            this.btnApartar.Name = "btnApartar";
            this.btnApartar.Size = new System.Drawing.Size(214, 36);
            this.btnApartar.TabIndex = 38;
            this.btnApartar.Text = "Apartar";
            this.btnApartar.UseVisualStyleBackColor = false;
            this.btnApartar.Click += new System.EventHandler(this.btnApartar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(181, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 21);
            this.label6.TabIndex = 45;
            this.label6.Text = "Especialidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(134, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 451);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paciente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(35, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 33;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(35, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(35, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(35, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cedula";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDireccion.Location = new System.Drawing.Point(39, 383);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(241, 45);
            this.txtDireccion.TabIndex = 29;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTelefono.Location = new System.Drawing.Point(39, 284);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ReadOnly = true;
            this.txtTelefono.Size = new System.Drawing.Size(241, 45);
            this.txtTelefono.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombre.Location = new System.Drawing.Point(39, 176);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(241, 45);
            this.txtNombre.TabIndex = 31;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCedula.Location = new System.Drawing.Point(39, 75);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ReadOnly = true;
            this.txtCedula.Size = new System.Drawing.Size(241, 45);
            this.txtCedula.TabIndex = 32;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscar.Location = new System.Drawing.Point(773, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(214, 36);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBuscar.Location = new System.Drawing.Point(357, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(85, 21);
            this.lblBuscar.TabIndex = 28;
            this.lblBuscar.Text = "Paciente";
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscarPaciente.Location = new System.Drawing.Point(361, 44);
            this.txtBuscarPaciente.Multiline = true;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(372, 45);
            this.txtBuscarPaciente.TabIndex = 27;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtgCitas);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.txtBuscarCita);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1226, 627);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "CitasAdmin";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgCitas
            // 
            this.dtgCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCitas.Location = new System.Drawing.Point(128, 177);
            this.dtgCitas.Name = "dtgCitas";
            this.dtgCitas.ReadOnly = true;
            this.dtgCitas.RowHeadersWidth = 51;
            this.dtgCitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCitas.RowTemplate.Height = 24;
            this.dtgCitas.Size = new System.Drawing.Size(954, 378);
            this.dtgCitas.TabIndex = 31;
            this.dtgCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCitas_CellClick);
            this.dtgCitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCitas_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(399, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 30;
            this.label10.Text = "Buscar";
            // 
            // txtBuscarCita
            // 
            this.txtBuscarCita.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCita.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscarCita.Location = new System.Drawing.Point(403, 88);
            this.txtBuscarCita.Multiline = true;
            this.txtBuscarCita.Name = "txtBuscarCita";
            this.txtBuscarCita.Size = new System.Drawing.Size(372, 45);
            this.txtBuscarCita.TabIndex = 29;
            this.txtBuscarCita.TextChanged += new System.EventHandler(this.txtBuscarCita_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dtgCitasPaciente);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1226, 627);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Citas paciente";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // dtgCitasPaciente
            // 
            this.dtgCitasPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCitasPaciente.Location = new System.Drawing.Point(136, 124);
            this.dtgCitasPaciente.Name = "dtgCitasPaciente";
            this.dtgCitasPaciente.ReadOnly = true;
            this.dtgCitasPaciente.RowHeadersWidth = 51;
            this.dtgCitasPaciente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCitasPaciente.RowTemplate.Height = 24;
            this.dtgCitasPaciente.Size = new System.Drawing.Size(954, 378);
            this.dtgCitasPaciente.TabIndex = 38;
            this.dtgCitasPaciente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCitasPaciente_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(581, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 21);
            this.label11.TabIndex = 37;
            this.label11.Text = "Tus citas";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.dtgCitasDoctores);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1226, 627);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "CitasDoctores";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.tabPage5_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(563, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 21);
            this.label12.TabIndex = 40;
            this.label12.Text = "Tus citas";
            // 
            // dtgCitasDoctores
            // 
            this.dtgCitasDoctores.AllowUserToAddRows = false;
            this.dtgCitasDoctores.AllowUserToDeleteRows = false;
            this.dtgCitasDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCitasDoctores.Location = new System.Drawing.Point(176, 130);
            this.dtgCitasDoctores.Name = "dtgCitasDoctores";
            this.dtgCitasDoctores.ReadOnly = true;
            this.dtgCitasDoctores.RowHeadersWidth = 51;
            this.dtgCitasDoctores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgCitasDoctores.RowTemplate.Height = 24;
            this.dtgCitasDoctores.Size = new System.Drawing.Size(861, 378);
            this.dtgCitasDoctores.TabIndex = 39;
            this.dtgCitasDoctores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgCitasDoctores_CellContentClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnGuardarHistoria);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.label19);
            this.tabPage6.Controls.Add(this.label18);
            this.tabPage6.Controls.Add(this.txtNotasAdicionales);
            this.tabPage6.Controls.Add(this.txtTratamiento);
            this.tabPage6.Controls.Add(this.txtDiagnostico);
            this.tabPage6.Controls.Add(this.groupBox3);
            this.tabPage6.Controls.Add(this.lblDoctor);
            this.tabPage6.Controls.Add(this.lblFecha);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1226, 627);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Enter += new System.EventHandler(this.tabPage6_Enter);
            // 
            // btnGuardarHistoria
            // 
            this.btnGuardarHistoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btnGuardarHistoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarHistoria.FlatAppearance.BorderSize = 0;
            this.btnGuardarHistoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnGuardarHistoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGuardarHistoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarHistoria.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarHistoria.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnGuardarHistoria.Location = new System.Drawing.Point(714, 583);
            this.btnGuardarHistoria.Name = "btnGuardarHistoria";
            this.btnGuardarHistoria.Size = new System.Drawing.Size(214, 36);
            this.btnGuardarHistoria.TabIndex = 43;
            this.btnGuardarHistoria.Text = "Guardar";
            this.btnGuardarHistoria.UseVisualStyleBackColor = false;
            this.btnGuardarHistoria.Click += new System.EventHandler(this.btnGuardarHistoria_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(461, 422);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 21);
            this.label20.TabIndex = 41;
            this.label20.Text = "Notas Adicionales";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(461, 291);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(111, 21);
            this.label19.TabIndex = 41;
            this.label19.Text = "Tratamiento";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(461, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 21);
            this.label18.TabIndex = 41;
            this.label18.Text = "Diagnostico";
            // 
            // txtNotasAdicionales
            // 
            this.txtNotasAdicionales.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotasAdicionales.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNotasAdicionales.Location = new System.Drawing.Point(465, 459);
            this.txtNotasAdicionales.Multiline = true;
            this.txtNotasAdicionales.Name = "txtNotasAdicionales";
            this.txtNotasAdicionales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotasAdicionales.Size = new System.Drawing.Size(677, 84);
            this.txtNotasAdicionales.TabIndex = 42;
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTratamiento.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTratamiento.Location = new System.Drawing.Point(465, 328);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTratamiento.Size = new System.Drawing.Size(677, 74);
            this.txtTratamiento.TabIndex = 41;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiagnostico.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDiagnostico.Location = new System.Drawing.Point(465, 167);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiagnostico.Size = new System.Drawing.Size(677, 109);
            this.txtDiagnostico.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtDireccionCita);
            this.groupBox3.Controls.Add(this.txtTelefonoCita);
            this.groupBox3.Controls.Add(this.txtNombreCita);
            this.groupBox3.Controls.Add(this.txtCedulaCita);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(70, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 451);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paciente";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(35, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 21);
            this.label14.TabIndex = 33;
            this.label14.Text = "Direccion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(35, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 21);
            this.label15.TabIndex = 34;
            this.label15.Text = "Telefono";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(35, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 21);
            this.label16.TabIndex = 35;
            this.label16.Text = "Nombre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(35, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 21);
            this.label17.TabIndex = 36;
            this.label17.Text = "Cedula";
            // 
            // txtDireccionCita
            // 
            this.txtDireccionCita.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCita.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDireccionCita.Location = new System.Drawing.Point(39, 383);
            this.txtDireccionCita.Multiline = true;
            this.txtDireccionCita.Name = "txtDireccionCita";
            this.txtDireccionCita.ReadOnly = true;
            this.txtDireccionCita.Size = new System.Drawing.Size(241, 45);
            this.txtDireccionCita.TabIndex = 29;
            // 
            // txtTelefonoCita
            // 
            this.txtTelefonoCita.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCita.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTelefonoCita.Location = new System.Drawing.Point(39, 284);
            this.txtTelefonoCita.Multiline = true;
            this.txtTelefonoCita.Name = "txtTelefonoCita";
            this.txtTelefonoCita.ReadOnly = true;
            this.txtTelefonoCita.Size = new System.Drawing.Size(241, 45);
            this.txtTelefonoCita.TabIndex = 30;
            // 
            // txtNombreCita
            // 
            this.txtNombreCita.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCita.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreCita.Location = new System.Drawing.Point(39, 176);
            this.txtNombreCita.Multiline = true;
            this.txtNombreCita.Name = "txtNombreCita";
            this.txtNombreCita.ReadOnly = true;
            this.txtNombreCita.Size = new System.Drawing.Size(241, 45);
            this.txtNombreCita.TabIndex = 31;
            // 
            // txtCedulaCita
            // 
            this.txtCedulaCita.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaCita.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCedulaCita.Location = new System.Drawing.Point(39, 75);
            this.txtCedulaCita.Multiline = true;
            this.txtCedulaCita.Name = "txtCedulaCita";
            this.txtCedulaCita.ReadOnly = true;
            this.txtCedulaCita.Size = new System.Drawing.Size(241, 45);
            this.txtCedulaCita.TabIndex = 32;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDoctor.Location = new System.Drawing.Point(461, 92);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(75, 23);
            this.lblDoctor.TabIndex = 38;
            this.lblDoctor.Text = "Doctor";
            this.lblDoctor.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFecha.Location = new System.Drawing.Point(988, 92);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(71, 23);
            this.lblFecha.TabIndex = 38;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label13_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(498, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "Historia Clinica";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnApartarCita);
            this.tabPage7.Controls.Add(this.btnMisCitas);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1226, 627);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnApartarCita
            // 
            this.btnApartarCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnApartarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(151)))), ((int)(((byte)(224)))));
            this.btnApartarCita.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__8_2;
            this.btnApartarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApartarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApartarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApartarCita.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btnApartarCita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btnApartarCita.Location = new System.Drawing.Point(209, 160);
            this.btnApartarCita.Name = "btnApartarCita";
            this.btnApartarCita.Size = new System.Drawing.Size(379, 246);
            this.btnApartarCita.TabIndex = 7;
            this.btnApartarCita.Text = "APARTAR CITA";
            this.btnApartarCita.UseVisualStyleBackColor = false;
            this.btnApartarCita.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMisCitas
            // 
            this.btnMisCitas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMisCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnMisCitas.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__9_1;
            this.btnMisCitas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMisCitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisCitas.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btnMisCitas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btnMisCitas.Location = new System.Drawing.Point(629, 160);
            this.btnMisCitas.Name = "btnMisCitas";
            this.btnMisCitas.Size = new System.Drawing.Size(379, 246);
            this.btnMisCitas.TabIndex = 8;
            this.btnMisCitas.Text = "MIS CITAS";
            this.btnMisCitas.UseVisualStyleBackColor = false;
            this.btnMisCitas.Click += new System.EventHandler(this.btnMisCitas_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label21);
            this.tabPage8.Controls.Add(this.dtgPacienteCitas);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1226, 627);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(579, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 21);
            this.label21.TabIndex = 41;
            this.label21.Text = "Tus citas";
            // 
            // dtgPacienteCitas
            // 
            this.dtgPacienteCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPacienteCitas.Location = new System.Drawing.Point(136, 124);
            this.dtgPacienteCitas.Name = "dtgPacienteCitas";
            this.dtgPacienteCitas.ReadOnly = true;
            this.dtgPacienteCitas.RowHeadersWidth = 51;
            this.dtgPacienteCitas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgPacienteCitas.RowTemplate.Height = 24;
            this.dtgPacienteCitas.Size = new System.Drawing.Size(954, 378);
            this.dtgPacienteCitas.TabIndex = 39;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1226, 627);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 35);
            this.panel1.TabIndex = 3;
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1234, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpCitas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.Text = "Citas";
            this.tbpCitas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitas)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasPaciente)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCitasDoctores)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacienteCitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbpCitas;
        private TabPage tabPage1;
        private Button btn_agregar_citas;
        private Button btn_citas_existentes;
        private TabPage tabPage2;
        private TextBox txtBuscarPaciente;
        private Label lblBuscar;
        private Button btnBuscar;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtNombre;
        private TextBox txtCedula;
        private GroupBox groupBox2;
        private DateTimePicker dtpFecha;
        private ComboBox cbxHorario;
        private ComboBox cbxDoctor;
        private Label label9;
        private ComboBox cbxEspecialidad;
        private Label label8;
        private Label label7;
        private Button btnApartar;
        private Label label6;
        private ErrorProvider errorProvider;
        private TabPage tabPage3;
        private DataGridView dtgCitas;
        private Label label10;
        private TextBox txtBuscarCita;
        private Timer searchTimer;
        private BindingSource bindingSource;
        private TabPage tabPage4;
        private DataGridView dtgCitasPaciente;
        private Label label11;
        private TabPage tabPage5;
        private DataGridView dtgCitasDoctores;
        private TabPage tabPage6;
        private Label label12;
        private Label label13;
        private GroupBox groupBox3;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox txtDireccionCita;
        private TextBox txtTelefonoCita;
        private TextBox txtNombreCita;
        private TextBox txtCedulaCita;
        private Label label18;
        private TextBox txtDiagnostico;
        private Label label20;
        private Label label19;
        private TextBox txtNotasAdicionales;
        private TextBox txtTratamiento;
        private Label lblFecha;
        private Button btnGuardarHistoria;
        private Label lblDoctor;
        private TabPage tabPage7;
        private Button btnApartarCita;
        private Button btnMisCitas;
        private TabPage tabPage8;
        private Label label21;
        private DataGridView dtgPacienteCitas;
        private TabPage tabPage9;
        private Panel panel1;
    }
}