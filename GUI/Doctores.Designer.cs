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
            btn_doctores_disponibles = new Button();
            btn_horarios_doctores = new Button();
            btn_agregar_doctores = new Button();
            SuspendLayout();
            // 
            // btn_doctores_disponibles
            // 
            btn_doctores_disponibles.Anchor = AnchorStyles.Top;
            btn_doctores_disponibles.BackColor = Color.FromArgb(49, 66, 82);
            btn_doctores_disponibles.BackgroundImage = Properties.Resources.Diseño_sin_título__9_1;
            btn_doctores_disponibles.BackgroundImageLayout = ImageLayout.Stretch;
            btn_doctores_disponibles.Cursor = Cursors.Hand;
            btn_doctores_disponibles.FlatStyle = FlatStyle.Flat;
            btn_doctores_disponibles.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_doctores_disponibles.ForeColor = Color.FromArgb(237, 237, 235);
            btn_doctores_disponibles.Location = new Point(237, 330);
            btn_doctores_disponibles.Name = "btn_doctores_disponibles";
            btn_doctores_disponibles.Size = new Size(332, 231);
            btn_doctores_disponibles.TabIndex = 6;
            btn_doctores_disponibles.Text = "DOCTORES\r\nDISPONIBLES\r\n";
            btn_doctores_disponibles.UseVisualStyleBackColor = false;
            // 
            // btn_horarios_doctores
            // 
            btn_horarios_doctores.Anchor = AnchorStyles.Top;
            btn_horarios_doctores.BackColor = Color.FromArgb(49, 66, 82);
            btn_horarios_doctores.BackgroundImage = Properties.Resources.Diseño_sin_título__9_1;
            btn_horarios_doctores.BackgroundImageLayout = ImageLayout.Stretch;
            btn_horarios_doctores.Cursor = Cursors.Hand;
            btn_horarios_doctores.FlatStyle = FlatStyle.Flat;
            btn_horarios_doctores.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_horarios_doctores.ForeColor = Color.FromArgb(237, 237, 235);
            btn_horarios_doctores.Location = new Point(605, 62);
            btn_horarios_doctores.Name = "btn_horarios_doctores";
            btn_horarios_doctores.Size = new Size(332, 231);
            btn_horarios_doctores.TabIndex = 5;
            btn_horarios_doctores.Text = "HORARIOS\r\nDOCTORES\r\n";
            btn_horarios_doctores.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_doctores
            // 
            btn_agregar_doctores.Anchor = AnchorStyles.Top;
            btn_agregar_doctores.BackColor = Color.FromArgb(49, 66, 82);
            btn_agregar_doctores.BackgroundImage = Properties.Resources.Diseño_sin_título__8_2;
            btn_agregar_doctores.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar_doctores.Cursor = Cursors.Hand;
            btn_agregar_doctores.FlatStyle = FlatStyle.Flat;
            btn_agregar_doctores.Font = new Font("Century Gothic", 24F, FontStyle.Bold);
            btn_agregar_doctores.ForeColor = Color.FromArgb(237, 237, 235);
            btn_agregar_doctores.Location = new Point(237, 62);
            btn_agregar_doctores.Name = "btn_agregar_doctores";
            btn_agregar_doctores.Size = new Size(332, 231);
            btn_agregar_doctores.TabIndex = 4;
            btn_agregar_doctores.Text = "AGREGAR \r\nDOCTORES\r\n";
            btn_agregar_doctores.UseVisualStyleBackColor = false;
            // 
            // Doctores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 235);
            ClientSize = new Size(1080, 615);
            Controls.Add(btn_doctores_disponibles);
            Controls.Add(btn_horarios_doctores);
            Controls.Add(btn_agregar_doctores);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Doctores";
            Text = "Doctores";
            ResumeLayout(false);
        }

        #endregion
        private Button btn_doctores_disponibles;
        private Button btn_horarios_doctores;
        private Button btn_agregar_doctores;
    }
}