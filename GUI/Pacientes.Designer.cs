using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Pacientes
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
            btn_buscar_pacientes = new Button();
            btn_editar_pacientes = new Button();
            btn_pacientes_existentes = new Button();
            btn_agregar_eliminar_pacientes = new Button();
            SuspendLayout();
            // 
            // btn_buscar_pacientes
            // 
            btn_buscar_pacientes.Anchor = AnchorStyles.Top;
            btn_buscar_pacientes.BackColor = Color.FromArgb(49, 66, 82);
            btn_buscar_pacientes.BackgroundImage = Properties.Resources.Diseño_sin_título__8_2;
            btn_buscar_pacientes.BackgroundImageLayout = ImageLayout.Stretch;
            btn_buscar_pacientes.Cursor = Cursors.Hand;
            btn_buscar_pacientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 159, 230);
            btn_buscar_pacientes.FlatStyle = FlatStyle.Flat;
            btn_buscar_pacientes.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_buscar_pacientes.Location = new Point(605, 330);
            btn_buscar_pacientes.Name = "btn_buscar_pacientes";
            btn_buscar_pacientes.Size = new Size(332, 231);
            btn_buscar_pacientes.TabIndex = 7;
            btn_buscar_pacientes.Text = "BUSCAR\r\nPACIENTES\r\n\r\n";
            btn_buscar_pacientes.UseVisualStyleBackColor = false;
            // 
            // btn_editar_pacientes
            // 
            btn_editar_pacientes.Anchor = AnchorStyles.Top;
            btn_editar_pacientes.BackColor = Color.FromArgb(49, 66, 82);
            btn_editar_pacientes.BackgroundImage = Properties.Resources.Diseño_sin_título__9_1;
            btn_editar_pacientes.BackgroundImageLayout = ImageLayout.Stretch;
            btn_editar_pacientes.Cursor = Cursors.Hand;
            btn_editar_pacientes.FlatAppearance.BorderSize = 0;
            btn_editar_pacientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 159, 230);
            btn_editar_pacientes.FlatStyle = FlatStyle.Flat;
            btn_editar_pacientes.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_editar_pacientes.Location = new Point(237, 330);
            btn_editar_pacientes.Name = "btn_editar_pacientes";
            btn_editar_pacientes.Size = new Size(332, 231);
            btn_editar_pacientes.TabIndex = 6;
            btn_editar_pacientes.Text = "EDITAR \r\nPACIENTES\r\n";
            btn_editar_pacientes.UseVisualStyleBackColor = false;
            // 
            // btn_pacientes_existentes
            // 
            btn_pacientes_existentes.Anchor = AnchorStyles.Top;
            btn_pacientes_existentes.BackColor = Color.FromArgb(49, 66, 82);
            btn_pacientes_existentes.BackgroundImage = Properties.Resources.Diseño_sin_título__9_1;
            btn_pacientes_existentes.BackgroundImageLayout = ImageLayout.Stretch;
            btn_pacientes_existentes.Cursor = Cursors.Hand;
            btn_pacientes_existentes.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 159, 230);
            btn_pacientes_existentes.FlatStyle = FlatStyle.Flat;
            btn_pacientes_existentes.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_pacientes_existentes.Location = new Point(605, 62);
            btn_pacientes_existentes.Name = "btn_pacientes_existentes";
            btn_pacientes_existentes.Size = new Size(332, 231);
            btn_pacientes_existentes.TabIndex = 5;
            btn_pacientes_existentes.Text = "PACIENTES \r\nEXISTENTES\r\n";
            btn_pacientes_existentes.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_eliminar_pacientes
            // 
            btn_agregar_eliminar_pacientes.Anchor = AnchorStyles.Top;
            btn_agregar_eliminar_pacientes.BackColor = Color.FromArgb(49, 66, 82);
            btn_agregar_eliminar_pacientes.BackgroundImage = Properties.Resources.Diseño_sin_título__8_2;
            btn_agregar_eliminar_pacientes.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar_eliminar_pacientes.Cursor = Cursors.Hand;
            btn_agregar_eliminar_pacientes.FlatAppearance.BorderSize = 0;
            btn_agregar_eliminar_pacientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 159, 230);
            btn_agregar_eliminar_pacientes.FlatStyle = FlatStyle.Flat;
            btn_agregar_eliminar_pacientes.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_agregar_eliminar_pacientes.Location = new Point(237, 62);
            btn_agregar_eliminar_pacientes.Name = "btn_agregar_eliminar_pacientes";
            btn_agregar_eliminar_pacientes.Size = new Size(332, 231);
            btn_agregar_eliminar_pacientes.TabIndex = 4;
            btn_agregar_eliminar_pacientes.Text = "AGREGAR/\r\nELIMINAR\r\nPACIENTES\r\n";
            btn_agregar_eliminar_pacientes.UseVisualStyleBackColor = false;
            // 
            // Pacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 235);
            ClientSize = new Size(1080, 615);
            Controls.Add(btn_buscar_pacientes);
            Controls.Add(btn_editar_pacientes);
            Controls.Add(btn_pacientes_existentes);
            Controls.Add(btn_agregar_eliminar_pacientes);
            ForeColor = Color.FromArgb(237, 237, 235);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pacientes";
            Text = "Pacientes";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_buscar_pacientes;
        private Button btn_editar_pacientes;
        private Button btn_pacientes_existentes;
        private Button btn_agregar_eliminar_pacientes;
    }
}