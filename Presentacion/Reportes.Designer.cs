using System.Drawing;
using System.Windows.Forms;

namespace Gui
{
    partial class Reportes
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
            this.btn_facturasdentro = new System.Windows.Forms.Button();
            this.btn_reportes_diarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_facturasdentro
            // 
            this.btn_facturasdentro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_facturasdentro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_facturasdentro.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__8_2;
            this.btn_facturasdentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_facturasdentro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_facturasdentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facturasdentro.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facturasdentro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btn_facturasdentro.Location = new System.Drawing.Point(274, 155);
            this.btn_facturasdentro.Name = "btn_facturasdentro";
            this.btn_facturasdentro.Size = new System.Drawing.Size(379, 246);
            this.btn_facturasdentro.TabIndex = 7;
            this.btn_facturasdentro.Text = "FACTURAS";
            this.btn_facturasdentro.UseVisualStyleBackColor = false;
            // 
            // btn_reportes_diarios
            // 
            this.btn_reportes_diarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_reportes_diarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_reportes_diarios.BackgroundImage = global::Presentacion.Properties.Resources.Diseño_sin_título__9_1;
            this.btn_reportes_diarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reportes_diarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reportes_diarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportes_diarios.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportes_diarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btn_reportes_diarios.Location = new System.Drawing.Point(695, 155);
            this.btn_reportes_diarios.Name = "btn_reportes_diarios";
            this.btn_reportes_diarios.Size = new System.Drawing.Size(379, 246);
            this.btn_reportes_diarios.TabIndex = 8;
            this.btn_reportes_diarios.Text = "REPORTES\r\n DIARIOS";
            this.btn_reportes_diarios.UseVisualStyleBackColor = false;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1234, 656);
            this.Controls.Add(this.btn_reportes_diarios);
            this.Controls.Add(this.btn_facturasdentro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_facturasdentro;
        private Button btn_reportes_diarios;
    }
}