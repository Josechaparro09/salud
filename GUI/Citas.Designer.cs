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
            btn_modificar_citas = new Button();
            btn_citas_existentes = new Button();
            btn_eliminar_citas = new Button();
            btn_agregar_citas = new Button();
            SuspendLayout();
            // 
            // btn_modificar_citas
            // 
            btn_modificar_citas.Anchor = AnchorStyles.Top;
            btn_modificar_citas.BackColor = Color.FromArgb(49, 66, 82);
            btn_modificar_citas.BackgroundImage = Properties.Resources.Diseño_sin_título__8_2;
            btn_modificar_citas.BackgroundImageLayout = ImageLayout.Stretch;
            btn_modificar_citas.Cursor = Cursors.Hand;
            btn_modificar_citas.FlatStyle = FlatStyle.Flat;
            btn_modificar_citas.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_modificar_citas.ForeColor = Color.FromArgb(237, 237, 235);
            btn_modificar_citas.Location = new Point(605, 330);
            btn_modificar_citas.Name = "btn_modificar_citas";
            btn_modificar_citas.Size = new Size(332, 231);
            btn_modificar_citas.TabIndex = 3;
            btn_modificar_citas.Text = "MODIFICAR\r\nCITAS\r\n";
            btn_modificar_citas.UseVisualStyleBackColor = false;
            // 
            // btn_citas_existentes
            // 
            btn_citas_existentes.Anchor = AnchorStyles.Top;
            btn_citas_existentes.BackColor = Color.FromArgb(49, 66, 82);
            btn_citas_existentes.BackgroundImage = Properties.Resources.Diseño_sin_título__9_1;
            btn_citas_existentes.BackgroundImageLayout = ImageLayout.Stretch;
            btn_citas_existentes.Cursor = Cursors.Hand;
            btn_citas_existentes.FlatStyle = FlatStyle.Flat;
            btn_citas_existentes.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_citas_existentes.ForeColor = Color.FromArgb(237, 237, 235);
            btn_citas_existentes.Location = new Point(237, 330);
            btn_citas_existentes.Name = "btn_citas_existentes";
            btn_citas_existentes.Size = new Size(332, 231);
            btn_citas_existentes.TabIndex = 2;
            btn_citas_existentes.Text = "CITAS \r\nEXISTENTES\r\n";
            btn_citas_existentes.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar_citas
            // 
            btn_eliminar_citas.Anchor = AnchorStyles.Top;
            btn_eliminar_citas.BackColor = Color.Transparent;
            btn_eliminar_citas.BackgroundImage = Properties.Resources.Diseño_sin_título__9_1;
            btn_eliminar_citas.BackgroundImageLayout = ImageLayout.Zoom;
            btn_eliminar_citas.Cursor = Cursors.Hand;
            btn_eliminar_citas.FlatStyle = FlatStyle.Flat;
            btn_eliminar_citas.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_eliminar_citas.ForeColor = Color.FromArgb(237, 237, 235);
            btn_eliminar_citas.Location = new Point(605, 62);
            btn_eliminar_citas.Name = "btn_eliminar_citas";
            btn_eliminar_citas.Size = new Size(332, 231);
            btn_eliminar_citas.TabIndex = 1;
            btn_eliminar_citas.Text = "ELIMINAR \r\nCITAS";
            btn_eliminar_citas.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_citas
            // 
            btn_agregar_citas.Anchor = AnchorStyles.Top;
            btn_agregar_citas.BackColor = Color.FromArgb(107, 151, 224);
            btn_agregar_citas.BackgroundImage = Properties.Resources.Diseño_sin_título__8_2;
            btn_agregar_citas.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar_citas.Cursor = Cursors.Hand;
            btn_agregar_citas.FlatStyle = FlatStyle.Flat;
            btn_agregar_citas.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_agregar_citas.ForeColor = Color.FromArgb(237, 237, 235);
            btn_agregar_citas.Location = new Point(237, 62);
            btn_agregar_citas.Name = "btn_agregar_citas";
            btn_agregar_citas.Size = new Size(332, 231);
            btn_agregar_citas.TabIndex = 0;
            btn_agregar_citas.Text = "AGREGAR \r\nCITAS";
            btn_agregar_citas.UseVisualStyleBackColor = false;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 235);
            ClientSize = new Size(1080, 615);
            Controls.Add(btn_agregar_citas);
            Controls.Add(btn_eliminar_citas);
            Controls.Add(btn_citas_existentes);
            Controls.Add(btn_modificar_citas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Citas";
            Text = "Citas";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_modificar_citas;
        private Button btn_citas_existentes;
        private Button btn_eliminar_citas;
        private Button btn_agregar_citas;
    }
}