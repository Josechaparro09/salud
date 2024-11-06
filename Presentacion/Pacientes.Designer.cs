using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Pacientes : Form
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
            this.tbpPaciente = new System.Windows.Forms.TabControl();
            this.ti = new System.Windows.Forms.TabPage();
            this.btn_pacientes_existentes = new System.Windows.Forms.Button();
            this.btn_agregar_eliminar_pacientes = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtBuscarPaciente = new System.Windows.Forms.TextBox();
            this.dtgPacientes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbpPaciente.SuspendLayout();
            this.ti.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpPaciente
            // 
            this.tbpPaciente.Controls.Add(this.ti);
            this.tbpPaciente.Controls.Add(this.tabPage2);
            this.tbpPaciente.Controls.Add(this.tabPage1);
            this.tbpPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpPaciente.Location = new System.Drawing.Point(0, 0);
            this.tbpPaciente.Name = "tbpPaciente";
            this.tbpPaciente.SelectedIndex = 0;
            this.tbpPaciente.Size = new System.Drawing.Size(1234, 656);
            this.tbpPaciente.TabIndex = 8;
            // 
            // ti
            // 
            this.ti.Controls.Add(this.btn_pacientes_existentes);
            this.ti.Controls.Add(this.btn_agregar_eliminar_pacientes);
            this.ti.Location = new System.Drawing.Point(4, 25);
            this.ti.Name = "ti";
            this.ti.Padding = new System.Windows.Forms.Padding(3);
            this.ti.Size = new System.Drawing.Size(1226, 627);
            this.ti.TabIndex = 0;
            this.ti.Text = "Principal";
            this.ti.UseVisualStyleBackColor = true;
            // 
            // btn_pacientes_existentes
            // 
            this.btn_pacientes_existentes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_pacientes_existentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_pacientes_existentes.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__9_1;
            this.btn_pacientes_existentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pacientes_existentes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pacientes_existentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btn_pacientes_existentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pacientes_existentes.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_pacientes_existentes.Location = new System.Drawing.Point(629, 160);
            this.btn_pacientes_existentes.Name = "btn_pacientes_existentes";
            this.btn_pacientes_existentes.Size = new System.Drawing.Size(379, 246);
            this.btn_pacientes_existentes.TabIndex = 9;
            this.btn_pacientes_existentes.Text = "PACIENTES \r\nEXISTENTES\r\n";
            this.btn_pacientes_existentes.UseVisualStyleBackColor = false;
            this.btn_pacientes_existentes.Click += new System.EventHandler(this.btn_pacientes_existentes_Click);
            // 
            // btn_agregar_eliminar_pacientes
            // 
            this.btn_agregar_eliminar_pacientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_agregar_eliminar_pacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_agregar_eliminar_pacientes.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__8_2;
            this.btn_agregar_eliminar_pacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_agregar_eliminar_pacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar_eliminar_pacientes.FlatAppearance.BorderSize = 0;
            this.btn_agregar_eliminar_pacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.btn_agregar_eliminar_pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_eliminar_pacientes.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.btn_agregar_eliminar_pacientes.Location = new System.Drawing.Point(209, 160);
            this.btn_agregar_eliminar_pacientes.Name = "btn_agregar_eliminar_pacientes";
            this.btn_agregar_eliminar_pacientes.Size = new System.Drawing.Size(379, 246);
            this.btn_agregar_eliminar_pacientes.TabIndex = 8;
            this.btn_agregar_eliminar_pacientes.Text = "AGREGAR PACIENTES\r\n";
            this.btn_agregar_eliminar_pacientes.UseVisualStyleBackColor = false;
            this.btn_agregar_eliminar_pacientes.Click += new System.EventHandler(this.btn_agregar_eliminar_pacientes_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtCedula);
            this.tabPage2.Controls.Add(this.btnAgregarPaciente);
            this.tabPage2.Controls.Add(this.dtpFechaNacimiento);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtTelefonoPaciente);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtDireccionPaciente);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtApellidoPaciente);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtNombrePaciente);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1226, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insertar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(313, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 21);
            this.label7.TabIndex = 26;
            this.label7.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtCedula.Location = new System.Drawing.Point(313, 127);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(274, 45);
            this.txtCedula.TabIndex = 25;
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(163)))));
            this.btnAgregarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPaciente.FlatAppearance.BorderSize = 0;
            this.btnAgregarPaciente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnAgregarPaciente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPaciente.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarPaciente.Location = new System.Drawing.Point(505, 458);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(214, 36);
            this.btnAgregarPaciente.TabIndex = 31;
            this.btnAgregarPaciente.Text = "Agregar";
            this.btnAgregarPaciente.UseVisualStyleBackColor = false;
            this.btnAgregarPaciente.Click += new System.EventHandler(this.btnAgregarPaciente_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(639, 356);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(270, 22);
            this.dtpFechaNacimiento.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(635, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(317, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefono";
            // 
            // txtTelefonoPaciente
            // 
            this.txtTelefonoPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtTelefonoPaciente.Location = new System.Drawing.Point(317, 335);
            this.txtTelefonoPaciente.Multiline = true;
            this.txtTelefonoPaciente.Name = "txtTelefonoPaciente";
            this.txtTelefonoPaciente.Size = new System.Drawing.Size(274, 45);
            this.txtTelefonoPaciente.TabIndex = 29;
            this.txtTelefonoPaciente.TextChanged += new System.EventHandler(this.txtTelefonoPaciente_TextChanged);
            this.txtTelefonoPaciente.Enter += new System.EventHandler(this.txtTelefonoPaciente_Enter);
            this.txtTelefonoPaciente.Leave += new System.EventHandler(this.txtTelefonoPaciente_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(635, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Direccíon";
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtDireccionPaciente.Location = new System.Drawing.Point(635, 228);
            this.txtDireccionPaciente.Multiline = true;
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(274, 45);
            this.txtDireccionPaciente.TabIndex = 28;
            this.txtDireccionPaciente.Enter += new System.EventHandler(this.txtDireccionPaciente_Enter);
            this.txtDireccionPaciente.Leave += new System.EventHandler(this.txtDireccionPaciente_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(317, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Apellido";
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtApellidoPaciente.Location = new System.Drawing.Point(317, 228);
            this.txtApellidoPaciente.Multiline = true;
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(274, 45);
            this.txtApellidoPaciente.TabIndex = 27;
            this.txtApellidoPaciente.Enter += new System.EventHandler(this.txtApellidoPaciente_Enter);
            this.txtApellidoPaciente.Leave += new System.EventHandler(this.txtApellidoPaciente_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(631, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombre";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombrePaciente.Location = new System.Drawing.Point(631, 127);
            this.txtNombrePaciente.Multiline = true;
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(274, 45);
            this.txtNombrePaciente.TabIndex = 26;
            this.txtNombrePaciente.Enter += new System.EventHandler(this.txtNombrePaciente_Enter);
            this.txtNombrePaciente.Leave += new System.EventHandler(this.txtNombrePaciente_Leave);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtBuscarPaciente);
            this.tabPage1.Controls.Add(this.dtgPacientes);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1226, 627);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscarPaciente.Location = new System.Drawing.Point(468, 103);
            this.txtBuscarPaciente.Multiline = true;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            this.txtBuscarPaciente.Size = new System.Drawing.Size(274, 45);
            this.txtBuscarPaciente.TabIndex = 18;
            this.txtBuscarPaciente.Text = "BUSCAR";
            this.txtBuscarPaciente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtBuscarPaciente.Enter += new System.EventHandler(this.txtBuscarPaciente_Enter);
            // 
            // dtgPacientes
            // 
            this.dtgPacientes.AllowUserToAddRows = false;
            this.dtgPacientes.AllowUserToDeleteRows = false;
            this.dtgPacientes.AllowUserToOrderColumns = true;
            this.dtgPacientes.AllowUserToResizeColumns = false;
            this.dtgPacientes.AllowUserToResizeRows = false;
            this.dtgPacientes.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.Telefono,
            this.Edit,
            this.Eliminar});
            this.dtgPacientes.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dtgPacientes.Location = new System.Drawing.Point(160, 171);
            this.dtgPacientes.MultiSelect = false;
            this.dtgPacientes.Name = "dtgPacientes";
            this.dtgPacientes.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgPacientes.RowHeadersWidth = 51;
            this.dtgPacientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtgPacientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgPacientes.RowTemplate.Height = 24;
            this.dtgPacientes.Size = new System.Drawing.Size(895, 448);
            this.dtgPacientes.TabIndex = 17;
            this.dtgPacientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPacientes_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Apellido.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Direccion.Width = 98;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Telefono.Width = 90;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::Presentacion.Properties.Resources.btnEditar;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.MinimumWidth = 15;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = global::Presentacion.Properties.Resources.btnEliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(500, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Listado de pacientes";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::Presentacion.Properties.Resources.btnEditar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::Presentacion.Properties.Resources.btnEliminar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1234, 35);
            this.panel1.TabIndex = 9;
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1234, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbpPaciente);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.tbpPaciente.ResumeLayout(false);
            this.ti.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbpPaciente;
        private TabPage ti;
        private Button btn_pacientes_existentes;
        private Button btn_agregar_eliminar_pacientes;
        private TabPage tabPage2;
        private Label label3;
        private Label label4;
        private TextBox txtTelefonoPaciente;
        private Label label2;
        private TextBox txtDireccionPaciente;
        private Label label1;
        private TextBox txtApellidoPaciente;
        private DateTimePicker dtpFechaNacimiento;
        private Label label5;
        private Button btnAgregarPaciente;
        private TabPage tabPage1;
        private DataGridView dtgPacientes;
        private Label label6;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        private DataGridViewImageColumn dataGridViewImageColumn2;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Eliminar;
        private TextBox txtBuscarPaciente;
        private Label label7;
        private TextBox txtCedula;
        private ErrorProvider errorProvider;
        private TextBox txtNombrePaciente;
        private Panel panel1;
    }
}