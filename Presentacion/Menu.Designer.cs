using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.barra_titulo = new System.Windows.Forms.Panel();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_maximizar = new System.Windows.Forms.PictureBox();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.Menu_principal = new System.Windows.Forms.Panel();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.btn_cerrar_sesion_menu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pDoctores = new System.Windows.Forms.Panel();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.btn_doctores = new System.Windows.Forms.Button();
            this.pPacientes = new System.Windows.Forms.Panel();
            this.btn_pacientes = new System.Windows.Forms.Button();
            this.pCitas = new System.Windows.Forms.Panel();
            this.btn_citas = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.PictureBox();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.timerVerificarDatos = new System.Windows.Forms.Timer(this.components);
            this.barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.Menu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_sesion_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_titulo
            // 
            this.barra_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(159)))), ((int)(((byte)(230)))));
            this.barra_titulo.Controls.Add(this.btn_restaurar);
            this.barra_titulo.Controls.Add(this.btn_minimizar);
            this.barra_titulo.Controls.Add(this.btn_maximizar);
            this.barra_titulo.Controls.Add(this.btn_cerrar);
            this.barra_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra_titulo.Location = new System.Drawing.Point(0, 0);
            this.barra_titulo.Name = "barra_titulo";
            this.barra_titulo.Size = new System.Drawing.Size(1486, 37);
            this.barra_titulo.TabIndex = 0;
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_restaurar.Image = global::Presentacion.Properties.Resources._3943398;
            this.btn_restaurar.Location = new System.Drawing.Point(1394, 4);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(29, 27);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_restaurar.TabIndex = 3;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click_1);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimizar.Image = global::Presentacion.Properties.Resources.image_removebg_preview__2_;
            this.btn_minimizar.Location = new System.Drawing.Point(1344, 4);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(29, 27);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimizar.TabIndex = 2;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click_1);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximizar.Image = global::Presentacion.Properties.Resources.image_removebg_preview__3_;
            this.btn_maximizar.Location = new System.Drawing.Point(1394, 4);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(29, 27);
            this.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_maximizar.TabIndex = 1;
            this.btn_maximizar.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = global::Presentacion.Properties.Resources.image_removebg_preview__1_;
            this.btn_cerrar.Location = new System.Drawing.Point(1443, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(29, 27);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click_1);
            // 
            // Menu_principal
            // 
            this.Menu_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.Menu_principal.Controls.Add(this.btnConfig);
            this.Menu_principal.Controls.Add(this.lbl_usuario);
            this.Menu_principal.Controls.Add(this.btn_cerrar_sesion_menu);
            this.Menu_principal.Controls.Add(this.label1);
            this.Menu_principal.Controls.Add(this.panel4);
            this.Menu_principal.Controls.Add(this.pDoctores);
            this.Menu_principal.Controls.Add(this.btn_reportes);
            this.Menu_principal.Controls.Add(this.btn_doctores);
            this.Menu_principal.Controls.Add(this.pPacientes);
            this.Menu_principal.Controls.Add(this.btn_pacientes);
            this.Menu_principal.Controls.Add(this.pCitas);
            this.Menu_principal.Controls.Add(this.btn_citas);
            this.Menu_principal.Controls.Add(this.btn_inicio);
            this.Menu_principal.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_principal.Location = new System.Drawing.Point(0, 37);
            this.Menu_principal.Name = "Menu_principal";
            this.Menu_principal.Size = new System.Drawing.Size(251, 656);
            this.Menu_principal.TabIndex = 1;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.Image = global::Presentacion.Properties.Resources.ConfigSi;
            this.btnConfig.Location = new System.Drawing.Point(14, 536);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(46, 39);
            this.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfig.TabIndex = 30;
            this.btnConfig.TabStop = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuario.ForeColor = System.Drawing.Color.White;
            this.lbl_usuario.Location = new System.Drawing.Point(10, 502);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(68, 21);
            this.lbl_usuario.TabIndex = 29;
            this.lbl_usuario.Text = "Doctor";
            // 
            // btn_cerrar_sesion_menu
            // 
            this.btn_cerrar_sesion_menu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_cerrar_sesion_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar_sesion_menu.Image = global::Presentacion.Properties.Resources.image_removebg_preview__5_;
            this.btn_cerrar_sesion_menu.Location = new System.Drawing.Point(14, 594);
            this.btn_cerrar_sesion_menu.Name = "btn_cerrar_sesion_menu";
            this.btn_cerrar_sesion_menu.Size = new System.Drawing.Size(46, 39);
            this.btn_cerrar_sesion_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar_sesion_menu.TabIndex = 7;
            this.btn_cerrar_sesion_menu.TabStop = false;
            this.btn_cerrar_sesion_menu.Click += new System.EventHandler(this.btn_cerrar_sesion_menu_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "______________________________________________";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel4.Location = new System.Drawing.Point(1, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 34);
            this.panel4.TabIndex = 4;
            this.panel4.Visible = false;
            // 
            // pDoctores
            // 
            this.pDoctores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pDoctores.Location = new System.Drawing.Point(1, 262);
            this.pDoctores.Name = "pDoctores";
            this.pDoctores.Size = new System.Drawing.Size(6, 34);
            this.pDoctores.TabIndex = 3;
            // 
            // btn_reportes
            // 
            this.btn_reportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_reportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes.FlatAppearance.BorderSize = 0;
            this.btn_reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_reportes.Location = new System.Drawing.Point(5, 320);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(247, 34);
            this.btn_reportes.TabIndex = 6;
            this.btn_reportes.Text = "REPORTES";
            this.btn_reportes.UseVisualStyleBackColor = false;
            this.btn_reportes.Visible = false;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click_1);
            // 
            // btn_doctores
            // 
            this.btn_doctores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_doctores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doctores.FlatAppearance.BorderSize = 0;
            this.btn_doctores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_doctores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctores.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_doctores.Location = new System.Drawing.Point(5, 262);
            this.btn_doctores.Name = "btn_doctores";
            this.btn_doctores.Size = new System.Drawing.Size(247, 34);
            this.btn_doctores.TabIndex = 4;
            this.btn_doctores.Text = "DOCTORES";
            this.btn_doctores.UseVisualStyleBackColor = false;
            this.btn_doctores.Click += new System.EventHandler(this.btn_doctores_Click_1);
            // 
            // pPacientes
            // 
            this.pPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pPacientes.Location = new System.Drawing.Point(1, 208);
            this.pPacientes.Name = "pPacientes";
            this.pPacientes.Size = new System.Drawing.Size(6, 34);
            this.pPacientes.TabIndex = 1;
            // 
            // btn_pacientes
            // 
            this.btn_pacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_pacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pacientes.FlatAppearance.BorderSize = 0;
            this.btn_pacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pacientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pacientes.Location = new System.Drawing.Point(5, 208);
            this.btn_pacientes.Name = "btn_pacientes";
            this.btn_pacientes.Size = new System.Drawing.Size(247, 34);
            this.btn_pacientes.TabIndex = 2;
            this.btn_pacientes.Text = "PACIENTES";
            this.btn_pacientes.UseVisualStyleBackColor = false;
            this.btn_pacientes.Click += new System.EventHandler(this.btn_pacientes_Click_1);
            // 
            // pCitas
            // 
            this.pCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pCitas.Location = new System.Drawing.Point(1, 153);
            this.pCitas.Name = "pCitas";
            this.pCitas.Size = new System.Drawing.Size(6, 34);
            this.pCitas.TabIndex = 0;
            // 
            // btn_citas
            // 
            this.btn_citas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_citas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_citas.FlatAppearance.BorderSize = 0;
            this.btn_citas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_citas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_citas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_citas.Location = new System.Drawing.Point(5, 153);
            this.btn_citas.Name = "btn_citas";
            this.btn_citas.Size = new System.Drawing.Size(247, 34);
            this.btn_citas.TabIndex = 0;
            this.btn_citas.Text = "CITAS";
            this.btn_citas.UseVisualStyleBackColor = false;
            this.btn_citas.Click += new System.EventHandler(this.btn_citas_Click_1);
            // 
            // btn_inicio
            // 
            this.btn_inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inicio.Image = global::Presentacion.Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            this.btn_inicio.Location = new System.Drawing.Point(14, 23);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(222, 48);
            this.btn_inicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_inicio.TabIndex = 0;
            this.btn_inicio.TabStop = false;
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(251, 37);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(1235, 656);
            this.panel_contenedor.TabIndex = 2;
            // 
            // timerVerificarDatos
            // 
            this.timerVerificarDatos.Enabled = true;
            this.timerVerificarDatos.Interval = 300;
            this.timerVerificarDatos.Tick += new System.EventHandler(this.timerVerificarDatos_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 693);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.Menu_principal);
            this.Controls.Add(this.barra_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Enter += new System.EventHandler(this.Menu_Enter);
            this.barra_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.Menu_principal.ResumeLayout(false);
            this.Menu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_sesion_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_inicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel barra_titulo;
        private PictureBox btn_cerrar;
        private Panel Menu_principal;
        private Panel panel_contenedor;
        private PictureBox btn_minimizar;
        private PictureBox btn_maximizar;
        private PictureBox btn_restaurar;
        private Button btn_citas;
        private PictureBox btn_inicio;
        private Panel pCitas;
        private Button btn_reportes;
        private Panel pDoctores;
        private Button btn_doctores;
        private Panel pPacientes;
        private Button btn_pacientes;
        private Panel panel4;
        private Label label1;
        private PictureBox btn_cerrar_sesion_menu;
        private Label lbl_usuario;
        private PictureBox btnConfig;
        private Timer timerVerificarDatos;
    }
}