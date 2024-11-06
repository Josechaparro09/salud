using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Doctores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbpDoctores = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_horarios_doctores = new System.Windows.Forms.Button();
            this.btn_agregar_doctores = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaDoctor = new System.Windows.Forms.TextBox();
            this.btnAgregarDoctor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecialidadDoctor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoDoctor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.dtgHorarios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxDia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxDoctor = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpDoctores.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHorarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpDoctores
            // 
            this.tbpDoctores.Controls.Add(this.tabPage1);
            this.tbpDoctores.Controls.Add(this.tabPage2);
            this.tbpDoctores.Controls.Add(this.tabPage3);
            this.tbpDoctores.Controls.Add(this.tabPage4);
            this.tbpDoctores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpDoctores.Location = new System.Drawing.Point(0, 0);
            this.tbpDoctores.Name = "tbpDoctores";
            this.tbpDoctores.SelectedIndex = 0;
            this.tbpDoctores.Size = new System.Drawing.Size(1234, 656);
            this.tbpDoctores.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_horarios_doctores);
            this.tabPage1.Controls.Add(this.btn_agregar_doctores);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 627);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_horarios_doctores
            // 
            this.btn_horarios_doctores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_horarios_doctores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_horarios_doctores.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__9_1;
            this.btn_horarios_doctores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_horarios_doctores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_horarios_doctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_horarios_doctores.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_horarios_doctores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btn_horarios_doctores.Location = new System.Drawing.Point(629, 160);
            this.btn_horarios_doctores.Name = "btn_horarios_doctores";
            this.btn_horarios_doctores.Size = new System.Drawing.Size(379, 246);
            this.btn_horarios_doctores.TabIndex = 8;
            this.btn_horarios_doctores.Text = "HORARIOS\r\nDOCTORES\r\n";
            this.btn_horarios_doctores.UseVisualStyleBackColor = false;
            this.btn_horarios_doctores.Click += new System.EventHandler(this.btn_horarios_doctores_Click);
            // 
            // btn_agregar_doctores
            // 
            this.btn_agregar_doctores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_agregar_doctores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_agregar_doctores.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__8_2;
            this.btn_agregar_doctores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_doctores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_doctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_doctores.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_agregar_doctores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btn_agregar_doctores.Location = new System.Drawing.Point(209, 160);
            this.btn_agregar_doctores.Name = "btn_agregar_doctores";
            this.btn_agregar_doctores.Size = new System.Drawing.Size(379, 246);
            this.btn_agregar_doctores.TabIndex = 7;
            this.btn_agregar_doctores.Text = "AGREGAR \r\nDOCTORES\r\n";
            this.btn_agregar_doctores.UseVisualStyleBackColor = false;
            this.btn_agregar_doctores.Click += new System.EventHandler(this.btn_agregar_doctores_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtCedulaDoctor);
            this.tabPage2.Controls.Add(this.btnAgregarDoctor);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtEspecialidadDoctor);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtTelefonoDoctor);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtNombreDoctor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(480, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cedula";
            // 
            // txtCedulaDoctor
            // 
            this.txtCedulaDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCedulaDoctor.Location = new System.Drawing.Point(480, 72);
            this.txtCedulaDoctor.Multiline = true;
            this.txtCedulaDoctor.Name = "txtCedulaDoctor";
            this.txtCedulaDoctor.Size = new System.Drawing.Size(274, 45);
            this.txtCedulaDoctor.TabIndex = 26;
            this.txtCedulaDoctor.Enter += new System.EventHandler(this.txtCedulaDoctor_Enter);
            this.txtCedulaDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaDoctor_KeyPress);
            this.txtCedulaDoctor.Leave += new System.EventHandler(this.txtCedulaDoctor_Leave);
            // 
            // btnAgregarDoctor
            // 
            this.btnAgregarDoctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btnAgregarDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarDoctor.FlatAppearance.BorderSize = 0;
            this.btnAgregarDoctor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDoctor.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarDoctor.Location = new System.Drawing.Point(501, 445);
            this.btnAgregarDoctor.Name = "btnAgregarDoctor";
            this.btnAgregarDoctor.Size = new System.Drawing.Size(214, 36);
            this.btnAgregarDoctor.TabIndex = 30;
            this.btnAgregarDoctor.Text = "Agregar";
            this.btnAgregarDoctor.UseVisualStyleBackColor = false;
            this.btnAgregarDoctor.Click += new System.EventHandler(this.btnAgregarDoctor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(476, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Especialidad";
            // 
            // txtEspecialidadDoctor
            // 
            this.txtEspecialidadDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspecialidadDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtEspecialidadDoctor.Location = new System.Drawing.Point(476, 370);
            this.txtEspecialidadDoctor.Multiline = true;
            this.txtEspecialidadDoctor.Name = "txtEspecialidadDoctor";
            this.txtEspecialidadDoctor.Size = new System.Drawing.Size(274, 45);
            this.txtEspecialidadDoctor.TabIndex = 29;
            this.txtEspecialidadDoctor.Enter += new System.EventHandler(this.txtEspecialidadDoctor_Enter);
            this.txtEspecialidadDoctor.Leave += new System.EventHandler(this.txtEspecialidadDoctor_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(476, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefono";
            // 
            // txtTelefonoDoctor
            // 
            this.txtTelefonoDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTelefonoDoctor.Location = new System.Drawing.Point(476, 266);
            this.txtTelefonoDoctor.Multiline = true;
            this.txtTelefonoDoctor.Name = "txtTelefonoDoctor";
            this.txtTelefonoDoctor.Size = new System.Drawing.Size(274, 45);
            this.txtTelefonoDoctor.TabIndex = 28;
            this.txtTelefonoDoctor.Enter += new System.EventHandler(this.txtTelefonoDoctor_Enter);
            this.txtTelefonoDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefonoDoctor_KeyPress);
            this.txtTelefonoDoctor.Leave += new System.EventHandler(this.txtTelefonoDoctor_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(476, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDoctor.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombreDoctor.Location = new System.Drawing.Point(476, 161);
            this.txtNombreDoctor.Multiline = true;
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(274, 45);
            this.txtNombreDoctor.TabIndex = 27;
            this.txtNombreDoctor.Enter += new System.EventHandler(this.txtNombreDoctor_Enter);
            this.txtNombreDoctor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDoctor_KeyPress);
            this.txtNombreDoctor.Leave += new System.EventHandler(this.txtNombreDoctor_Leave);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dtgHorarios);
            this.tabPage3.Controls.Add(this.btnAgregar);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dtpHoraFin);
            this.tabPage3.Controls.Add(this.dtpHoraInicio);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cbxDia);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cbxDoctor);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.No;
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1226, 627);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(383, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 35;
            this.label9.Text = "Horario";
            // 
            // dtgHorarios
            // 
            this.dtgHorarios.AllowUserToAddRows = false;
            this.dtgHorarios.AllowUserToDeleteRows = false;
            this.dtgHorarios.AllowUserToOrderColumns = true;
            this.dtgHorarios.AllowUserToResizeColumns = false;
            this.dtgHorarios.AllowUserToResizeRows = false;
            this.dtgHorarios.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHorarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHorarios.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgHorarios.Location = new System.Drawing.Point(387, 106);
            this.dtgHorarios.MultiSelect = false;
            this.dtgHorarios.Name = "dtgHorarios";
            this.dtgHorarios.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHorarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgHorarios.RowHeadersWidth = 51;
            this.dtgHorarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgHorarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgHorarios.RowTemplate.Height = 24;
            this.dtgHorarios.Size = new System.Drawing.Size(737, 330);
            this.dtgHorarios.TabIndex = 34;
            this.dtgHorarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHorarios_CellClick);
            this.dtgHorarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHorarios_CellContentClick);
            this.dtgHorarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgHorarios_CellFormatting);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregar.Location = new System.Drawing.Point(112, 400);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(214, 36);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(98, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Hora fin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(98, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "Hora inicio";
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "hh:mm tt";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(102, 345);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(245, 22);
            this.dtpHoraFin.TabIndex = 31;
            this.dtpHoraFin.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "hh:mm tt";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(102, 261);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(245, 22);
            this.dtpHoraInicio.TabIndex = 31;
            this.dtpHoraInicio.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(98, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 21);
            this.label6.TabIndex = 30;
            this.label6.Text = "Dia";
            // 
            // cbxDia
            // 
            this.cbxDia.FormattingEnabled = true;
            this.cbxDia.Location = new System.Drawing.Point(102, 180);
            this.cbxDia.Name = "cbxDia";
            this.cbxDia.Size = new System.Drawing.Size(245, 24);
            this.cbxDia.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(98, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Doctor";
            // 
            // cbxDoctor
            // 
            this.cbxDoctor.FormattingEnabled = true;
            this.cbxDoctor.Location = new System.Drawing.Point(102, 106);
            this.cbxDoctor.Name = "cbxDoctor";
            this.cbxDoctor.Size = new System.Drawing.Size(245, 24);
            this.cbxDoctor.TabIndex = 0;
            this.cbxDoctor.SelectedIndexChanged += new System.EventHandler(this.cbxDoctor_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1226, 627);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.panel1.TabIndex = 2;
            // 
            // Doctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1234, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpDoctores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctores";
            this.Text = "Doctores";
            this.Load += new System.EventHandler(this.Doctores_Load);
            this.tbpDoctores.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHorarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbpDoctores;
        private TabPage tabPage1;
        private Button btn_horarios_doctores;
        private Button btn_agregar_doctores;
        private TabPage tabPage2;
        private Label label3;
        private TextBox txtNombreDoctor;
        private Label label2;
        private TextBox txtEspecialidadDoctor;
        private Label label4;
        private TextBox txtTelefonoDoctor;
        private Button btnAgregarDoctor;
        private Label label1;
        private TextBox txtCedulaDoctor;
        private ErrorProvider errorProvider;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label5;
        private ComboBox cbxDoctor;
        private Label label7;
        private DateTimePicker dtpHoraInicio;
        private Label label6;
        private ComboBox cbxDia;
        private Button btnAgregar;
        private DataGridView dtgHorarios;
        private Label label8;
        private DateTimePicker dtpHoraFin;
        private Label label9;
        private Panel panel1;
    }
}