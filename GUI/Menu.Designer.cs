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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            barra_titulo = new Panel();
            btn_restaurar = new PictureBox();
            btn_minimizar = new PictureBox();
            btn_maximizar = new PictureBox();
            btn_cerrar = new PictureBox();
            Menu_principal = new Panel();
            btn_cerrar_sesion_menu = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            btn_reportes = new Button();
            btn_doctores = new Button();
            panel1 = new Panel();
            btn_pacientes = new Button();
            panel2 = new Panel();
            btn_citas = new Button();
            btn_inicio = new PictureBox();
            panel_contenedor = new Panel();
            barra_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_restaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            Menu_principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar_sesion_menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_inicio).BeginInit();
            SuspendLayout();
            // 
            // barra_titulo
            // 
            barra_titulo.BackColor = Color.FromArgb(115, 159, 230);
            barra_titulo.Controls.Add(btn_restaurar);
            barra_titulo.Controls.Add(btn_minimizar);
            barra_titulo.Controls.Add(btn_maximizar);
            barra_titulo.Controls.Add(btn_cerrar);
            barra_titulo.Dock = DockStyle.Top;
            barra_titulo.Location = new Point(0, 0);
            barra_titulo.Name = "barra_titulo";
            barra_titulo.Size = new Size(1300, 35);
            barra_titulo.TabIndex = 0;
            barra_titulo.MouseDown += panel_arriba;
            // 
            // btn_restaurar
            // 
            btn_restaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_restaurar.Cursor = Cursors.Hand;
            btn_restaurar.Image = Properties.Resources._3943398;
            btn_restaurar.Location = new Point(1220, 4);
            btn_restaurar.Name = "btn_restaurar";
            btn_restaurar.Size = new Size(25, 25);
            btn_restaurar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_restaurar.TabIndex = 3;
            btn_restaurar.TabStop = false;
            btn_restaurar.Visible = false;
            btn_restaurar.Click += btn_restaurar_Click;
            // 
            // btn_minimizar
            // 
            btn_minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimizar.Cursor = Cursors.Hand;
            btn_minimizar.Image = Properties.Resources.image_removebg_preview__2_;
            btn_minimizar.Location = new Point(1176, 4);
            btn_minimizar.Name = "btn_minimizar";
            btn_minimizar.Size = new Size(25, 25);
            btn_minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_minimizar.TabIndex = 2;
            btn_minimizar.TabStop = false;
            btn_minimizar.Click += btn_minimizar_Click;
            // 
            // btn_maximizar
            // 
            btn_maximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_maximizar.Cursor = Cursors.Hand;
            btn_maximizar.Image = Properties.Resources.image_removebg_preview__3_;
            btn_maximizar.Location = new Point(1220, 4);
            btn_maximizar.Name = "btn_maximizar";
            btn_maximizar.Size = new Size(25, 25);
            btn_maximizar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_maximizar.TabIndex = 1;
            btn_maximizar.TabStop = false;
            btn_maximizar.Click += btn_maximizar_Click;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_cerrar.Cursor = Cursors.Hand;
            btn_cerrar.Image = Properties.Resources.image_removebg_preview__1_;
            btn_cerrar.Location = new Point(1263, 4);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(25, 25);
            btn_cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_cerrar.TabIndex = 0;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // Menu_principal
            // 
            Menu_principal.BackColor = Color.FromArgb(0, 74, 173);
            Menu_principal.Controls.Add(btn_cerrar_sesion_menu);
            Menu_principal.Controls.Add(label1);
            Menu_principal.Controls.Add(panel4);
            Menu_principal.Controls.Add(panel3);
            Menu_principal.Controls.Add(btn_reportes);
            Menu_principal.Controls.Add(btn_doctores);
            Menu_principal.Controls.Add(panel1);
            Menu_principal.Controls.Add(btn_pacientes);
            Menu_principal.Controls.Add(panel2);
            Menu_principal.Controls.Add(btn_citas);
            Menu_principal.Controls.Add(btn_inicio);
            Menu_principal.Dock = DockStyle.Left;
            Menu_principal.Location = new Point(0, 35);
            Menu_principal.Name = "Menu_principal";
            Menu_principal.Size = new Size(220, 615);
            Menu_principal.TabIndex = 1;
            // 
            // btn_cerrar_sesion_menu
            // 
            btn_cerrar_sesion_menu.Anchor = AnchorStyles.Bottom;
            btn_cerrar_sesion_menu.Cursor = Cursors.Hand;
            btn_cerrar_sesion_menu.Image = Properties.Resources.image_removebg_preview__5_;
            btn_cerrar_sesion_menu.Location = new Point(12, 557);
            btn_cerrar_sesion_menu.Name = "btn_cerrar_sesion_menu";
            btn_cerrar_sesion_menu.Size = new Size(40, 37);
            btn_cerrar_sesion_menu.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar_sesion_menu.TabIndex = 7;
            btn_cerrar_sesion_menu.TabStop = false;
            btn_cerrar_sesion_menu.Click += btn_cerrar_sesion_menu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(0, 404);
            label1.Name = "label1";
            label1.Size = new Size(237, 15);
            label1.TabIndex = 0;
            label1.Text = "______________________________________________";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(26, 32, 40);
            panel4.Location = new Point(1, 300);
            panel4.Name = "panel4";
            panel4.Size = new Size(5, 32);
            panel4.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(26, 32, 40);
            panel3.Location = new Point(1, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(5, 32);
            panel3.TabIndex = 3;
            // 
            // btn_reportes
            // 
            btn_reportes.BackColor = Color.FromArgb(0, 74, 173);
            btn_reportes.Cursor = Cursors.Hand;
            btn_reportes.FlatAppearance.BorderSize = 0;
            btn_reportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btn_reportes.FlatStyle = FlatStyle.Flat;
            btn_reportes.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_reportes.ForeColor = SystemColors.ControlLightLight;
            btn_reportes.Location = new Point(4, 300);
            btn_reportes.Name = "btn_reportes";
            btn_reportes.Size = new Size(216, 32);
            btn_reportes.TabIndex = 6;
            btn_reportes.Text = "REPORTES";
            btn_reportes.UseVisualStyleBackColor = false;
            btn_reportes.Click += btn_reportes_Click;
            // 
            // btn_doctores
            // 
            btn_doctores.BackColor = Color.FromArgb(0, 74, 173);
            btn_doctores.Cursor = Cursors.Hand;
            btn_doctores.FlatAppearance.BorderSize = 0;
            btn_doctores.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btn_doctores.FlatStyle = FlatStyle.Flat;
            btn_doctores.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_doctores.ForeColor = SystemColors.ControlLightLight;
            btn_doctores.Location = new Point(4, 246);
            btn_doctores.Name = "btn_doctores";
            btn_doctores.Size = new Size(216, 32);
            btn_doctores.TabIndex = 4;
            btn_doctores.Text = "DOCTORES";
            btn_doctores.UseVisualStyleBackColor = false;
            btn_doctores.Click += btn_doctores_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 32, 40);
            panel1.Location = new Point(1, 195);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 32);
            panel1.TabIndex = 1;
            // 
            // btn_pacientes
            // 
            btn_pacientes.BackColor = Color.FromArgb(0, 74, 173);
            btn_pacientes.Cursor = Cursors.Hand;
            btn_pacientes.FlatAppearance.BorderSize = 0;
            btn_pacientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btn_pacientes.FlatStyle = FlatStyle.Flat;
            btn_pacientes.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_pacientes.ForeColor = SystemColors.ControlLightLight;
            btn_pacientes.Location = new Point(4, 195);
            btn_pacientes.Name = "btn_pacientes";
            btn_pacientes.Size = new Size(216, 32);
            btn_pacientes.TabIndex = 2;
            btn_pacientes.Text = "PACIENTES";
            btn_pacientes.UseVisualStyleBackColor = false;
            btn_pacientes.Click += btn_pacientes_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 32, 40);
            panel2.Location = new Point(1, 143);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 32);
            panel2.TabIndex = 0;
            // 
            // btn_citas
            // 
            btn_citas.BackColor = Color.FromArgb(0, 74, 173);
            btn_citas.Cursor = Cursors.Hand;
            btn_citas.FlatAppearance.BorderSize = 0;
            btn_citas.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 32, 40);
            btn_citas.FlatStyle = FlatStyle.Flat;
            btn_citas.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_citas.ForeColor = SystemColors.ControlLightLight;
            btn_citas.Location = new Point(4, 143);
            btn_citas.Name = "btn_citas";
            btn_citas.Size = new Size(216, 32);
            btn_citas.TabIndex = 0;
            btn_citas.Text = "CITAS";
            btn_citas.UseVisualStyleBackColor = false;
            btn_citas.Click += btn_citas_Click;
            // 
            // btn_inicio
            // 
            btn_inicio.Cursor = Cursors.Hand;
            btn_inicio.Image = Properties.Resources.Simple_Login_Page_Website_Desktop_Prototype__3_;
            btn_inicio.Location = new Point(12, 22);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(194, 45);
            btn_inicio.SizeMode = PictureBoxSizeMode.StretchImage;
            btn_inicio.TabIndex = 0;
            btn_inicio.TabStop = false;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // panel_contenedor
            // 
            panel_contenedor.BackColor = Color.FromArgb(237, 237, 235);
            panel_contenedor.Dock = DockStyle.Fill;
            panel_contenedor.Location = new Point(220, 35);
            panel_contenedor.Name = "panel_contenedor";
            panel_contenedor.Size = new Size(1080, 615);
            panel_contenedor.TabIndex = 2;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(panel_contenedor);
            Controls.Add(Menu_principal);
            Controls.Add(barra_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            barra_titulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_restaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            Menu_principal.ResumeLayout(false);
            Menu_principal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar_sesion_menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_inicio).EndInit();
            ResumeLayout(false);
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
        private Panel panel2;
        private Button btn_reportes;
        private Panel panel3;
        private Button btn_doctores;
        private Panel panel1;
        private Button btn_pacientes;
        private Panel panel4;
        private Label label1;
        private PictureBox btn_cerrar_sesion_menu;
    }
}