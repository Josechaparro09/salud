using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Inicio:Form
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
            this.label_hora = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_hora
            // 
            this.label_hora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_hora.AutoSize = true;
            this.label_hora.BackColor = System.Drawing.Color.Transparent;
            this.label_hora.Font = new System.Drawing.Font("Century Gothic", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label_hora.Location = new System.Drawing.Point(308, 133);
            this.label_hora.Name = "label_hora";
            this.label_hora.Size = new System.Drawing.Size(448, 157);
            this.label_hora.TabIndex = 0;
            this.label_hora.Text = "HORA";
            // 
            // label_fecha
            // 
            this.label_fecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_fecha.AutoSize = true;
            this.label_fecha.BackColor = System.Drawing.Color.Transparent;
            this.label_fecha.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.label_fecha.Location = new System.Drawing.Point(55, 319);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(200, 70);
            this.label_fecha.TabIndex = 1;
            this.label_fecha.Text = "HORA";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Diseño_sin_título__10_;
            this.pictureBox1.Location = new System.Drawing.Point(483, 515);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1234, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_hora);
            this.Controls.Add(this.label_fecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_hora;
        private Label label_fecha;
        private System.Windows.Forms.Timer horafecha;
        private PictureBox pictureBox1;
    }
}