using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Inicio
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
            components = new System.ComponentModel.Container();
            label_hora = new Label();
            label_fecha = new Label();
            horafecha = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_hora
            // 
            label_hora.Anchor = AnchorStyles.Top;
            label_hora.AutoSize = true;
            label_hora.BackColor = Color.Transparent;
            label_hora.Font = new Font("Century Gothic", 80.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_hora.ForeColor = Color.FromArgb(49, 66, 82);
            label_hora.Location = new Point(353, 133);
            label_hora.Name = "label_hora";
            label_hora.Size = new Size(357, 126);
            label_hora.TabIndex = 0;
            label_hora.Text = "HORA";
            // 
            // label_fecha
            // 
            label_fecha.Anchor = AnchorStyles.Top;
            label_fecha.AutoSize = true;
            label_fecha.BackColor = Color.Transparent;
            label_fecha.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_fecha.ForeColor = Color.FromArgb(49, 66, 82);
            label_fecha.Location = new Point(253, 307);
            label_fecha.Name = "label_fecha";
            label_fecha.Size = new Size(161, 56);
            label_fecha.TabIndex = 1;
            label_fecha.Text = "HORA";
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Diseño_sin_título__10_;
            pictureBox1.Location = new Point(423, 483);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 237, 235);
            ClientSize = new Size(1080, 615);
            Controls.Add(pictureBox1);
            Controls.Add(label_hora);
            Controls.Add(label_fecha);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_hora;
        private Label label_fecha;
        private System.Windows.Forms.Timer horafecha;
        private PictureBox pictureBox1;
    }
}